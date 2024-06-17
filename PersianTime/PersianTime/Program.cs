using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime thisTime = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Today in the Persian Calendar:    {0}, {3}/{1}/{2} {4}:{5}:{6}\n",
                     pc.GetDayOfWeek(thisTime),
                     pc.GetMonth(thisTime),
                     pc.GetDayOfMonth(thisTime),
                     pc.GetYear(thisTime),
                     pc.GetHour(thisTime),
                     pc.GetMinute(thisTime),
                     pc.GetSecond(thisTime));

            Console.ReadKey();
        }
    }
}
