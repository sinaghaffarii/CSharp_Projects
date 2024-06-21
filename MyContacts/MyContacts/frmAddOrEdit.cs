using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        Contact_DBEntities db = new Contact_DBEntities();
        //IContactRepository repository;
        public int contactId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            // repository = new ContactRepository();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        bool ValidationInputs()
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی خود را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا شماره موبایل خود را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAge.Value == 0)
            {
                MessageBox.Show("لطفا سن خود را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("لطفا ایمیل خود را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (contactId == 0)
            {
                this.Text = "افزودن مخاطب جدید";
            }
            else
            {
                this.Text = "ویرایش مخاطب";

                // ADO.NET
                //DataTable dt = repository.SelectRow(contactId);
                //txtName.Text = dt.Rows[0][1].ToString();
                //txtFamily.Text = dt.Rows[0][2].ToString();
                //txtMobile.Text = dt.Rows[0][3].ToString();
                //txtEmail.Text = dt.Rows[0][4].ToString();
                //txtAge.Text = dt.Rows[0][5].ToString();
                //txtAddress.Text = dt.Rows[0][6].ToString();


                // EF CORE
                MyContact contact = db.MyContacts.Find(contactId);
                txtName.Text = contact.Name;
                txtFamily.Text = contact.Family;
                txtMobile.Text = contact.Mobile;
                txtEmail.Text = contact.Email;
                txtAge.Text = contact.Age.ToString();
                txtAddress.Text = contact.Address;

                btnSubmit.Text = "ویرایش";

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidationInputs())
            {
                //repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                //repository.Update(contactId, txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);

              

                if (contactId == 0)
                {
                    MyContact contact = new MyContact();
                    contact.Name = txtName.Text;
                    contact.Family = txtFamily.Text;
                    contact.Mobile = txtMobile.Text;
                    contact.Email = txtEmail.Text;
                    contact.Age = (int)txtAge.Value;
                    contact.Address = txtAddress.Text;
                    db.MyContacts.Add(contact);
                }
                else
                {
                    var contact = db.MyContacts.Find(contactId);
                    contact.Name = txtName.Text;
                    contact.Family = txtFamily.Text;
                    contact.Mobile = txtMobile.Text;
                    contact.Email = txtEmail.Text;
                    contact.Age = (int)txtAge.Value;
                    contact.Address = txtAddress.Text;
                }
                db.SaveChanges();
                MessageBox.Show("عملیات با موفقیت انجام شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

       
    }
}
