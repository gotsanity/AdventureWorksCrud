
namespace AdventureWorksCrud
{
    partial class frmAddressDetail
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
            this.grpAddressDetail = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblCountryRegion = new System.Windows.Forms.Label();
            this.txtCountryRegion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStateProvince = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpAddressDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddressDetail
            // 
            this.grpAddressDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddressDetail.Controls.Add(this.btnDelete);
            this.grpAddressDetail.Controls.Add(this.btnSave);
            this.grpAddressDetail.Controls.Add(this.btnExit);
            this.grpAddressDetail.Controls.Add(this.lblAddressType);
            this.grpAddressDetail.Controls.Add(this.txtAddressType);
            this.grpAddressDetail.Controls.Add(this.lblPostalCode);
            this.grpAddressDetail.Controls.Add(this.txtPostalCode);
            this.grpAddressDetail.Controls.Add(this.lblCountryRegion);
            this.grpAddressDetail.Controls.Add(this.txtCountryRegion);
            this.grpAddressDetail.Controls.Add(this.label1);
            this.grpAddressDetail.Controls.Add(this.txtStateProvince);
            this.grpAddressDetail.Controls.Add(this.lblCity);
            this.grpAddressDetail.Controls.Add(this.txtCity);
            this.grpAddressDetail.Controls.Add(this.lblAddressLine2);
            this.grpAddressDetail.Controls.Add(this.txtAddressLine2);
            this.grpAddressDetail.Controls.Add(this.lblAddressLine1);
            this.grpAddressDetail.Controls.Add(this.txtAddressLine1);
            this.grpAddressDetail.Location = new System.Drawing.Point(12, 12);
            this.grpAddressDetail.Name = "grpAddressDetail";
            this.grpAddressDetail.Size = new System.Drawing.Size(797, 281);
            this.grpAddressDetail.TabIndex = 0;
            this.grpAddressDetail.TabStop = false;
            this.grpAddressDetail.Text = "Address Details";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(672, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(7, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(6, 181);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(119, 25);
            this.lblAddressType.TabIndex = 13;
            this.lblAddressType.Text = "Address Type";
            // 
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(146, 178);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.Size = new System.Drawing.Size(246, 31);
            this.txtAddressType.TabIndex = 12;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(398, 144);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(101, 25);
            this.lblPostalCode.TabIndex = 11;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(538, 141);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(246, 31);
            this.txtPostalCode.TabIndex = 10;
            // 
            // lblCountryRegion
            // 
            this.lblCountryRegion.AutoSize = true;
            this.lblCountryRegion.Location = new System.Drawing.Point(398, 107);
            this.lblCountryRegion.Name = "lblCountryRegion";
            this.lblCountryRegion.Size = new System.Drawing.Size(137, 25);
            this.lblCountryRegion.TabIndex = 9;
            this.lblCountryRegion.Text = "Country/Region";
            // 
            // txtCountryRegion
            // 
            this.txtCountryRegion.Location = new System.Drawing.Point(538, 104);
            this.txtCountryRegion.Name = "txtCountryRegion";
            this.txtCountryRegion.Size = new System.Drawing.Size(246, 31);
            this.txtCountryRegion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "State/Province";
            // 
            // txtStateProvince
            // 
            this.txtStateProvince.Location = new System.Drawing.Point(146, 141);
            this.txtStateProvince.Name = "txtStateProvince";
            this.txtStateProvince.Size = new System.Drawing.Size(246, 31);
            this.txtStateProvince.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 107);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 25);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(146, 104);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(246, 31);
            this.txtCity.TabIndex = 4;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(6, 70);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(128, 25);
            this.lblAddressLine2.TabIndex = 3;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(146, 67);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(638, 31);
            this.txtAddressLine2.TabIndex = 2;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(6, 33);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(128, 25);
            this.lblAddressLine1.TabIndex = 1;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(146, 30);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(638, 31);
            this.txtAddressLine1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAddressDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 305);
            this.Controls.Add(this.grpAddressDetail);
            this.Name = "frmAddressDetail";
            this.Text = "AddressDetail";
            this.grpAddressDetail.ResumeLayout(false);
            this.grpAddressDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddressDetail;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblCountryRegion;
        private System.Windows.Forms.TextBox txtCountryRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStateProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
    }
}