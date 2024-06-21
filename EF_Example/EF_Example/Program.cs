using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONNECTION DB
            EF_DBEntities db = new EF_DBEntities();

            // INSERT
            //Person p1 = new Person() { Name = "ahmad", Family = "khosravi", Age = 10 };
            //db.People.Add(p1);

            // EDIT 
            Person user = db.People.SingleOrDefault(u => u.PersonID == 9);
            //if (user != null)
            //{
            //    user.Name = "Neda";
            //    user.Family = "Khalife";
            //    user.Age = 28;
            //}


            // DELETE
            db.People.Remove(user);

            // for save changes in dataBase
            db.SaveChanges();

            var list = db.People.ToList();
            var list1 = db.People.Where(n => n.Age > 30).ToList();
            var list2 = db.People.OrderByDescending(n => n.Age).ToList();

            foreach (Person p in list)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.Family} Age : {p.Age}");
            }

            Console.ReadKey();
        }
    }
}
