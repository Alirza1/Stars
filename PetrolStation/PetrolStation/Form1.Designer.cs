namespace PetrolStation
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
            this.petrolCmbx = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.byPriceTxtb = new System.Windows.Forms.TextBox();
            this.petrolPaymentlbl = new System.Windows.Forms.Label();
            this.byPriceRadio = new System.Windows.Forms.RadioButton();
            this.byLiterRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.byLiterTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.petrolPriceLbl = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.marketGb = new System.Windows.Forms.GroupBox();
            this.hamburgerChkb = new System.Windows.Forms.CheckBox();
            this.sirabPriceLbl = new System.Windows.Forms.Label();
            this.sirabChkb = new System.Windows.Forms.CheckBox();
            this.hotdogChkb = new System.Windows.Forms.CheckBox();
            this.cocacolaChkb = new System.Windows.Forms.CheckBox();
            this.sirabTxtb = new System.Windows.Forms.TextBox();
            this.frenchfChkb = new System.Windows.Forms.CheckBox();
            this.hamburgerPriceLbl = new System.Windows.Forms.Label();
            this.hamburgerTxtb = new System.Windows.Forms.TextBox();
            this.cocacolaTxtb = new System.Windows.Forms.TextBox();
            this.frenchfTxtb = new System.Windows.Forms.TextBox();
            this.hotdogTxtb = new System.Windows.Forms.TextBox();
            this.frenchfPriceLbl = new System.Windows.Forms.Label();
            this.cocacolaPriceLbl = new System.Windows.Forms.Label();
            this.hotdogPriceLbl = new System.Windows.Forms.Label();
            this.miniMarketPriceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.payBtn = new System.Windows.Forms.Button();
            this.finalPaymentLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.marketGb.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // petrolCmbx
            // 
            this.petrolCmbx.FormattingEnabled = true;
            this.petrolCmbx.Location = new System.Drawing.Point(137, 26);
            this.petrolCmbx.Name = "petrolCmbx";
            this.petrolCmbx.Size = new System.Drawing.Size(154, 24);
            this.petrolCmbx.TabIndex = 0;
            this.petrolCmbx.SelectedIndexChanged += new System.EventHandler(this.petrolCmbx_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.byPriceTxtb);
            this.panel1.Controls.Add(this.petrolPaymentlbl);
            this.panel1.Controls.Add(this.byPriceRadio);
            this.panel1.Controls.Add(this.byLiterRadio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.byLiterTxtb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.petrolPriceLbl);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.petrolCmbx);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 435);
            this.panel1.TabIndex = 1;
            // 
            // byPriceTxtb
            // 
            this.byPriceTxtb.Enabled = false;
            this.byPriceTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPriceTxtb.Location = new System.Drawing.Point(183, 214);
            this.byPriceTxtb.Name = "byPriceTxtb";
            this.byPriceTxtb.Size = new System.Drawing.Size(76, 27);
            this.byPriceTxtb.TabIndex = 13;
            this.byPriceTxtb.TextChanged += new System.EventHandler(this.byPetrolTxtb_TextChanged);
            // 
            // petrolPaymentlbl
            // 
            this.petrolPaymentlbl.AutoSize = true;
            this.petrolPaymentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolPaymentlbl.Location = new System.Drawing.Point(174, 348);
            this.petrolPaymentlbl.Name = "petrolPaymentlbl";
            this.petrolPaymentlbl.Size = new System.Drawing.Size(145, 54);
            this.petrolPaymentlbl.TabIndex = 12;
            this.petrolPaymentlbl.Text = "00.00";
            // 
            // byPriceRadio
            // 
            this.byPriceRadio.AutoSize = true;
            this.byPriceRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byPriceRadio.Location = new System.Drawing.Point(43, 217);
            this.byPriceRadio.Name = "byPriceRadio";
            this.byPriceRadio.Size = new System.Drawing.Size(102, 24);
            this.byPriceRadio.TabIndex = 11;
            this.byPriceRadio.TabStop = true;
            this.byPriceRadio.Text = "By Price";
            this.byPriceRadio.UseVisualStyleBackColor = true;
            this.byPriceRadio.CheckedChanged += new System.EventHandler(this.byPriceRadio_CheckedChanged);
            // 
            // byLiterRadio
            // 
            this.byLiterRadio.AutoSize = true;
            this.byLiterRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLiterRadio.Location = new System.Drawing.Point(43, 165);
            this.byLiterRadio.Name = "byLiterRadio";
            this.byLiterRadio.Size = new System.Drawing.Size(97, 24);
            this.byLiterRadio.TabIndex = 10;
            this.byLiterRadio.TabStop = true;
            this.byLiterRadio.Text = "By Liter";
            this.byLiterRadio.UseVisualStyleBackColor = true;
            this.byLiterRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Payment";
            // 
            // byLiterTxtb
            // 
            this.byLiterTxtb.Enabled = false;
            this.byLiterTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLiterTxtb.Location = new System.Drawing.Point(183, 162);
            this.byLiterTxtb.Name = "byLiterTxtb";
            this.byLiterTxtb.Size = new System.Drawing.Size(76, 27);
            this.byLiterTxtb.TabIndex = 8;
            this.byLiterTxtb.TextChanged += new System.EventHandler(this.byPriceTxtb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "azn";
            // 
            // petrolPriceLbl
            // 
            this.petrolPriceLbl.AutoSize = true;
            this.petrolPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolPriceLbl.Location = new System.Drawing.Point(132, 102);
            this.petrolPriceLbl.Name = "petrolPriceLbl";
            this.petrolPriceLbl.Size = new System.Drawing.Size(66, 25);
            this.petrolPriceLbl.TabIndex = 5;
            this.petrolPriceLbl.Text = "00,00";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(38, 102);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(61, 25);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Petrol";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.marketGb);
            this.panel2.Controls.Add(this.miniMarketPriceLbl);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(424, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 435);
            this.panel2.TabIndex = 2;
            this.panel2.Enter += new System.EventHandler(this.o);
            // 
            // marketGb
            // 
            this.marketGb.Controls.Add(this.hamburgerChkb);
            this.marketGb.Controls.Add(this.sirabPriceLbl);
            this.marketGb.Controls.Add(this.sirabChkb);
            this.marketGb.Controls.Add(this.hotdogChkb);
            this.marketGb.Controls.Add(this.cocacolaChkb);
            this.marketGb.Controls.Add(this.sirabTxtb);
            this.marketGb.Controls.Add(this.frenchfChkb);
            this.marketGb.Controls.Add(this.hamburgerPriceLbl);
            this.marketGb.Controls.Add(this.hamburgerTxtb);
            this.marketGb.Controls.Add(this.cocacolaTxtb);
            this.marketGb.Controls.Add(this.frenchfTxtb);
            this.marketGb.Controls.Add(this.hotdogTxtb);
            this.marketGb.Controls.Add(this.frenchfPriceLbl);
            this.marketGb.Controls.Add(this.cocacolaPriceLbl);
            this.marketGb.Controls.Add(this.hotdogPriceLbl);
            this.marketGb.Location = new System.Drawing.Point(6, 3);
            this.marketGb.Name = "marketGb";
            this.marketGb.Size = new System.Drawing.Size(358, 252);
            this.marketGb.TabIndex = 28;
            this.marketGb.TabStop = false;
            this.marketGb.Text = "Mini Market";
            // 
            // hamburgerChkb
            // 
            this.hamburgerChkb.AutoSize = true;
            this.hamburgerChkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerChkb.Location = new System.Drawing.Point(6, 26);
            this.hamburgerChkb.Name = "hamburgerChkb";
            this.hamburgerChkb.Size = new System.Drawing.Size(140, 29);
            this.hamburgerChkb.TabIndex = 15;
            this.hamburgerChkb.Text = "Hamburger";
            this.hamburgerChkb.UseVisualStyleBackColor = true;
            // 
            // sirabPriceLbl
            // 
            this.sirabPriceLbl.AutoSize = true;
            this.sirabPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sirabPriceLbl.Location = new System.Drawing.Point(213, 206);
            this.sirabPriceLbl.Name = "sirabPriceLbl";
            this.sirabPriceLbl.Size = new System.Drawing.Size(42, 25);
            this.sirabPriceLbl.TabIndex = 25;
            this.sirabPriceLbl.Text = "1.0";
            // 
            // sirabChkb
            // 
            this.sirabChkb.AutoSize = true;
            this.sirabChkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sirabChkb.Location = new System.Drawing.Point(6, 206);
            this.sirabChkb.Name = "sirabChkb";
            this.sirabChkb.Size = new System.Drawing.Size(85, 29);
            this.sirabChkb.TabIndex = 27;
            this.sirabChkb.Text = "Sirab";
            this.sirabChkb.UseVisualStyleBackColor = true;
            // 
            // hotdogChkb
            // 
            this.hotdogChkb.AutoSize = true;
            this.hotdogChkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogChkb.Location = new System.Drawing.Point(6, 74);
            this.hotdogChkb.Name = "hotdogChkb";
            this.hotdogChkb.Size = new System.Drawing.Size(109, 29);
            this.hotdogChkb.TabIndex = 18;
            this.hotdogChkb.Text = "Hot dog";
            this.hotdogChkb.UseVisualStyleBackColor = true;
            // 
            // cocacolaChkb
            // 
            this.cocacolaChkb.AutoSize = true;
            this.cocacolaChkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocacolaChkb.Location = new System.Drawing.Point(6, 158);
            this.cocacolaChkb.Name = "cocacolaChkb";
            this.cocacolaChkb.Size = new System.Drawing.Size(136, 29);
            this.cocacolaChkb.TabIndex = 24;
            this.cocacolaChkb.Text = "Coca Cola";
            this.cocacolaChkb.UseVisualStyleBackColor = true;
            // 
            // sirabTxtb
            // 
            this.sirabTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sirabTxtb.Location = new System.Drawing.Point(261, 206);
            this.sirabTxtb.Name = "sirabTxtb";
            this.sirabTxtb.Size = new System.Drawing.Size(76, 27);
            this.sirabTxtb.TabIndex = 26;
            this.sirabTxtb.TextChanged += new System.EventHandler(this.sirabTxtb_TextChanged);
            // 
            // frenchfChkb
            // 
            this.frenchfChkb.AutoSize = true;
            this.frenchfChkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchfChkb.Location = new System.Drawing.Point(6, 118);
            this.frenchfChkb.Name = "frenchfChkb";
            this.frenchfChkb.Size = new System.Drawing.Size(148, 29);
            this.frenchfChkb.TabIndex = 21;
            this.frenchfChkb.Text = "French fries";
            this.frenchfChkb.UseVisualStyleBackColor = true;
            // 
            // hamburgerPriceLbl
            // 
            this.hamburgerPriceLbl.AutoSize = true;
            this.hamburgerPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerPriceLbl.Location = new System.Drawing.Point(201, 26);
            this.hamburgerPriceLbl.Name = "hamburgerPriceLbl";
            this.hamburgerPriceLbl.Size = new System.Drawing.Size(54, 25);
            this.hamburgerPriceLbl.TabIndex = 14;
            this.hamburgerPriceLbl.Text = "5.90";
            // 
            // hamburgerTxtb
            // 
            this.hamburgerTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerTxtb.Location = new System.Drawing.Point(261, 26);
            this.hamburgerTxtb.Name = "hamburgerTxtb";
            this.hamburgerTxtb.Size = new System.Drawing.Size(76, 27);
            this.hamburgerTxtb.TabIndex = 14;
            this.hamburgerTxtb.TextChanged += new System.EventHandler(this.hamburgerTxtb_TextChanged);
            // 
            // cocacolaTxtb
            // 
            this.cocacolaTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocacolaTxtb.Location = new System.Drawing.Point(261, 159);
            this.cocacolaTxtb.Name = "cocacolaTxtb";
            this.cocacolaTxtb.Size = new System.Drawing.Size(76, 27);
            this.cocacolaTxtb.TabIndex = 23;
            this.cocacolaTxtb.TextChanged += new System.EventHandler(this.cocacolaTxtb_TextChanged);
            // 
            // frenchfTxtb
            // 
            this.frenchfTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchfTxtb.Location = new System.Drawing.Point(261, 118);
            this.frenchfTxtb.Name = "frenchfTxtb";
            this.frenchfTxtb.Size = new System.Drawing.Size(76, 27);
            this.frenchfTxtb.TabIndex = 20;
            this.frenchfTxtb.TextChanged += new System.EventHandler(this.frenchfTxtb_TextChanged);
            // 
            // hotdogTxtb
            // 
            this.hotdogTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogTxtb.Location = new System.Drawing.Point(261, 74);
            this.hotdogTxtb.Name = "hotdogTxtb";
            this.hotdogTxtb.Size = new System.Drawing.Size(76, 27);
            this.hotdogTxtb.TabIndex = 17;
            this.hotdogTxtb.TextChanged += new System.EventHandler(this.hotdogTxtb_TextChanged);
            // 
            // frenchfPriceLbl
            // 
            this.frenchfPriceLbl.AutoSize = true;
            this.frenchfPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchfPriceLbl.Location = new System.Drawing.Point(213, 117);
            this.frenchfPriceLbl.Name = "frenchfPriceLbl";
            this.frenchfPriceLbl.Size = new System.Drawing.Size(42, 25);
            this.frenchfPriceLbl.TabIndex = 19;
            this.frenchfPriceLbl.Text = "2.0";
            // 
            // cocacolaPriceLbl
            // 
            this.cocacolaPriceLbl.AutoSize = true;
            this.cocacolaPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocacolaPriceLbl.Location = new System.Drawing.Point(201, 158);
            this.cocacolaPriceLbl.Name = "cocacolaPriceLbl";
            this.cocacolaPriceLbl.Size = new System.Drawing.Size(54, 25);
            this.cocacolaPriceLbl.TabIndex = 22;
            this.cocacolaPriceLbl.Text = "1.50";
            // 
            // hotdogPriceLbl
            // 
            this.hotdogPriceLbl.AutoSize = true;
            this.hotdogPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogPriceLbl.Location = new System.Drawing.Point(201, 76);
            this.hotdogPriceLbl.Name = "hotdogPriceLbl";
            this.hotdogPriceLbl.Size = new System.Drawing.Size(54, 25);
            this.hotdogPriceLbl.TabIndex = 16;
            this.hotdogPriceLbl.Text = "2.90";
            // 
            // miniMarketPriceLbl
            // 
            this.miniMarketPriceLbl.AutoSize = true;
            this.miniMarketPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniMarketPriceLbl.Location = new System.Drawing.Point(183, 348);
            this.miniMarketPriceLbl.Name = "miniMarketPriceLbl";
            this.miniMarketPriceLbl.Size = new System.Drawing.Size(145, 54);
            this.miniMarketPriceLbl.TabIndex = 14;
            this.miniMarketPriceLbl.Text = "00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Payment";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.payBtn);
            this.panel3.Controls.Add(this.finalPaymentLbl);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 115);
            this.panel3.TabIndex = 2;
            // 
            // payBtn
            // 
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.Location = new System.Drawing.Point(506, 49);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(173, 54);
            this.payBtn.TabIndex = 29;
            this.payBtn.Text = "PAY";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // finalPaymentLbl
            // 
            this.finalPaymentLbl.AutoSize = true;
            this.finalPaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPaymentLbl.Location = new System.Drawing.Point(174, 49);
            this.finalPaymentLbl.Name = "finalPaymentLbl";
            this.finalPaymentLbl.Size = new System.Drawing.Size(145, 54);
            this.finalPaymentLbl.TabIndex = 28;
            this.finalPaymentLbl.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.marketGb.ResumeLayout(false);
            this.marketGb.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox petrolCmbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label petrolPriceLbl;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox byLiterTxtb;
        private System.Windows.Forms.RadioButton byPriceRadio;
        private System.Windows.Forms.RadioButton byLiterRadio;
        private System.Windows.Forms.Label petrolPaymentlbl;
        private System.Windows.Forms.Label miniMarketPriceLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox byPriceTxtb;
        private System.Windows.Forms.Label sirabPriceLbl;
        private System.Windows.Forms.TextBox sirabTxtb;
        private System.Windows.Forms.Label cocacolaPriceLbl;
        private System.Windows.Forms.TextBox cocacolaTxtb;
        private System.Windows.Forms.Label frenchfPriceLbl;
        private System.Windows.Forms.TextBox frenchfTxtb;
        private System.Windows.Forms.Label hotdogPriceLbl;
        private System.Windows.Forms.TextBox hotdogTxtb;
        private System.Windows.Forms.Label hamburgerPriceLbl;
        private System.Windows.Forms.TextBox hamburgerTxtb;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label finalPaymentLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox marketGb;
        private System.Windows.Forms.CheckBox hamburgerChkb;
        private System.Windows.Forms.CheckBox sirabChkb;
        private System.Windows.Forms.CheckBox hotdogChkb;
        private System.Windows.Forms.CheckBox cocacolaChkb;
        private System.Windows.Forms.CheckBox frenchfChkb;
    }
}

