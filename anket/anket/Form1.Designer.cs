namespace anket
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.numberMtxtb = new System.Windows.Forms.MaskedTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.numberMtxtb);
            this.panel1.Controls.Add(this.emailTxtb);
            this.panel1.Controls.Add(this.surnameTxtb);
            this.panel1.Controls.Add(this.nameTxtb);
            this.panel1.Controls.Add(this.numberLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.surnameLbl);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(114, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 374);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(329, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(314, 38);
            this.title.TabIndex = 0;
            this.title.Text = "STEP IT LOGIN";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(23, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // surnameLbl
            // 
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(23, 91);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(94, 23);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "Surname";
            // 
            // emailLbl
            // 
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(23, 141);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(68, 23);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "E-Mail";
            // 
            // numberLbl
            // 
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(23, 189);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(82, 23);
            this.numberLbl.TabIndex = 3;
            this.numberLbl.Text = "Number";
            // 
            // nameTxtb
            // 
            this.nameTxtb.Location = new System.Drawing.Point(163, 39);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(162, 22);
            this.nameTxtb.TabIndex = 4;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Location = new System.Drawing.Point(163, 95);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(162, 22);
            this.surnameTxtb.TabIndex = 5;
            // 
            // emailTxtb
            // 
            this.emailTxtb.Location = new System.Drawing.Point(163, 145);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(162, 22);
            this.emailTxtb.TabIndex = 6;
            // 
            // numberMtxtb
            // 
            this.numberMtxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMtxtb.Location = new System.Drawing.Point(163, 189);
            this.numberMtxtb.Mask = "000-000-00-00";
            this.numberMtxtb.Name = "numberMtxtb";
            this.numberMtxtb.Size = new System.Drawing.Size(162, 27);
            this.numberMtxtb.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(455, 272);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 40);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 588);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox numberMtxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button saveBtn;
    }
}

