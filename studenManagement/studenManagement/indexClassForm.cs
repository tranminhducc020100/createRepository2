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
    public partial class indexClassForm : Form
    {
        private classManagement Business;
        public indexClassForm()
        {

            InitializeComponent();
            this.Business = new classManagement();
            this.Load += indexClassForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdClasses.DoubleClick += grdClasses_DoubleClick;
        }

        void grdClasses_DoubleClick(object sender, EventArgs e)
        {
            var @class = (CLASS)this.grdClasses.SelectedRows[0].DataBoundItem;
            var updateForm = new updateClassForm(@class.ID);
            updateForm.ShowDialog();
            this.LoadAllClasses();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdClasses.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (CLASS)this.grdClasses.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(@class.ID);
                    MessageBox.Show("Delete class successfully!");
                    this.LoadAllClasses();
                }
            }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new createClassForm();
            createForm.ShowDialog();
            this.LoadAllClasses();
        }

        void indexClassForm_Load(object sender, EventArgs e)
        {
            this.LoadAllClasses();

        }
        private void LoadAllClasses()
        {
            var classes = this.Business.GetClasses();
            this.grdClasses.DataSource = classes;

        }
    }
}
