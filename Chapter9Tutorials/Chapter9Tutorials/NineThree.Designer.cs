namespace Chapter9Tutorials
{
    partial class NineThree
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
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gbDeposit = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.gbWithdrawal = new System.Windows.Forms.GroupBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.lblWithdrawal = new System.Windows.Forms.Label();
            this.tbWithdrawal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbDeposit.SuspendLayout();
            this.gbWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBalance
            // 
            this.tbBalance.Enabled = false;
            this.tbBalance.Location = new System.Drawing.Point(227, 50);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(100, 20);
            this.tbBalance.TabIndex = 0;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(172, 53);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance:";
            // 
            // gbDeposit
            // 
            this.gbDeposit.Controls.Add(this.btnDeposit);
            this.gbDeposit.Controls.Add(this.lblDeposit);
            this.gbDeposit.Controls.Add(this.tbDeposit);
            this.gbDeposit.Location = new System.Drawing.Point(39, 100);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(200, 100);
            this.gbDeposit.TabIndex = 2;
            this.gbDeposit.TabStop = false;
            this.gbDeposit.Text = "Make a Deposit";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(41, 63);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(38, 33);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(46, 13);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Deposit:";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(90, 30);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(100, 20);
            this.tbDeposit.TabIndex = 3;
            // 
            // gbWithdrawal
            // 
            this.gbWithdrawal.Controls.Add(this.btnWithdrawal);
            this.gbWithdrawal.Controls.Add(this.lblWithdrawal);
            this.gbWithdrawal.Controls.Add(this.tbWithdrawal);
            this.gbWithdrawal.Location = new System.Drawing.Point(245, 100);
            this.gbWithdrawal.Name = "gbWithdrawal";
            this.gbWithdrawal.Size = new System.Drawing.Size(200, 100);
            this.gbWithdrawal.TabIndex = 6;
            this.gbWithdrawal.TabStop = false;
            this.gbWithdrawal.Text = "Make a Withdrawal";
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(41, 63);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawal.TabIndex = 5;
            this.btnWithdrawal.Text = "Withdraw";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // lblWithdrawal
            // 
            this.lblWithdrawal.AutoSize = true;
            this.lblWithdrawal.Location = new System.Drawing.Point(29, 33);
            this.lblWithdrawal.Name = "lblWithdrawal";
            this.lblWithdrawal.Size = new System.Drawing.Size(55, 13);
            this.lblWithdrawal.TabIndex = 4;
            this.lblWithdrawal.Text = "Withdraw:";
            // 
            // tbWithdrawal
            // 
            this.tbWithdrawal.Location = new System.Drawing.Point(90, 30);
            this.tbWithdrawal.Name = "tbWithdrawal";
            this.tbWithdrawal.Size = new System.Drawing.Size(100, 20);
            this.tbWithdrawal.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NineThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 264);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbWithdrawal);
            this.Controls.Add(this.gbDeposit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbBalance);
            this.Name = "NineThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NineThree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NineThree_FormClosing);
            this.Load += new System.EventHandler(this.NineThree_Load);
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            this.gbWithdrawal.ResumeLayout(false);
            this.gbWithdrawal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox gbDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.GroupBox gbWithdrawal;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblWithdrawal;
        private System.Windows.Forms.TextBox tbWithdrawal;
        private System.Windows.Forms.Button btnExit;
    }
}