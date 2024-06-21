using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class Contacts : Form
    {
        //IContactRepository repository;
        public Contacts()
        {
            InitializeComponent();
            //repository = new ContactRepository();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (Contact_DBEntities db = new Contact_DBEntities())
            {
                dgContacts.AutoGenerateColumns = false;
                dgContacts.DataSource = db.MyContacts.ToList();
                // dgContacts.DataSource = repository.SelectAll();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
                string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
                string fullName = name + " " + family;
                if (MessageBox.Show($"آیا از حذف {fullName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                    using (Contact_DBEntities db = new Contact_DBEntities())
                    {
                        MyContact contact = db.MyContacts.Single(c => c.ContactId == contactId);
                        if (contact != null)
                        {
                            db.MyContacts.Remove(contact);
                            db.SaveChanges();
                            // Optionally handle any additional logic after deletion.
                        }
                    }
                    //repository.Delete(contactId);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب نمایید.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.contactId = contactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب نمایید.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            using (Contact_DBEntities db = new Contact_DBEntities())
            {
                dgContacts.DataSource = db.MyContacts.Where(c => c.Name.Contains(txtSearch.Text) ||
                    c.Family.Contains(txtSearch.Text)).ToList();
            };
            // dgContacts.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
