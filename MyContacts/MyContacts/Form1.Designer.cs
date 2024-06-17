namespace MyContacts
{
    partial class Contacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel1.Text = "دفترچه تلفن";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(594, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgContacts);
            this.groupBox2.Location = new System.Drawing.Point(9, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست شماره ها";
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.MyName,
            this.family,
            this.Email,
            this.Mobile,
            this.Age});
            this.dgContacts.Location = new System.Drawing.Point(6, 22);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.Size = new System.Drawing.Size(581, 240);
            this.dgContacts.TabIndex = 0;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "ContactId";
            this.ContactId.HeaderText = "کد شخص";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            // 
            // MyName
            // 
            this.MyName.DataPropertyName = "Name";
            this.MyName.HeaderText = "نام";
            this.MyName.Name = "MyName";
            this.MyName.ReadOnly = true;
            // 
            // family
            // 
            this.family.DataPropertyName = "Family";
            this.family.HeaderText = "فامیلی";
            this.family.Name = "family";
            this.family.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "سن";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Shabnam FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contacts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.Contacts_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

