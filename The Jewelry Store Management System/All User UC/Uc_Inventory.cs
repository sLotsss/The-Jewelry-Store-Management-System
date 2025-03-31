using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Jewelry_Store_Management_System.All_User_UC
{
    public partial class Uc_Inventory : UserControl
    {
        function fn = new function();
        String query;
        public Uc_Inventory()
        {
            InitializeComponent();
        }

        private void Uc_Inventory_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu từ cơ sở dữ liệu
            query = "Select * from inventory";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
     

        public void UpdateInventoryGrid(Int64 productid, string product, string producttype, string supplier, Int64 amount)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("productid", "Product ID");
                dataGridView1.Columns.Add("product", "Product");
                dataGridView1.Columns.Add("producttype", "Product Type");
                dataGridView1.Columns.Add("supplier", "Supplier");
                dataGridView1.Columns.Add("amount", "Amount");
            }
            dataGridView1.Rows.Add(productid, product, producttype, supplier, amount);
            Uc_Inventory_Load(this, null);
        }


    }
}
