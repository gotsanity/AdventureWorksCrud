using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureWorksCrud.Models;

namespace AdventureWorksCrud
{
    public partial class frmAddressDetail : Form
    {
        private Address address;
        private bool isEditing;

        public frmAddressDetail(Address address, bool isEditing = true)
        {
            InitializeComponent();
            this.address = address;
            this.isEditing = isEditing;
            btnDelete.Enabled = isEditing;
            BindAddress();
        }

        public void BindAddress()
        {
            txtAddressType.DataBindings.Add("Text", this.address, "AddressType");
            txtAddressLine1.DataBindings.Add("Text", this.address, "AddressLine1");
            txtAddressLine2.DataBindings.Add("Text", this.address, "AddressLine2");
            txtCity.DataBindings.Add("Text", this.address, "City");
            txtStateProvince.DataBindings.Add("Text", this.address, "StateProvince");
            txtCountryRegion.DataBindings.Add("Text", this.address, "CountryRegion");
            txtPostalCode.DataBindings.Add("Text", this.address, "PostalCode");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.isEditing)
            {
                db.UpdateCustomerAddress(this.address);
            }
            else
            {
                db.CreateCustomerAddress(this.address);
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteCustomerAddress(address);
            this.Close();
        }
    }
}
