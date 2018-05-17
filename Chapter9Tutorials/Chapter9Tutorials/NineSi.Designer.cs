namespace Chapter9Tutorials
{
    partial class NineSix
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
            this.gbFood = new System.Windows.Forms.GroupBox();
            this.rbMuffin = new System.Windows.Forms.RadioButton();
            this.rbPop = new System.Windows.Forms.RadioButton();
            this.rbBan = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFood
            // 
            this.gbFood.Controls.Add(this.rbMuffin);
            this.gbFood.Controls.Add(this.rbPop);
            this.gbFood.Controls.Add(this.rbBan);
            this.gbFood.Location = new System.Drawing.Point(12, 22);
            this.gbFood.Name = "gbFood";
            this.gbFood.Size = new System.Drawing.Size(263, 185);
            this.gbFood.TabIndex = 0;
            this.gbFood.TabStop = false;
            this.gbFood.Text = "Select a Food";
            // 
            // rbMuffin
            // 
            this.rbMuffin.AutoSize = true;
            this.rbMuffin.Location = new System.Drawing.Point(59, 125);
            this.rbMuffin.Name = "rbMuffin";
            this.rbMuffin.Size = new System.Drawing.Size(134, 17);
            this.rbMuffin.TabIndex = 2;
            this.rbMuffin.TabStop = true;
            this.rbMuffin.Text = "1 large blueberry muffin";
            this.rbMuffin.UseVisualStyleBackColor = true;
            // 
            // rbPop
            // 
            this.rbPop.AutoSize = true;
            this.rbPop.Location = new System.Drawing.Point(59, 81);
            this.rbPop.Name = "rbPop";
            this.rbPop.Size = new System.Drawing.Size(159, 17);
            this.rbPop.TabIndex = 1;
            this.rbPop.TabStop = true;
            this.rbPop.Text = "1 cup of air-popped popcorn";
            this.rbPop.UseVisualStyleBackColor = true;
            // 
            // rbBan
            // 
            this.rbBan.AutoSize = true;
            this.rbBan.Location = new System.Drawing.Point(59, 41);
            this.rbBan.Name = "rbBan";
            this.rbBan.Size = new System.Drawing.Size(70, 17);
            this.rbBan.TabIndex = 0;
            this.rbBan.TabStop = true;
            this.rbBan.Text = "1 banana";
            this.rbBan.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(68, 226);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 38);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Food Facts";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // NineSix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.gbFood);
            this.Name = "NineSix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NineSix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NineSix_FormClosing);
            this.gbFood.ResumeLayout(false);
            this.gbFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFood;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbMuffin;
        private System.Windows.Forms.RadioButton rbPop;
        private System.Windows.Forms.RadioButton rbBan;
    }
}