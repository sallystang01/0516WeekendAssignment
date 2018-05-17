namespace Chapter9Tutorials
{
    partial class NineFour
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
            this.gbPhoneData = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.lbPhone = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbPhoneData.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPhoneData
            // 
            this.gbPhoneData.Controls.Add(this.btnAdd);
            this.gbPhoneData.Controls.Add(this.lblPrice);
            this.gbPhoneData.Controls.Add(this.lblModel);
            this.gbPhoneData.Controls.Add(this.lblBrand);
            this.gbPhoneData.Controls.Add(this.tbPrice);
            this.gbPhoneData.Controls.Add(this.tbModel);
            this.gbPhoneData.Controls.Add(this.tbBrand);
            this.gbPhoneData.Location = new System.Drawing.Point(40, 44);
            this.gbPhoneData.Name = "gbPhoneData";
            this.gbPhoneData.Size = new System.Drawing.Size(200, 150);
            this.gbPhoneData.TabIndex = 4;
            this.gbPhoneData.TabStop = false;
            this.gbPhoneData.Text = "Enter Cell Phone Data";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Phone";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(44, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(39, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(40, 34);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(79, 83);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(79, 57);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(79, 31);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 20);
            this.tbBrand.TabIndex = 0;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.lbPhone);
            this.gbSelect.Location = new System.Drawing.Point(263, 44);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(200, 150);
            this.gbSelect.TabIndex = 7;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select a Phone";
            // 
            // lbPhone
            // 
            this.lbPhone.FormattingEnabled = true;
            this.lbPhone.Location = new System.Drawing.Point(6, 19);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(188, 121);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.SelectedIndexChanged += new System.EventHandler(this.lbPhone_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NineFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 252);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbPhoneData);
            this.Name = "NineFour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NineFour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NineFour_FormClosing);
            this.gbPhoneData.ResumeLayout(false);
            this.gbPhoneData.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPhoneData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.ListBox lbPhone;
        private System.Windows.Forms.Button btnExit;
    }
}