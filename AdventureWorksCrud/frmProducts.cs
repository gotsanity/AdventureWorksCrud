using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksCrud
{
    public partial class frmProducts : Form
    {
        DataSet categories = new DataSet();

        public frmProducts()
        {
            InitializeComponent();
            categories.Tables.Add(db.GetParentCategories());
            categories.Tables.Add(db.GetLanguages());

            cmbParentCategory.DataSource = categories.Tables["ParentCategories"];
            cmbParentCategory.DisplayMember = "Name";
            cmbParentCategory.ValueMember = "ProductCategoryID";

            cmbLanguage.DataSource = categories.Tables["Cultures"];
            cmbLanguage.DisplayMember = "Culture";
            cmbLanguage.ValueMember = "Culture";

            UpdateCategories();
            RefreshView();
        }

        private void UpdateCategories()
        {
            if (categories.Tables.Contains("ChildCategories"))
            {
                categories.Tables.Remove("ChildCategories");
            }
            int id = Convert.ToInt32(((DataRowView)cmbParentCategory.SelectedItem).Row[0].ToString());
            categories.Tables.Add(db.GetChildCategories(id));
            cmbCategory.DataSource = categories.Tables["ChildCategories"];
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "ProductCategoryID";
        }

        private void RefreshView()
        {
            string culture = ((DataRowView)cmbLanguage.SelectedItem).Row[0].ToString();
            int category = Convert.ToInt32(((DataRowView) cmbCategory.SelectedItem).Row[0].ToString());
            gridProducts.DataSource = db.GetProducts(culture, category);
            gridProducts.Columns[0].Visible = false;
        }

        private void frmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form Customers = new frmCustomers();
            Customers.Show();
            this.Hide();
        }

        private void cmbParentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCategories();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
