namespace Chapter9Tutorials
{
    partial class NineOne
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
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnToss = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(66, 58);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(120, 95);
            this.lbOutput.TabIndex = 2;
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(46, 194);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 40);
            this.btnToss.TabIndex = 3;
            this.btnToss.Text = "Toss Five Times";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NineOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToss);
            this.Controls.Add(this.lbOutput);
            this.Name = "NineOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NineOne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NineOne_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Button btnExit;
    }
}