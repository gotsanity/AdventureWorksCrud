
namespace AdventureWorksCrud
{
    partial class frmCustomerDetails
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridAddress = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.grpCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(750, 67);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(98, 31);
            this.txtTitle.TabIndex = 0;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(1030, 24);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(112, 34);
            this.btnSaveNew.TabIndex = 1;
            this.btnSaveNew.Text = "&Save";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(693, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtPhone);
            this.grpCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.txtEmailAddress);
            this.grpCustomerDetails.Controls.Add(this.lblEmailAddress);
            this.grpCustomerDetails.Controls.Add(this.txtSalesPerson);
            this.grpCustomerDetails.Controls.Add(this.lblSalesPerson);
            this.grpCustomerDetails.Controls.Add(this.txtCompanyName);
            this.grpCustomerDetails.Controls.Add(this.lblCompanyName);
            this.grpCustomerDetails.Controls.Add(this.txtSuffix);
            this.grpCustomerDetails.Controls.Add(this.lblSuffix);
            this.grpCustomerDetails.Controls.Add(this.txtLastName);
            this.grpCustomerDetails.Controls.Add(this.lblLastName);
            this.grpCustomerDetails.Controls.Add(this.txtMiddleName);
            this.grpCustomerDetails.Controls.Add(this.lblMiddleName);
            this.grpCustomerDetails.Controls.Add(this.txtFirstName);
            this.grpCustomerDetails.Controls.Add(this.lblFirstName);
            this.grpCustomerDetails.Controls.Add(this.txtTitle);
            this.grpCustomerDetails.Controls.Add(this.lblTitle);
            this.grpCustomerDetails.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(1012, 229);
            this.grpCustomerDetails.TabIndex = 3;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(749, 178);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 31);
            this.txtPhone.TabIndex = 17;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(605, 181);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(132, 25);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(190, 178);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(412, 31);
            this.txtEmailAddress.TabIndex = 15;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(12, 181);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(124, 25);
            this.lblEmailAddress.TabIndex = 16;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(190, 141);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(816, 31);
            this.txtSalesPerson.TabIndex = 13;
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.Location = new System.Drawing.Point(12, 144);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(110, 25);
            this.lblSalesPerson.TabIndex = 14;
            this.lblSalesPerson.Text = "Sales Person";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(190, 104);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(816, 31);
            this.txtCompanyName.TabIndex = 11;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(12, 107);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(141, 25);
            this.lblCompanyName.TabIndex = 12;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(916, 67);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(90, 31);
            this.txtSuffix.TabIndex = 9;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(854, 70);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(56, 25);
            this.lblSuffix.TabIndex = 10;
            this.lblSuffix.Text = "Suffix";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(190, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(412, 31);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 25);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(750, 30);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(256, 31);
            this.txtMiddleName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(618, 33);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(119, 25);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(190, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(412, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 25);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1030, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1030, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridAddress
            // 
            this.gridAddress.AllowUserToAddRows = false;
            this.gridAddress.AllowUserToDeleteRows = false;
            this.gridAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAddress.Location = new System.Drawing.Point(12, 63);
            this.gridAddress.Name = "gridAddress";
            this.gridAddress.ReadOnly = true;
            this.gridAddress.RowHeadersVisible = false;
            this.gridAddress.RowHeadersWidth = 62;
            this.gridAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAddress.Size = new System.Drawing.Size(1118, 158);
            this.gridAddress.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAddress);
            this.groupBox1.Controls.Add(this.gridAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Addresses";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(1018, 23);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(112, 34);
            this.btnAddAddress.TabIndex = 8;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 492);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCustomerDetails";
            this.Text = "Customer Details";
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAddress;
    }
}