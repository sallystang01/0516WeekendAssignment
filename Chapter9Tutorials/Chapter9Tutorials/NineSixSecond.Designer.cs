namespace Chapter9Tutorials
{
    partial class NineSixSecond
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
            this.tbFood = new System.Windows.Forms.TextBox();
            this.tbFat = new System.Windows.Forms.TextBox();
            this.tbCal = new System.Windows.Forms.TextBox();
            this.tbCarbs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFood
            // 
            this.tbFood.Enabled = false;
            this.tbFood.Location = new System.Drawing.Point(120, 41);
            this.tbFood.Name = "tbFood";
            this.tbFood.ReadOnly = true;
            this.tbFood.Size = new System.Drawing.Size(132, 20);
            this.tbFood.TabIndex = 0;
            // 
            // tbFat
            // 
            this.tbFat.Enabled = false;
            this.tbFat.Location = new System.Drawing.Point(120, 93);
            this.tbFat.Name = "tbFat";
            this.tbFat.ReadOnly = true;
            this.tbFat.Size = new System.Drawing.Size(132, 20);
            this.tbFat.TabIndex = 1;
            // 
            // tbCal
            // 
            this.tbCal.Enabled = false;
            this.tbCal.Location = new System.Drawing.Point(120, 67);
            this.tbCal.Name = "tbCal";
            this.tbCal.ReadOnly = true;
            this.tbCal.Size = new System.Drawing.Size(132, 20);
            this.tbCal.TabIndex = 2;
            // 
            // tbCarbs
            // 
            this.tbCarbs.Enabled = false;
            this.tbCarbs.Location = new System.Drawing.Point(120, 119);
            this.tbCarbs.Name = "tbCarbs";
            this.tbCarbs.ReadOnly = true;
            this.tbCarbs.Size = new System.Drawing.Size(132, 20);
            this.tbCarbs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fat Grams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carb Grams";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(107, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NineSixSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 202);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCarbs);
            this.Controls.Add(this.tbCal);
            this.Controls.Add(this.tbFat);
            this.Controls.Add(this.tbFood);
            this.Name = "NineSixSecond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NineSixSecond";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox tbFood;
        public System.Windows.Forms.TextBox tbFat;
        public System.Windows.Forms.TextBox tbCal;
        public System.Windows.Forms.TextBox tbCarbs;
    }
}