
namespace AdventureWorksCrud
{
    partial class frmProducts
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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblParentCategory = new System.Windows.Forms.Label();
            this.cmbParentCategory = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(12, 57);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowHeadersWidth = 62;
            this.gridProducts.RowTemplate.Height = 33;
            this.gridProducts.Size = new System.Drawing.Size(1720, 693);
            this.gridProducts.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(456, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(204, 33);
            this.cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(366, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 25);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomers.Location = new System.Drawing.Point(1571, 11);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(161, 34);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "View &Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblParentCategory
            // 
            this.lblParentCategory.AutoSize = true;
            this.lblParentCategory.Location = new System.Drawing.Point(12, 16);
            this.lblParentCategory.Name = "lblParentCategory";
            this.lblParentCategory.Size = new System.Drawing.Size(138, 25);
            this.lblParentCategory.TabIndex = 5;
            this.lblParentCategory.Text = "Parent Category";
            // 
            // cmbParentCategory
            // 
            this.cmbParentCategory.FormattingEnabled = true;
            this.cmbParentCategory.Location = new System.Drawing.Point(156, 12);
            this.cmbParentCategory.Name = "cmbParentCategory";
            this.cmbParentCategory.Size = new System.Drawing.Size(204, 33);
            this.cmbParentCategory.TabIndex = 4;
            this.cmbParentCategory.SelectedIndexChanged += new System.EventHandler(this.cmbParentCategory_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(666, 16);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(89, 25);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Language";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(756, 12);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(132, 33);
            this.cmbLanguage.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(894, 11);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(73, 34);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 762);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblParentCategory);
            this.Controls.Add(this.cmbParentCategory);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.gridProducts);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProducts_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label lblParentCategory;
        private System.Windows.Forms.ComboBox cmbParentCategory;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnView;
    }
}