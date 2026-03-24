namespace InventoryManagementSystem
{
    partial class ModifyPartForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVariableField = new System.Windows.Forms.TextBox();
            this.txtPartMin = new System.Windows.Forms.TextBox();
            this.txtPartMax = new System.Windows.Forms.TextBox();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.txtPartInventory = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.lblVariableField = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.lblModifyPartTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(292, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVariableField
            // 
            this.txtVariableField.Location = new System.Drawing.Point(191, 272);
            this.txtVariableField.Name = "txtVariableField";
            this.txtVariableField.Size = new System.Drawing.Size(111, 20);
            this.txtVariableField.TabIndex = 35;
            // 
            // txtPartMin
            // 
            this.txtPartMin.Location = new System.Drawing.Point(347, 235);
            this.txtPartMin.Name = "txtPartMin";
            this.txtPartMin.Size = new System.Drawing.Size(105, 20);
            this.txtPartMin.TabIndex = 34;
            // 
            // txtPartMax
            // 
            this.txtPartMax.Location = new System.Drawing.Point(191, 235);
            this.txtPartMax.Name = "txtPartMax";
            this.txtPartMax.Size = new System.Drawing.Size(111, 20);
            this.txtPartMax.TabIndex = 33;
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Location = new System.Drawing.Point(191, 196);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(112, 20);
            this.txtPartPrice.TabIndex = 32;
            // 
            // txtPartInventory
            // 
            this.txtPartInventory.Location = new System.Drawing.Point(191, 157);
            this.txtPartInventory.Name = "txtPartInventory";
            this.txtPartInventory.Size = new System.Drawing.Size(112, 20);
            this.txtPartInventory.TabIndex = 31;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(191, 114);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(112, 20);
            this.txtPartName.TabIndex = 30;
            // 
            // txtPartID
            // 
            this.txtPartID.Enabled = false;
            this.txtPartID.Location = new System.Drawing.Point(191, 70);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(112, 20);
            this.txtPartID.TabIndex = 29;
            // 
            // lblVariableField
            // 
            this.lblVariableField.AutoSize = true;
            this.lblVariableField.Location = new System.Drawing.Point(113, 272);
            this.lblVariableField.Name = "lblVariableField";
            this.lblVariableField.Size = new System.Drawing.Size(62, 13);
            this.lblVariableField.TabIndex = 28;
            this.lblVariableField.Text = "Machine ID";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(308, 238);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 27;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(148, 238);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 26;
            this.lblMax.Text = "Max";
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.Location = new System.Drawing.Point(112, 203);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.Size = new System.Drawing.Size(63, 13);
            this.lblPriceCost.TabIndex = 25;
            this.lblPriceCost.Text = "Price / Cost";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(124, 164);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 24;
            this.lblInventory.Text = "Inventory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(140, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(157, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID";
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Location = new System.Drawing.Point(243, 18);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(80, 17);
            this.rbOutsourced.TabIndex = 21;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.CheckedChanged += new System.EventHandler(this.rbOutsourced_CheckedChanged);
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Location = new System.Drawing.Point(160, 18);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse.TabIndex = 20;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.rbInHouse_CheckedChanged);
            // 
            // lblModifyPartTitle
            // 
            this.lblModifyPartTitle.AutoSize = true;
            this.lblModifyPartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModifyPartTitle.Location = new System.Drawing.Point(17, 15);
            this.lblModifyPartTitle.Name = "lblModifyPartTitle";
            this.lblModifyPartTitle.Size = new System.Drawing.Size(88, 20);
            this.lblModifyPartTitle.TabIndex = 19;
            this.lblModifyPartTitle.Text = "Modify Part";
            this.lblModifyPartTitle.Click += new System.EventHandler(this.lblAddPartTitle_Click);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 354);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVariableField);
            this.Controls.Add(this.txtPartMin);
            this.Controls.Add(this.txtPartMax);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.txtPartInventory);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.lblVariableField);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPriceCost);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.lblModifyPartTitle);
            this.Name = "ModifyPartForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.ModifyPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVariableField;
        private System.Windows.Forms.TextBox txtPartMin;
        private System.Windows.Forms.TextBox txtPartMax;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.TextBox txtPartInventory;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label lblVariableField;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.Label lblModifyPartTitle;
    }
}