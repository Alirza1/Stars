namespace PetrolMVP
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.byLiter = new System.Windows.Forms.RadioButton();
            this.byLiterTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.petrolPriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.byPriceTxtb = new System.Windows.Forms.TextBox();
            this.byPrice = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Petrol";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // byLiter
            // 
            this.byLiter.AutoSize = true;
            this.byLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLiter.Location = new System.Drawing.Point(74, 192);
            this.byLiter.Name = "byLiter";
            this.byLiter.Size = new System.Drawing.Size(97, 24);
            this.byLiter.TabIndex = 2;
            this.byLiter.TabStop = true;
            this.byLiter.Text = "By Liter";
            this.byLiter.UseVisualStyleBackColor = true;
            this.byLiter.CheckedChanged += new System.EventHandler(this.byLiter_CheckedChanged);
            // 
            // byLiterTxtb
            // 
            this.byLiterTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLiterTxtb.Location = new System.Drawing.Point(205, 189);
            this.byLiterTxtb.Name = "byLiterTxtb";
            this.byLiterTxtb.Size = new System.Drawing.Size(74, 27);
            this.byLiterTxtb.TabIndex = 3;
            this.byLiterTxtb.TextChanged += new System.EventHandler(this.byLiterTxtb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // petrolPriceLbl
            // 
            this.petrolPriceLbl.AutoSize = true;
            this.petrolPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolPriceLbl.Location = new System.Drawing.Point(182, 89);
            this.petrolPriceLbl.Name = "petrolPriceLbl";
            this.petrolPriceLbl.Size = new System.Drawing.Size(76, 29);
            this.petrolPriceLbl.TabIndex = 5;
            this.petrolPriceLbl.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "azn";
            // 
            // byPriceTxtb
            // 
            this.byPriceTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPriceTxtb.Location = new System.Drawing.Point(205, 242);
            this.byPriceTxtb.Name = "byPriceTxtb";
            this.byPriceTxtb.Size = new System.Drawing.Size(74, 27);
            this.byPriceTxtb.TabIndex = 8;
            this.byPriceTxtb.TextChanged += new System.EventHandler(this.byPriceTxtb_TextChanged);
            // 
            // byPrice
            // 
            this.byPrice.AutoSize = true;
            this.byPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPrice.Location = new System.Drawing.Point(74, 245);
            this.byPrice.Name = "byPrice";
            this.byPrice.Size = new System.Drawing.Size(102, 24);
            this.byPrice.TabIndex = 7;
            this.byPrice.TabStop = true;
            this.byPrice.Text = "By Price";
            this.byPrice.UseVisualStyleBackColor = true;
            this.byPrice.CheckedChanged += new System.EventHandler(this.byPrice_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment";
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLbl.Location = new System.Drawing.Point(248, 416);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(117, 42);
            this.paymentLbl.TabIndex = 10;
            this.paymentLbl.Text = "00.00";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 578);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.byPriceTxtb);
            this.Controls.Add(this.byPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.petrolPriceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.byLiterTxtb);
            this.Controls.Add(this.byLiter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton byLiter;
        private System.Windows.Forms.TextBox byLiterTxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label petrolPriceLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox byPriceTxtb;
        private System.Windows.Forms.RadioButton byPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label paymentLbl;
    }
}

