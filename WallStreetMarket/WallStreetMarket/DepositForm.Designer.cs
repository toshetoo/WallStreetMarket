namespace WallStreetMarket
{
    partial class DepositForm
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
            this.btnPayGet = new System.Windows.Forms.Button();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayGet
            // 
            this.btnPayGet.Location = new System.Drawing.Point(82, 81);
            this.btnPayGet.Name = "btnPayGet";
            this.btnPayGet.Size = new System.Drawing.Size(75, 23);
            this.btnPayGet.TabIndex = 5;
            this.btnPayGet.Text = "button1";
            this.btnPayGet.UseVisualStyleBackColor = true;
            this.btnPayGet.Click += new System.EventHandler(this.btnPayGet_Click);
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(23, 47);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(199, 20);
            this.tbDeposit.TabIndex = 4;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(103, 20);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "label1";
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 127);
            this.Controls.Add(this.btnPayGet);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.lblText);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayGet;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.Label lblText;
    }
}