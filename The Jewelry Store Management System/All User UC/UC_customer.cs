using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Jewelry_Store_Management_System.All_User_UC
{
    public partial class UC_customer : UserControl
    {
        function fn = new function();
        String query;
        public UC_customer()
        {
            InitializeComponent();
        }

        private void UC_customer_Load(object sender, EventArgs e)
        {
            query = "Select * from Customer";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void UpdateCustomerGrid(String customerid, string customer, string productid, string type)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("customerID", "Customer ID");
                dataGridView1.Columns.Add("customer", "Customer");
                dataGridView1.Columns.Add("productID", "Product ID");
                dataGridView1.Columns.Add("service", "Service");
            }
            dataGridView1.Rows.Add(customerid, customer, productid, type);
            UC_customer_Load(this, null);
        }
    }
}
