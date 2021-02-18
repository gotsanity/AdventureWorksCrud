
namespace AdventureWorksCrud
{
    partial class frmCustomers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridData = new System.Windows.Forms.DataGridView();
            this.btnFetchByID = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(12, 88);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersVisible = false;
            this.gridData.RowHeadersWidth = 62;
            this.gridData.RowTemplate.Height = 33;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(1679, 760);
            this.gridData.TabIndex = 0;
            // 
            // btnFetchByID
            // 
            this.btnFetchByID.Location = new System.Drawing.Point(162, 28);
            this.btnFetchByID.Name = "btnFetchByID";
            this.btnFetchByID.Size = new System.Drawing.Size(150, 34);
            this.btnFetchByID.TabIndex = 1;
            this.btnFetchByID.Text = "Get";
            this.btnFetchByID.UseVisualStyleBackColor = true;
            this.btnFetchByID.Click += new System.EventHandler(this.btnFetchByID_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(6, 30);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(150, 31);
            this.txtCustomerID.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.btnFetchByID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find by Customer ID";
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetProducts.Location = new System.Drawing.Point(1531, 30);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(160, 34);
            this.btnGetProducts.TabIndex = 5;
            this.btnGetProducts.Text = "View &Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetAllCustomers_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNew.Location = new System.Drawing.Point(795, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 34);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 875);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridData);
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomers_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button btnFetchByID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Button btnAddNew;
    }
}

