namespace Chapter9Tutorials
{
    partial class NineTwo
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
            this.gbPhoneData = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPriceProp = new System.Windows.Forms.Label();
            this.lblModelProp = new System.Windows.Forms.Label();
            this.lblBrandProp = new System.Windows.Forms.Label();
            this.tbPriceProp = new System.Windows.Forms.TextBox();
            this.tbModelProp = new System.Windows.Forms.TextBox();
            this.tbBrandProp = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.msNav.SuspendLayout();
            this.gbPhoneData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNav
            // 
            this.msNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tutorialSelectionToolStripMenuItem});
            this.msNav.Location = new System.Drawing.Point(0, 0);
            this.msNav.Name = "msNav";
            this.msNav.Size = new System.Drawing.Size(317, 24);
            this.msNav.TabIndex = 2;
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
            // 
            // tutorialSelectionToolStripMenuItem
            // 
            this.tutorialSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem});
            this.tutorialSelectionToolStripMenuItem.Name = "tutorialSelectionToolStripMenuItem";
            this.tutorialSelectionToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.tutorialSelectionToolStripMenuItem.Text = "Tutorial Selection";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.tutorialToolStripMenuItem.Text = "9-1 Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // gbPhoneData
            // 
            this.gbPhoneData.Controls.Add(this.lblPrice);
            this.gbPhoneData.Controls.Add(this.lblModel);
            this.gbPhoneData.Controls.Add(this.lblBrand);
            this.gbPhoneData.Controls.Add(this.tbPrice);
            this.gbPhoneData.Controls.Add(this.tbModel);
            this.gbPhoneData.Controls.Add(this.tbBrand);
            this.gbPhoneData.Location = new System.Drawing.Point(55, 47);
            this.gbPhoneData.Name = "gbPhoneData";
            this.gbPhoneData.Size = new System.Drawing.Size(200, 120);
            this.gbPhoneData.TabIndex = 3;
            this.gbPhoneData.TabStop = false;
            this.gbPhoneData.Text = "Enter Cell Phone Data";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPriceProp);
            this.groupBox1.Controls.Add(this.lblModelProp);
            this.groupBox1.Controls.Add(this.lblBrandProp);
            this.groupBox1.Controls.Add(this.tbPriceProp);
            this.groupBox1.Controls.Add(this.tbModelProp);
            this.groupBox1.Controls.Add(this.tbBrandProp);
            this.groupBox1.Location = new System.Drawing.Point(55, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Properties";
            // 
            // lblPriceProp
            // 
            this.lblPriceProp.AutoSize = true;
            this.lblPriceProp.Location = new System.Drawing.Point(44, 86);
            this.lblPriceProp.Name = "lblPriceProp";
            this.lblPriceProp.Size = new System.Drawing.Size(34, 13);
            this.lblPriceProp.TabIndex = 5;
            this.lblPriceProp.Text = "Price:";
            // 
            // lblModelProp
            // 
            this.lblModelProp.AutoSize = true;
            this.lblModelProp.Location = new System.Drawing.Point(39, 60);
            this.lblModelProp.Name = "lblModelProp";
            this.lblModelProp.Size = new System.Drawing.Size(39, 13);
            this.lblModelProp.TabIndex = 4;
            this.lblModelProp.Text = "Model:";
            // 
            // lblBrandProp
            // 
            this.lblBrandProp.AutoSize = true;
            this.lblBrandProp.Location = new System.Drawing.Point(40, 34);
            this.lblBrandProp.Name = "lblBrandProp";
            this.lblBrandProp.Size = new System.Drawing.Size(38, 13);
            this.lblBrandProp.TabIndex = 3;
            this.lblBrandProp.Text = "Brand:";
            // 
            // tbPriceProp
            // 
            this.tbPriceProp.Enabled = false;
            this.tbPriceProp.Location = new System.Drawing.Point(79, 83);
            this.tbPriceProp.Name = "tbPriceProp";
            this.tbPriceProp.ReadOnly = true;
            this.tbPriceProp.Size = new System.Drawing.Size(100, 20);
            this.tbPriceProp.TabIndex = 2;
            // 
            // tbModelProp
            // 
            this.tbModelProp.Enabled = false;
            this.tbModelProp.Location = new System.Drawing.Point(79, 57);
            this.tbModelProp.Name = "tbModelProp";
            this.tbModelProp.ReadOnly = true;
            this.tbModelProp.Size = new System.Drawing.Size(100, 20);
            this.tbModelProp.TabIndex = 1;
            // 
            // tbBrandProp
            // 
            this.tbBrandProp.Enabled = false;
            this.tbBrandProp.Location = new System.Drawing.Point(79, 31);
            this.tbBrandProp.Name = "tbBrandProp";
            this.tbBrandProp.ReadOnly = true;
            this.tbBrandProp.Size = new System.Drawing.Size(100, 20);
            this.tbBrandProp.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(78, 309);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 40);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Object";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NineTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPhoneData);
            this.Controls.Add(this.msNav);
            this.Name = "NineTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NineTwo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NineTwo_FormClosing);
            this.msNav.ResumeLayout(false);
            this.msNav.PerformLayout();
            this.gbPhoneData.ResumeLayout(false);
            this.gbPhoneData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNav;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPhoneData;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPriceProp;
        private System.Windows.Forms.Label lblModelProp;
        private System.Windows.Forms.Label lblBrandProp;
        private System.Windows.Forms.TextBox tbPriceProp;
        private System.Windows.Forms.TextBox tbModelProp;
        private System.Windows.Forms.TextBox tbBrandProp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
    }
}