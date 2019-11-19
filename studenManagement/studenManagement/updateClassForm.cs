using System;
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
    public partial class updateClassForm : Form
    {
        private int ClassId;
        private classManagement Business;
        public updateClassForm(int id)
        {
            this.ClassId = id;
            this.Business = new classManagement();
            InitializeComponent();
            this.btnSave2.Click += btnSave2_Click;
            this.btnCancel2.Click += btnCancel2_Click;
            this.Load += updateClassForm_Load;
        }

        void updateClassForm_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetClass(this.ClassId);
            this.txtName2.Text = @class.NAME;
            this.txtDesciption2.Text = @class.DESCRIPTION;
        }

        void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave2_Click(object sender, EventArgs e)
        {
            var name = this.txtName2.Text;
            var description = this.txtDesciption2.Text;
            this.Business.EditClass(this.ClassId, name, description);
            MessageBox.Show("Update class successfully!");
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
