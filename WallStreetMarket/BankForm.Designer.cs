namespace WallStreetMarket
{
    partial class BankForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPayLoan = new System.Windows.Forms.Button();
            this.btnGetLoan = new System.Windows.Forms.Button();
            this.lblLoanInterest = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnGetDeposit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSellLEv = new System.Windows.Forms.Label();
            this.lblSellDollar = new System.Windows.Forms.Label();
            this.lblSellEuro = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.lblBuyLev = new System.Windows.Forms.Label();
            this.lblBuyDollar = new System.Windows.Forms.Label();
            this.lblBuyEuro = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLev = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPayLoan);
            this.groupBox1.Controls.Add(this.btnGetLoan);
            this.groupBox1.Controls.Add(this.lblLoanInterest);
            this.groupBox1.Controls.Add(this.lblLoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan";
            // 
            // btnPayLoan
            // 
            this.btnPayLoan.Location = new System.Drawing.Point(123, 92);
            this.btnPayLoan.Name = "btnPayLoan";
            this.btnPayLoan.Size = new System.Drawing.Size(71, 23);
            this.btnPayLoan.TabIndex = 5;
            this.btnPayLoan.Text = "Pay Loan";
            this.btnPayLoan.UseVisualStyleBackColor = true;
            this.btnPayLoan.Click += new System.EventHandler(this.btnPayLoan_Click);
            // 
            // btnGetLoan
            // 
            this.btnGetLoan.Location = new System.Drawing.Point(6, 92);
            this.btnGetLoan.Name = "btnGetLoan";
            this.btnGetLoan.Size = new System.Drawing.Size(76, 23);
            this.btnGetLoan.TabIndex = 4;
            this.btnGetLoan.Text = "Get Loan";
            this.btnGetLoan.UseVisualStyleBackColor = true;
            this.btnGetLoan.Click += new System.EventHandler(this.btnGetLoan_Click);
            // 
            // lblLoanInterest
            // 
            this.lblLoanInterest.AutoSize = true;
            this.lblLoanInterest.Location = new System.Drawing.Point(47, 54);
            this.lblLoanInterest.Name = "lblLoanInterest";
            this.lblLoanInterest.Size = new System.Drawing.Size(27, 13);
            this.lblLoanInterest.TabIndex = 3;
            this.lblLoanInterest.Text = "10%";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(47, 29);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(35, 13);
            this.lblLoan.TabIndex = 2;
            this.lblLoan.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWithdraw);
            this.groupBox2.Controls.Add(this.lblDeposit);
            this.groupBox2.Controls.Add(this.btnGetDeposit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblInterest);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(245, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(129, 92);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(71, 23);
            this.btnWithdraw.TabIndex = 11;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(49, 29);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(35, 13);
            this.lblDeposit.TabIndex = 8;
            this.lblDeposit.Text = "label6";
            // 
            // btnGetDeposit
            // 
            this.btnGetDeposit.Location = new System.Drawing.Point(8, 92);
            this.btnGetDeposit.Name = "btnGetDeposit";
            this.btnGetDeposit.Size = new System.Drawing.Size(76, 23);
            this.btnGetDeposit.TabIndex = 10;
            this.btnGetDeposit.Text = "Deposit";
            this.btnGetDeposit.UseVisualStyleBackColor = true;
            this.btnGetDeposit.Click += new System.EventHandler(this.btnGetDeposit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Deposit:";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(49, 54);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(21, 13);
            this.lblInterest.TabIndex = 9;
            this.lblInterest.Text = "6%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Interest:";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblLev);
            this.groupBox3.Controls.Add(this.lblDollar);
            this.groupBox3.Controls.Add(this.lblEuro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trading";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lblSellLEv);
            this.groupBox4.Controls.Add(this.lblSellDollar);
            this.groupBox4.Controls.Add(this.lblSellEuro);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.btnExchange);
            this.groupBox4.Controls.Add(this.lblBuyLev);
            this.groupBox4.Controls.Add(this.lblBuyDollar);
            this.groupBox4.Controls.Add(this.lblBuyEuro);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(142, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 119);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prices";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Selling Prices";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Buying Prices";
            // 
            // lblSellLEv
            // 
            this.lblSellLEv.AutoSize = true;
            this.lblSellLEv.Location = new System.Drawing.Point(235, 93);
            this.lblSellLEv.Name = "lblSellLEv";
            this.lblSellLEv.Size = new System.Drawing.Size(17, 13);
            this.lblSellLEv.TabIndex = 19;
            this.lblSellLEv.Text = "lbl";
            // 
            // lblSellDollar
            // 
            this.lblSellDollar.AutoSize = true;
            this.lblSellDollar.Location = new System.Drawing.Point(235, 71);
            this.lblSellDollar.Name = "lblSellDollar";
            this.lblSellDollar.Size = new System.Drawing.Size(17, 13);
            this.lblSellDollar.TabIndex = 18;
            this.lblSellDollar.Text = "lbl";
            // 
            // lblSellEuro
            // 
            this.lblSellEuro.AutoSize = true;
            this.lblSellEuro.Location = new System.Drawing.Point(235, 46);
            this.lblSellEuro.Name = "lblSellEuro";
            this.lblSellEuro.Size = new System.Drawing.Size(17, 13);
            this.lblSellEuro.TabIndex = 17;
            this.lblSellEuro.Text = "lbl";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(197, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Lev:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(197, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Dollar:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(197, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Euro:";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(101, 90);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(75, 23);
            this.btnExchange.TabIndex = 13;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // lblBuyLev
            // 
            this.lblBuyLev.AutoSize = true;
            this.lblBuyLev.Location = new System.Drawing.Point(53, 93);
            this.lblBuyLev.Name = "lblBuyLev";
            this.lblBuyLev.Size = new System.Drawing.Size(17, 13);
            this.lblBuyLev.TabIndex = 12;
            this.lblBuyLev.Text = "lbl";
            // 
            // lblBuyDollar
            // 
            this.lblBuyDollar.AutoSize = true;
            this.lblBuyDollar.Location = new System.Drawing.Point(53, 71);
            this.lblBuyDollar.Name = "lblBuyDollar";
            this.lblBuyDollar.Size = new System.Drawing.Size(17, 13);
            this.lblBuyDollar.TabIndex = 11;
            this.lblBuyDollar.Text = "lbl";
            // 
            // lblBuyEuro
            // 
            this.lblBuyEuro.AutoSize = true;
            this.lblBuyEuro.Location = new System.Drawing.Point(53, 46);
            this.lblBuyEuro.Name = "lblBuyEuro";
            this.lblBuyEuro.Size = new System.Drawing.Size(17, 13);
            this.lblBuyEuro.TabIndex = 10;
            this.lblBuyEuro.Text = "lbl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Lev:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Dollar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Euro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bank";
            // 
            // lblLev
            // 
            this.lblLev.AutoSize = true;
            this.lblLev.Location = new System.Drawing.Point(48, 100);
            this.lblLev.Name = "lblLev";
            this.lblLev.Size = new System.Drawing.Size(17, 13);
            this.lblLev.TabIndex = 6;
            this.lblLev.Text = "lbl";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(48, 78);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(17, 13);
            this.lblDollar.TabIndex = 5;
            this.lblDollar.Text = "lbl";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(48, 53);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(17, 13);
            this.lblEuro.TabIndex = 4;
            this.lblEuro.Text = "lbl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lev:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dollar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Euro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your money";
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankForm_FormClosing);
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPayLoan;
        private System.Windows.Forms.Button btnGetLoan;
        private System.Windows.Forms.Label lblLoanInterest;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnGetDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSellLEv;
        private System.Windows.Forms.Label lblSellDollar;
        private System.Windows.Forms.Label lblSellEuro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label lblBuyLev;
        private System.Windows.Forms.Label lblBuyDollar;
        private System.Windows.Forms.Label lblBuyEuro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLev;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}