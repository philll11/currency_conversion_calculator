namespace currencyConversionCalculator
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.convertBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.USDT = new System.Windows.Forms.Button();
            this.CADT = new System.Windows.Forms.Button();
            this.AUDT = new System.Windows.Forms.Button();
            this.GBPT = new System.Windows.Forms.Button();
            this.EURT = new System.Windows.Forms.Button();
            this.NZDT = new System.Windows.Forms.Button();
            this.USDF = new System.Windows.Forms.Button();
            this.CADF = new System.Windows.Forms.Button();
            this.AUDF = new System.Windows.Forms.Button();
            this.GBPF = new System.Windows.Forms.Button();
            this.EURF = new System.Windows.Forms.Button();
            this.NZDF = new System.Windows.Forms.Button();
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(370, 261);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 62;
            this.amountTextBox.Text = "0.00";
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(321, 391);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(149, 23);
            this.resetBtn.TabIndex = 61;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(321, 364);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 60;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(187, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 31);
            this.label3.TabIndex = 56;
            this.label3.Text = "Currency Conversion Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "CONVERT TO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "CONVERT FROM:";
            // 
            // USDT
            // 
            this.USDT.Location = new System.Drawing.Point(573, 210);
            this.USDT.Name = "USDT";
            this.USDT.Size = new System.Drawing.Size(75, 23);
            this.USDT.TabIndex = 53;
            this.USDT.Text = "USD";
            this.USDT.UseVisualStyleBackColor = true;
            this.USDT.Click += new System.EventHandler(this.USDT_Click);
            // 
            // CADT
            // 
            this.CADT.Location = new System.Drawing.Point(573, 181);
            this.CADT.Name = "CADT";
            this.CADT.Size = new System.Drawing.Size(75, 23);
            this.CADT.TabIndex = 52;
            this.CADT.Text = "CAD";
            this.CADT.UseVisualStyleBackColor = true;
            this.CADT.Click += new System.EventHandler(this.CADT_Click);
            // 
            // AUDT
            // 
            this.AUDT.Location = new System.Drawing.Point(573, 152);
            this.AUDT.Name = "AUDT";
            this.AUDT.Size = new System.Drawing.Size(75, 23);
            this.AUDT.TabIndex = 51;
            this.AUDT.Text = "AUD";
            this.AUDT.UseVisualStyleBackColor = true;
            this.AUDT.Click += new System.EventHandler(this.AUDT_Click);
            // 
            // GBPT
            // 
            this.GBPT.Location = new System.Drawing.Point(492, 210);
            this.GBPT.Name = "GBPT";
            this.GBPT.Size = new System.Drawing.Size(75, 23);
            this.GBPT.TabIndex = 50;
            this.GBPT.Text = "GBP";
            this.GBPT.UseVisualStyleBackColor = true;
            this.GBPT.Click += new System.EventHandler(this.GBPT_Click);
            // 
            // EURT
            // 
            this.EURT.Location = new System.Drawing.Point(492, 181);
            this.EURT.Name = "EURT";
            this.EURT.Size = new System.Drawing.Size(75, 23);
            this.EURT.TabIndex = 49;
            this.EURT.Text = "EUR";
            this.EURT.UseVisualStyleBackColor = true;
            this.EURT.Click += new System.EventHandler(this.EURT_Click);
            // 
            // NZDT
            // 
            this.NZDT.Location = new System.Drawing.Point(492, 152);
            this.NZDT.Name = "NZDT";
            this.NZDT.Size = new System.Drawing.Size(75, 23);
            this.NZDT.TabIndex = 48;
            this.NZDT.Text = "NZD";
            this.NZDT.UseVisualStyleBackColor = true;
            this.NZDT.Click += new System.EventHandler(this.NZDT_Click);
            // 
            // USDF
            // 
            this.USDF.Location = new System.Drawing.Point(217, 210);
            this.USDF.Name = "USDF";
            this.USDF.Size = new System.Drawing.Size(75, 23);
            this.USDF.TabIndex = 0;
            this.USDF.Text = "USD";
            this.USDF.UseVisualStyleBackColor = true;
            this.USDF.Click += new System.EventHandler(this.USDF_Click);
            // 
            // CADF
            // 
            this.CADF.Location = new System.Drawing.Point(217, 181);
            this.CADF.Name = "CADF";
            this.CADF.Size = new System.Drawing.Size(75, 23);
            this.CADF.TabIndex = 0;
            this.CADF.Text = "CAD";
            this.CADF.UseVisualStyleBackColor = true;
            this.CADF.Click += new System.EventHandler(this.CADF_Click);
            // 
            // AUDF
            // 
            this.AUDF.Location = new System.Drawing.Point(217, 152);
            this.AUDF.Name = "AUDF";
            this.AUDF.Size = new System.Drawing.Size(75, 23);
            this.AUDF.TabIndex = 0;
            this.AUDF.Text = "AUD";
            this.AUDF.UseVisualStyleBackColor = true;
            this.AUDF.Click += new System.EventHandler(this.AUDF_Click);
            // 
            // GBPF
            // 
            this.GBPF.Location = new System.Drawing.Point(136, 210);
            this.GBPF.Name = "GBPF";
            this.GBPF.Size = new System.Drawing.Size(75, 23);
            this.GBPF.TabIndex = 0;
            this.GBPF.Text = "GBP";
            this.GBPF.UseVisualStyleBackColor = true;
            this.GBPF.Click += new System.EventHandler(this.GBPF_Click);
            // 
            // EURF
            // 
            this.EURF.Location = new System.Drawing.Point(136, 181);
            this.EURF.Name = "EURF";
            this.EURF.Size = new System.Drawing.Size(75, 23);
            this.EURF.TabIndex = 0;
            this.EURF.Text = "EUR";
            this.EURF.UseVisualStyleBackColor = true;
            this.EURF.Click += new System.EventHandler(this.EURF_Click);
            // 
            // NZDF
            // 
            this.NZDF.Location = new System.Drawing.Point(136, 152);
            this.NZDF.Name = "NZDF";
            this.NZDF.Size = new System.Drawing.Size(75, 23);
            this.NZDF.TabIndex = 0;
            this.NZDF.Text = "NZD";
            this.NZDF.UseVisualStyleBackColor = true;
            this.NZDF.Click += new System.EventHandler(this.NZDF_Click);
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(402, 297);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(34, 13);
            this.fromLbl.TabIndex = 63;
            this.fromLbl.Text = "$0.00";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(402, 327);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(34, 13);
            this.toLbl.TabIndex = 64;
            this.toLbl.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USDT);
            this.Controls.Add(this.CADT);
            this.Controls.Add(this.AUDT);
            this.Controls.Add(this.GBPT);
            this.Controls.Add(this.EURT);
            this.Controls.Add(this.NZDT);
            this.Controls.Add(this.USDF);
            this.Controls.Add(this.CADF);
            this.Controls.Add(this.AUDF);
            this.Controls.Add(this.GBPF);
            this.Controls.Add(this.EURF);
            this.Controls.Add(this.NZDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button USDT;
        private System.Windows.Forms.Button CADT;
        private System.Windows.Forms.Button AUDT;
        private System.Windows.Forms.Button GBPT;
        private System.Windows.Forms.Button EURT;
        private System.Windows.Forms.Button NZDT;
        private System.Windows.Forms.Button USDF;
        private System.Windows.Forms.Button CADF;
        private System.Windows.Forms.Button AUDF;
        private System.Windows.Forms.Button GBPF;
        private System.Windows.Forms.Button EURF;
        private System.Windows.Forms.Button NZDF;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label toLbl;
    }
}

