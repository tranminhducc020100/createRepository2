namespace studenManagement
{
    partial class updateClassForm
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
            this.lblClassName2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtDesciption2 = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClassName2
            // 
            this.lblClassName2.AutoSize = true;
            this.lblClassName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName2.Location = new System.Drawing.Point(12, 36);
            this.lblClassName2.Name = "lblClassName2";
            this.lblClassName2.Size = new System.Drawing.Size(86, 13);
            this.lblClassName2.TabIndex = 0;
            this.lblClassName2.Text = "Class\'s Name:";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(12, 69);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(75, 13);
            this.lblDescription2.TabIndex = 1;
            this.lblDescription2.Text = "Description:";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(104, 33);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(319, 20);
            this.txtName2.TabIndex = 2;
            // 
            // txtDesciption2
            // 
            this.txtDesciption2.Location = new System.Drawing.Point(104, 62);
            this.txtDesciption2.Name = "txtDesciption2";
            this.txtDesciption2.Size = new System.Drawing.Size(319, 20);
            this.txtDesciption2.TabIndex = 3;
            this.txtDesciption2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSave2
            // 
            this.btnSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(141, 98);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 4;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Location = new System.Drawing.Point(270, 98);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 5;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // updateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 144);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtDesciption2);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblClassName2);
            this.Name = "updateClassForm";
            this.Text = "updateClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtDesciption2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnCancel2;
    }
}