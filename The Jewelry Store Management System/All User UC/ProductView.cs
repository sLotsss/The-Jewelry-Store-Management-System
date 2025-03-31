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
    public partial class ProductView : UserControl
    {
        function fn = new function();
        String query;
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu từ cơ sở dữ liệu
            query = "Select * from Table_1";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void UpdateInventoryGrid(Int64 productid, string productName, Int64 amountProduct)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("productid", "Product ID");
                dataGridView1.Columns.Add("productName", "product");           
                dataGridView1.Columns.Add("amountProduct", "importamount");
            }
            dataGridView1.Rows.Add(productid, productName, amountProduct);
            ProductView_Load(this, null);
        }
    }
}
