using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AdventureWorksCrud.Models;

namespace AdventureWorksCrud
{
    class db
    {
        public static string getConnection()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
        }

        public static DataTable GetAllCustomers()
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetAllCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                DataTable dt = new DataTable("Customers");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public static DataTable GetCustomerByID(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                if (id > 0)
                {
                    SqlParameter p = new SqlParameter("@customerID", id);
                    cmd.Parameters.Add(p);
                }

                conn.Open();

                DataTable dt = new DataTable("Customer");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public static Customer GetCustomerObject(int id)
        {
            Customer customer = new Customer();

            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                if (id > 0)
                {
                    SqlParameter p = new SqlParameter("@customerID", id);
                    cmd.Parameters.Add(p);
                }

                conn.Open();

                DataTable dt = new DataTable("Customer");

                dt.Load(cmd.ExecuteReader());

                customer.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"].ToString());
                customer.NameStyle = Convert.ToBoolean(dt.Rows[0]["NameStyle"].ToString());
                customer.Title = dt.Rows[0]["Title"].ToString();
                customer.FirstName = dt.Rows[0]["FirstName"].ToString();
                customer.MiddleName = dt.Rows[0]["MiddleName"].ToString();
                customer.LastName = dt.Rows[0]["LastName"].ToString();
                customer.Suffix = dt.Rows[0]["Suffix"].ToString();
                customer.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                customer.SalesPerson = dt.Rows[0]["SalesPerson"].ToString();
                customer.EmailAddress = dt.Rows[0]["EmailAddress"].ToString();
                customer.Phone = dt.Rows[0]["Phone"].ToString();
                customer.PasswordHash = dt.Rows[0]["PasswordHash"].ToString();
                customer.PasswordSalt = dt.Rows[0]["PasswordSalt"].ToString();
                customer.rowguid = dt.Rows[0]["rowguid"].ToString();
                customer.ModifiedDate = Convert.ToDateTime(dt.Rows[0]["ModifiedDate"].ToString());

                return customer;
            }

        }

        public static void CreateCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.CreateCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NameStyle", customer.NameStyle);
                cmd.Parameters.AddWithValue("@Title", customer.Title);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", customer.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Suffix", customer.Suffix);
                cmd.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                cmd.Parameters.AddWithValue("@SalesPerson", customer.SalesPerson);
                cmd.Parameters.AddWithValue("@EmailAddress", customer.EmailAddress);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@PasswordHash", "L/Rlwxzp4w7RWmEgXX+/A7cXaePEPcp+KwQhl2fJL7w=");
                cmd.Parameters.AddWithValue("@PasswordSalt", "1KjXYs4=");

                conn.Open();

                DataTable dt = new DataTable("Customer");

                dt.Load(cmd.ExecuteReader());
            }
        }

        public static void UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.UpdateCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                cmd.Parameters.AddWithValue("@NameStyle", customer.NameStyle);
                cmd.Parameters.AddWithValue("@Title", customer.Title);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", customer.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Suffix", customer.Suffix);
                cmd.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                cmd.Parameters.AddWithValue("@SalesPerson", customer.SalesPerson);
                cmd.Parameters.AddWithValue("@EmailAddress", customer.EmailAddress);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@PasswordHash", "L/Rlwxzp4w7RWmEgXX+/A7cXaePEPcp+KwQhl2fJL7w=");
                cmd.Parameters.AddWithValue("@PasswordSalt", "1KjXYs4=");

                conn.Open();

                DataTable dt = new DataTable("Customer");

                dt.Load(cmd.ExecuteReader());
            }
        }

        public static void DeleteCustomerByID(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.DeleteCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                if (id > 0)
                {
                    cmd.Parameters.AddWithValue("@customerID", id);
                }

                conn.Open();

                DataTable dt = new DataTable("Customer");

                dt.Load(cmd.ExecuteReader());
            }
        }

        public static DataTable GetAddressByID(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetCustomerAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                if (id > 0)
                {
                    cmd.Parameters.AddWithValue("@customerID", id);
                }

                conn.Open();

                DataTable dt = new DataTable("CustomerAddress");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public static Address GetAddressModelByID(int id)
        {
            Address address = new Address();

            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetCustomerAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                if (id > 0)
                {
                    cmd.Parameters.AddWithValue("@customerID", id);
                }

                conn.Open();

                DataTable dt = new DataTable("CustomerAddress");

                dt.Load(cmd.ExecuteReader());

                address.AddressID = Convert.ToInt32(dt.Rows[0]["AddressID"].ToString());
                address.AddressType = dt.Rows[0]["AddressType"].ToString();
                address.AddressLine1 = dt.Rows[0]["AddressLine1"].ToString();
                address.AddressLine2 = dt.Rows[0]["AddressLine2"].ToString();
                address.City = dt.Rows[0]["City"].ToString();
                address.StateProvince = dt.Rows[0]["StateProvince"].ToString();
                address.CountryRegion = dt.Rows[0]["CountryRegion"].ToString();
                address.PostalCode = dt.Rows[0]["PostalCode"].ToString();

                return address;
            }
        }

        public static void CreateCustomerAddress(Address address)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.CreateCustomerAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", address.CustomerID);
                cmd.Parameters.AddWithValue("@AddressLine1", address.AddressLine1);
                cmd.Parameters.AddWithValue("@AddressLine2", address.AddressLine2);
                cmd.Parameters.AddWithValue("@City", address.City);
                cmd.Parameters.AddWithValue("@StateProvince", address.StateProvince);
                cmd.Parameters.AddWithValue("@CountryRegion", address.CountryRegion);
                cmd.Parameters.AddWithValue("@PostalCode", address.PostalCode);
                cmd.Parameters.AddWithValue("@AddressType", address.AddressType);

                conn.Open();

                DataTable dt = new DataTable("CustomerAddress");

                dt.Load(cmd.ExecuteReader());
            }
        }

        public static void UpdateCustomerAddress(Address address)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.UpdateCustomerAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", address.CustomerID);
                cmd.Parameters.AddWithValue("@AddressID", address.AddressID);
                cmd.Parameters.AddWithValue("@AddressLine1", address.AddressLine1);
                cmd.Parameters.AddWithValue("@AddressLine2", address.AddressLine2);
                cmd.Parameters.AddWithValue("@City", address.City);
                cmd.Parameters.AddWithValue("@StateProvince", address.StateProvince);
                cmd.Parameters.AddWithValue("@CountryRegion", address.CountryRegion);
                cmd.Parameters.AddWithValue("@PostalCode", address.PostalCode);
                cmd.Parameters.AddWithValue("@AddressType", address.AddressType);

                conn.Open();

                DataTable dt = new DataTable("CustomerAddress");

                dt.Load(cmd.ExecuteReader());
            }
        }

        public static void DeleteCustomerAddress(Address address)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.DeleteCustomerAddress";
                cmd.CommandType = CommandType.StoredProcedure;

                if (address.CustomerID > 0 && address.AddressID > 0)
                {
                    cmd.Parameters.AddWithValue("@CustomerID", address.CustomerID);
                    cmd.Parameters.AddWithValue("@AddressID", address.AddressID);
                }

                conn.Open();

                DataTable dt = new DataTable("CustomerAddress");

                dt.Load(cmd.ExecuteReader());
            }
        }

        public static DataTable GetParentCategories()
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetParentCategories";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                DataTable dt = new DataTable("ParentCategories");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public static DataTable GetChildCategories(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetChildCategories";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@parentID", id);

                conn.Open();

                DataTable dt = new DataTable("ChildCategories");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public static DataTable GetLanguages()
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetCultures";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                DataTable dt = new DataTable("Cultures");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public static DataTable GetProducts(string culture, int category)
        {
            using (SqlConnection conn = new SqlConnection(db.getConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SalesLT.GetProductView";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@culture", culture);
                cmd.Parameters.AddWithValue("@category", category);

                conn.Open();

                DataTable dt = new DataTable("Products");

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }
    }
}
