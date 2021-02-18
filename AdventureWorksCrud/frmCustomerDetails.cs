using AdventureWorksCrud.Models;
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
    public partial class frmCustomerDetails : Form
    {
        private Customer customer = new Customer();
        private bool isEditing;

        public frmCustomerDetails()
        {
            InitializeComponent();
            this.isEditing = false;
            btnDelete.Enabled = false;
            btnAddAddress.Enabled = false;
            gridAddress.CellClick += new DataGridViewCellEventHandler(this.gridAddress_CellContentClick);
            gridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BindFields();
        }

        public frmCustomerDetails(int id)
        {
            InitializeComponent();

            this.customer = db.GetCustomerObject(id);
            this.isEditing = true;
            BindFields();
            gridAddress.CellClick += new DataGridViewCellEventHandler(this.gridAddress_CellContentClick);
            gridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FetchAddresses();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindFields()
        {
            txtTitle.DataBindings.Add("Text", this.customer, "Title");
            txtFirstName.DataBindings.Add("Text", this.customer, "FirstName");
            txtMiddleName.DataBindings.Add("Text", this.customer, "MiddleName");
            txtLastName.DataBindings.Add("Text", this.customer, "LastName");
            txtSuffix.DataBindings.Add("Text", this.customer, "Suffix");
            txtCompanyName.DataBindings.Add("Text", this.customer, "CompanyName");
            txtSalesPerson.DataBindings.Add("Text", this.customer, "SalesPerson");
            txtEmailAddress.DataBindings.Add("Text", this.customer, "EmailAddress");
            txtPhone.DataBindings.Add("Text", this.customer, "Phone");
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (this.isEditing)
            {
                // do editing stuff
                db.UpdateCustomer(this.customer);
            }
            else
            {
                db.CreateCustomer(this.customer);
            }
            
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteCustomerByID(this.customer.CustomerID);
            this.Close();
        }

        private void gridAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            Address address = new Address();

            address.CustomerID = Convert.ToInt32(gridAddress.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            address.AddressID = Convert.ToInt32(gridAddress.SelectedRows[0].Cells["AddressID"].Value.ToString());
            address.AddressType = gridAddress.SelectedRows[0].Cells["AddressType"].Value.ToString();
            address.AddressLine1 = gridAddress.SelectedRows[0].Cells["AddressLine1"].Value.ToString();
            address.AddressLine2 = gridAddress.SelectedRows[0].Cells["AddressLine2"].Value.ToString();
            address.City = gridAddress.SelectedRows[0].Cells["City"].Value.ToString();
            address.StateProvince = gridAddress.SelectedRows[0].Cells["StateProvince"].Value.ToString();
            address.CountryRegion = gridAddress.SelectedRows[0].Cells["CountryRegion"].Value.ToString();
            address.PostalCode = gridAddress.SelectedRows[0].Cells["PostalCode"].Value.ToString();

            using (Form form = new frmAddressDetail(address))
            {
                form.ShowDialog(this);
            }
            FetchAddresses();
        }

        private void FetchAddresses()
        {
            gridAddress.DataSource = db.GetAddressByID(this.customer.CustomerID);
            gridAddress.Columns[0].Visible = false;
            gridAddress.Columns[1].Visible = false;
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            Address address = new Address();

            address.CustomerID = this.customer.CustomerID;
            
            using (Form form = new frmAddressDetail(address, false))
            {
                form.ShowDialog(this);
            }
            FetchAddresses();
        }
    }
}
