using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContacts
{
    internal class ContactRepository : IContactRepository
    {
        // Data Base Address
        private string connectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true";
        public bool Delect(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, int mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string qurey = "Select * From MyContact";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int ContactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string name, string family, int mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
