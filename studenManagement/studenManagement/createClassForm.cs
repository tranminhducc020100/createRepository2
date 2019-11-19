﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studenManagement
{
    public partial class createClassForm : Form
    {
        private classManagement Business;
        public createClassForm()
        {
            InitializeComponent();
            this.Business = new classManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var description = this.txtDescription.Text;
            this.Business.addClass(name, description);
            MessageBox.Show("Create class successfully!");
        }
    }
}
