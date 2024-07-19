using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

class Program
{

    // نمونه Random در سطح برنامه
    static Random random = new Random();
    [Obsolete]
    static void Main()
    {
        // تاریخ مورد نظر: خرداد ماه
        int year = 1403; // سال خورشیدی

        int month;   // ماه خورشیدی

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Which one of the months do you choose to create your entry and exit transition?");
        month = Convert.ToInt32(Console.ReadLine());


        // نام فایل اکسل که می‌خواهیم ایجاد کنیم
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "workingHours.xlsx");

        // تعریف یک تقویم شمسی برای ماه خرداد
        PersianCalendar persianCalendar = new PersianCalendar();
        int daysInMonth = persianCalendar.GetDaysInMonth(year, month);

        // ایجاد یک نمونه از کلاس XSSFWorkbook برای ساخت فایل Excel
        XSSFWorkbook workbook = new XSSFWorkbook();
        ISheet worksheet = workbook.CreateSheet("میرسینا غفاری");

        worksheet.IsRightToLeft = true;

        // تنظیم عرض ستون‌ها
        worksheet.SetColumnWidth(0, 15 * 200); // عرض ستون اول
        worksheet.SetColumnWidth(1, 15 * 200); // عرض ستون دوم
        worksheet.SetColumnWidth(2, 15 * 150); // عرض ستون سوم
        worksheet.SetColumnWidth(3, 15 * 150); // عرض ستون چهارم
        worksheet.SetColumnWidth(4, 15 * 150); // عرض ستون پنجم
        worksheet.SetColumnWidth(5, 15 * 150); // عرض ستون ششم
        worksheet.SetColumnWidth(6, 15 * 150); // عرض ستون هفتم
        worksheet.SetColumnWidth(7, 15 * 256); // عرض ستون هشتم


        // روزهای هفته به فارسی با ترتیب درست (دوشنبه به عنوان روز اول)
        string[] persianDaysOfWeek = { "یک‌شنبه", "دوشنبه", "سه‌شنبه", "چهارشنبه", "پنج‌شنبه", "جمعه", "شنبه" };

        // تنظیم عنوان ستون‌ها
        IRow headerRow = worksheet.CreateRow(0);
        headerRow.CreateCell(0).SetCellValue("روز");
        headerRow.CreateCell(1).SetCellValue("تاریخ");
        headerRow.CreateCell(2).SetCellValue("ورود");
        headerRow.CreateCell(3).SetCellValue("خروج");
        headerRow.CreateCell(4).SetCellValue("میزان حضور");
        headerRow.CreateCell(5).SetCellValue("زمان مجاز");
        headerRow.CreateCell(6).SetCellValue("میزان تاخیر");
        headerRow.CreateCell(7).SetCellValue("");

        //// ایجاد استایل برای سلول‌های عنوان
        //ICellStyle headerStyle = workbook.CreateCellStyle();
        //IFont headerFont = workbook.CreateFont();
        //headerFont.Boldweight = (short)FontBoldWeight.Bold;
        //headerStyle.SetFont(headerFont);

        //for (int i = 0; i < 4; i++)
        //{
        //    headerRow.GetCell(i).CellStyle = headerStyle;
        //}

        // شمارنده برای ردیف‌ها
        int rowNumber = 1;

        // ایجاد ردیف‌ها بر اساس تقویم شمسی
        for (int day = 1; day <= daysInMonth; day++)
        {
            // تعیین تاریخ خورشیدی
            DateTime date = persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);

            // نام روز در تقویم میلادی
            string dayName = persianDaysOfWeek[(int)persianCalendar.GetDayOfWeek(date)];

            // تشخیص تعطیلی رسمی (جمعه و پنجشنبه)
            bool isOfficialHoliday = (dayName == "جمعه" || dayName == "پنج‌شنبه");

            // تنظیم مقادیر ستون‌ها برای روز جاری
            IRow row = worksheet.CreateRow(rowNumber++);
            row.CreateCell(0).SetCellValue($"{dayName}");

            // تنظیم تاریخ خورشیدی
            string persianDate = $"{persianCalendar.GetYear(date)}/{persianCalendar.GetMonth(date)}/{persianCalendar.GetDayOfMonth(date)}";
            row.CreateCell(1).SetCellValue(persianDate);

            // اگر روز تعطیل رسمی باشد، ستون‌های ساعت ورود و خروج را به "تعطیل رسمی" تنظیم کنید
            if (isOfficialHoliday)
            {
                row.CreateCell(2).SetCellValue("");
                if (dayName == "پنج‌شنبه")
                {
                    row.CreateCell(7).SetCellValue("تعطیل");
                }
                else
                {
                    row.CreateCell(7).SetCellValue("تعطیل رسمی");
                }
            }
            else
            {
                // در غیر این صورت، ساعت ورود و خروج را به صورت تصادفی در محدوده‌های زمانی مشخص تنظیم کنید
                row.CreateCell(2).SetCellValue(GenerateRandomTime(8, 45, 9, 10));
                row.CreateCell(3).SetCellValue(GenerateRandomTime(18, 00, 18, 20));
            }
        }
        // محاسبه میزان حضور
        for (int i = 1; i < rowNumber; i++)
        {
            IRow currentRow = worksheet.GetRow(i);
            ICell entryCell = currentRow.GetCell(2);
            ICell exitCell = currentRow.GetCell(3);
            ICell presenceCell = currentRow.CreateCell(4);

            if (entryCell != null && exitCell != null)
            {
                TimeSpan entryTime = TimeSpan.Parse(entryCell.StringCellValue);
                TimeSpan exitTime = TimeSpan.Parse(exitCell.StringCellValue);

                TimeSpan presenceTime = exitTime - entryTime;
                presenceCell.SetCellValue($"{presenceTime.Hours}:{presenceTime.Minutes:D2}");
            }
        }


        // ذخیره فایل Excel در مسیر مشخص شده
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            workbook.Write(fileStream);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"---------------{filePath}--------------");
        Console.ReadKey();
    }

    // تابع برای تولید ساعت رندوم در یک بازه زمانی مشخص
    static string GenerateRandomTime(int startHour, int startMinute, int endHour, int endMinute)
    {
        int hour = random.Next(startHour, endHour + 1);
        int minute;

        if (hour == startHour)
        {
            minute = random.Next(startMinute, 60);
        }
        else if (hour == endHour)
        {
            minute = random.Next(0, endMinute + 1);
        }
        else
        {
            minute = random.Next(0, 60);
        }

        return $"{hour}:{minute:D2}";
    }
}
