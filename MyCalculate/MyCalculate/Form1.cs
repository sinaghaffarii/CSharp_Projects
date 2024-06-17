using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculate
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidationInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is :" + sum);
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidationInputs())
            {
                int sum = calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Minus is :" + sum);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidationInputs())
            {
                int sum = calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Divide is :" + sum);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidationInputs())
            {
                int sum = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple is :" + sum);
            }
        }

        private bool ValidationInputs()
        {
            bool isValid = true;
            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد نمایید.");
            }
            else
            {
                if (txtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد نمایید.");
                }
            }

            return isValid;
        }


    }
}
