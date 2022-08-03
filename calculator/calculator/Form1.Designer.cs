namespace calculator
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
            this.sumLbl = new System.Windows.Forms.Label();
            this.plusBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumLbl
            // 
            this.sumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLbl.Location = new System.Drawing.Point(3, 2);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(370, 73);
            this.sumLbl.TabIndex = 0;
            this.sumLbl.Text = "0";
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(271, 96);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(87, 38);
            this.plusBtn.TabIndex = 1;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multBtn.Location = new System.Drawing.Point(271, 217);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(87, 38);
            this.multBtn.TabIndex = 2;
            this.multBtn.Text = "*";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(271, 336);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(87, 50);
            this.equalBtn.TabIndex = 4;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(271, 151);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(87, 38);
            this.minusBtn.TabIndex = 3;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(271, 279);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(87, 38);
            this.divBtn.TabIndex = 5;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(96, 279);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(60, 38);
            this.zeroBtn.TabIndex = 9;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Location = new System.Drawing.Point(96, 151);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(60, 38);
            this.fiveBtn.TabIndex = 8;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Location = new System.Drawing.Point(96, 217);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(60, 38);
            this.twoBtn.TabIndex = 7;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Location = new System.Drawing.Point(96, 96);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(60, 38);
            this.eightBtn.TabIndex = 6;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Location = new System.Drawing.Point(186, 151);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(60, 38);
            this.sixBtn.TabIndex = 12;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Location = new System.Drawing.Point(186, 217);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(60, 38);
            this.threeBtn.TabIndex = 11;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Location = new System.Drawing.Point(186, 96);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(60, 38);
            this.nineBtn.TabIndex = 10;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Location = new System.Drawing.Point(15, 151);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(60, 38);
            this.fourBtn.TabIndex = 16;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Location = new System.Drawing.Point(15, 217);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(60, 38);
            this.oneBtn.TabIndex = 15;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Location = new System.Drawing.Point(15, 96);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(60, 38);
            this.sevenBtn.TabIndex = 14;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.ForeColor = System.Drawing.SystemColors.Control;
            this.result.Location = new System.Drawing.Point(12, 373);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(44, 16);
            this.result.TabIndex = 17;
            this.result.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 398);
            this.Controls.Add(this.result);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.sumLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Label result;
    }
}

