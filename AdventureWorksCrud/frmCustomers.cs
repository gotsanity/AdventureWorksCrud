using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdventureWorksCrud
{
    public partial class frmCustomers : Form
    {
        string[] hiddenColumns = new string[5] { "NameStyle", "PasswordHash", "PasswordSalt", "rowguid", "ModifiedDate" };

        public frmCustomers()
        {
            InitializeComponent();

            gridData.CellClick += new DataGridViewCellEventHandler(this.gridData_CellContentClick);
            gridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            RefreshForm();
        }

        private void btnFetchByID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCustomerID.Text);

            ShowCustomerDialog(id);
            RefreshForm();
        }

        private void btnGetAllCustomers_Click(object sender, EventArgs e)
        {
            Form Products = new frmProducts();
            Products.Show();
            this.Hide();
        }

        private void ClearForm()
        {
            txtCustomerID.Text = "";
            txtCustomerID.Focus();
        }

        private void RefreshForm()
        {
            gridData.DataSource = db.GetAllCustomers();

            foreach (string item in hiddenColumns)
            {
                gridData.Columns[item].Visible = false;
            }
            ClearForm();
        }

        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int id = Convert.ToInt32(gridData.SelectedRows[0].Cells[0].Value.ToString());
            ShowCustomerDialog(id);
            RefreshForm();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ShowCustomerDialog();
            RefreshForm();
        }

        private void ShowCustomerDialog(int id = 0)
        {
            if (id > 0)
            {
                using (Form form = new frmCustomerDetails(id))
                {
                    form.ShowDialog(this);
                }
            }
            else
            {
                using (Form form = new frmCustomerDetails())
                {
                    form.ShowDialog(this);
                }
            }
        }

        private void frmCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
