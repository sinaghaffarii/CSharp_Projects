﻿using System;
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
        IContactRepository repository;
        public Contacts()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            dgContacts.AutoGenerateColumns = false;
             dgContacts.DataSource = repository.SelectAll();
        }
    }
}
