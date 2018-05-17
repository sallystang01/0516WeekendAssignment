namespace Chapter9Tutorials
{
    partial class Navigation
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
            this.msNav = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tutorialToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.msNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNav
            // 
            this.msNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tutorialSelectionToolStripMenuItem});
            this.msNav.Location = new System.Drawing.Point(0, 0);
            this.msNav.Name = "msNav";
            this.msNav.Size = new System.Drawing.Size(288, 24);
            this.msNav.TabIndex = 0;
            this.msNav.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tutorialSelectionToolStripMenuItem
            // 
            this.tutorialSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.tutorialToolStripMenuItem1,
            this.tutorialToolStripMenuItem2,
            this.tutorialToolStripMenuItem3,
            this.tutorialToolStripMenuItem4,
            this.tutorialToolStripMenuItem5});
            this.tutorialSelectionToolStripMenuItem.Name = "tutorialSelectionToolStripMenuItem";
            this.tutorialSelectionToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.tutorialSelectionToolStripMenuItem.Text = "Tutorial Selection";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem.Text = "9-1 Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // tutorialToolStripMenuItem1
            // 
            this.tutorialToolStripMenuItem1.Name = "tutorialToolStripMenuItem1";
            this.tutorialToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem1.Text = "9-2 Tutorial";
            this.tutorialToolStripMenuItem1.Click += new System.EventHandler(this.tutorialToolStripMenuItem1_Click);
            // 
            // tutorialToolStripMenuItem2
            // 
            this.tutorialToolStripMenuItem2.Name = "tutorialToolStripMenuItem2";
            this.tutorialToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem2.Text = "9-3 Tutorial";
            this.tutorialToolStripMenuItem2.Click += new System.EventHandler(this.tutorialToolStripMenuItem2_Click);
            // 
            // tutorialToolStripMenuItem3
            // 
            this.tutorialToolStripMenuItem3.Name = "tutorialToolStripMenuItem3";
            this.tutorialToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem3.Text = "9-4 Tutorial";
            this.tutorialToolStripMenuItem3.Click += new System.EventHandler(this.tutorialToolStripMenuItem3_Click);
            // 
            // tutorialToolStripMenuItem4
            // 
            this.tutorialToolStripMenuItem4.Name = "tutorialToolStripMenuItem4";
            this.tutorialToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem4.Text = "9-5 Tutorial";
            this.tutorialToolStripMenuItem4.Click += new System.EventHandler(this.tutorialToolStripMenuItem4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chapter 9 Tutorials";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tutorialToolStripMenuItem5
            // 
            this.tutorialToolStripMenuItem5.Name = "tutorialToolStripMenuItem5";
            this.tutorialToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem5.Text = "9-6 Tutorial";
            this.tutorialToolStripMenuItem5.Click += new System.EventHandler(this.tutorialToolStripMenuItem5_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 180);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msNav);
            this.MainMenuStrip = this.msNav;
            this.Name = "Navigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation";
            this.msNav.ResumeLayout(false);
            this.msNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNav;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem5;
    }
}

