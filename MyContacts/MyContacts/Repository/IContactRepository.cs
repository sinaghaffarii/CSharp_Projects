using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContacts
{
    internal interface IContactRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactId);
        bool Insert(string name, string family, string mobile, string email, int age, string address);
        bool Update(int contactId, string name, string family, string mobile, string email, int age, string address);
        bool Delect(int contactId);
    }
}
