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
    public partial class frmAddOrEdit : Form
    {
        IContactRepository repository;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactRepository();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidationInputs())
            {
                bool isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            this.Text = "افزودن مخاطب جدید";
        }
    }
}
