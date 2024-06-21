using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Peaple = new List<Person>();
            // روش اول برای اضافه کردن آبجکت به آرایمون
            // instance 
            Person p1 = new Person();

            p1.PersonID = 1;
            p1.Name = "Sina";
            p1.Family = "Ghaffari";
            p1.Age = 27;

            Peaple.Add(p1);

            // روش دوم برای اضافه کردن آبجکت به آرایمون
            // این روش اسمش هست Object initializer

            Person p2 = new Person()
            {
                PersonID = 2,
                Name = "Amin",
                Family = "Ghaffari",
                Age = 29
            };
            Peaple.Add(p2);

            // روش دوم برای اضافه کردن آبجکت به آرایمون
            // روش سوم زیاد مورد استفاده قرار نمیگیره

            Peaple.Add(new Person() { PersonID = 3, Name = "mehdi", Family = "mostafavi", Age = 35 });


            // estefade az lambda expretion baraye query zadan be list ha ke badan gharare be table mon query bezanim.

            var result1 = Peaple.ToList();
            // مرتب کردن بر اساس سن
            var result2 = Peaple.OrderBy(n => n.Age).ToList();
            var result3 = Peaple.OrderByDescending(n => n.Age).ToList();
            // اگر این اسم رو داشت برام بیار
            var result4 = Peaple.Where(n => n.Name.ToLower() == "sina").ToList();
            // اونایی که سنشون زیر 40 و بالای 25 باشه رو بیار
            var result5 = Peaple.Where(n => n.Age > 25 && n.Age < 35).ToList();
            // اگه بخواهیم از لیستمون فقط اسم هارو بکشیم بیرون و درون آرایه بریزیم به این شکل عمل میکنیم
            var result6 = Peaple.Select(n => n.Name).ToList();
            // برای این که فقط به از لیست اسم و فامیلی رو برام بکشه بیرون باید به این صورت بنویسیمش 
            var result7 = Peaple.Select(n => new { n.Name, n.Family }).ToList();

            foreach (Person p in result5)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.Family} age : {p.Age}");
            }



            // Collection Initializer
            List<PersonCar> Cars = new List<PersonCar>() {
                new PersonCar()
                {
                    PersonID = 1,
                    CarName = "Pride",
                    CarModel = "1345"
                },
                new PersonCar()
                {
                    PersonID = 2,
                    CarName = "Peykan",
                    CarModel = "2010"
                }
            };
            // برای این که دو تا آبجکت رو بر اساس آی دی به هم join کنیم از این روش استفاده میکنیم
            var join = (from p in Peaple
                        join c in Cars on p.PersonID equals c.PersonID
                        select new
                        {
                            p.PersonID,
                            p.Name,
                            p.Family,
                            p.Age,
                            c.CarName,
                            c.CarModel
                        }
                        ).ToList();

            // مقدار های تکراری را از این مجموعه پاک میکنه
            int[] numbers = { 1, 2, 3, 4, 4, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var res1 = numbers.Distinct().ToArray();
            // سه تا آخریو فقط نشون بده
            var res2 = numbers.OrderByDescending(n => n).Take(3).ToArray();
            // سه تا آخریو نشون نده بقیشون نشون بده
            var res3 = numbers.OrderByDescending(n => n).Skip(3).ToArray();


            Console.ReadKey();
        }
    }
}
