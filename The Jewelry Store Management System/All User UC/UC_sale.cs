using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Jewelry_Store_Management_System.All_User_UC
{
    public partial class UC_sale : UserControl
    {
        function fn = new function();
        String query;
        public UC_sale()
        {
            InitializeComponent();
            txtunit.TextChanged += new EventHandler(CalculateTotalPrice);
            txtamount.TextChanged += new EventHandler(CalculateTotalPrice);
            PopulateProductIDComboBox();
        }

        private void CalculateTotalPrice(object sender, EventArgs e)
        {
            if (txtamount.Text != "" && txtunit.Text != "")
            {
                if (Int64.TryParse(txtamount.Text, out Int64 saleamount) && Int64.TryParse(txtunit.Text, out Int64 saleunit))
                {
                    Int64 saletotalprice = saleamount * saleunit;
                    txttotal.Text = saletotalprice.ToString();
                }
                else
                {
                    txttotal.Text = "Invalid input";
                }
            }
            else
            {
                txttotal.Text = "";
            }
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }    
            }
            sdr.Close();
        }
        
        private void UC_sale_Load(object sender, EventArgs e)
        {
            query = "Select * from sale ";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        
        public void PopulateProductIDComboBox()
        {
            query = "SELECT productid FROM inventory";
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                txtcomboproductid.Items.Add(sdr.GetString(0));
            }
            sdr.Close();
        }
 

        int poid;
        private void txtcomboproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT product, productid FROM inventory WHERE productid = '" + txtcomboproductid.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtproductname.Text = ds.Tables[0].Rows[0]["product"].ToString();
                poid = int.Parse(ds.Tables[0].Rows[0]["productid"].ToString());
            }
        } 
        //private void btAdd_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            if (txtinvoiceid.Text != "" && txtCustomer.Text != "" && txtcustomerID.Text != "" && txtproductname.Text != "" && txtamount.Text != "" && txtunit.Text != "")
            {
                Int64 saleinvoiceID = Int64.Parse(txtinvoiceid.Text);
                String saledate = txtsaledate.Text;
                String customer = txtCustomer.Text;
                String customerid = txtcustomerID.Text;
                String product = txtproductname.Text;
                Int64 saleamount = Int64.Parse(txtamount.Text);
                Int64 saleunit = Int64.Parse(txtunit.Text);
                Int64 saletotalprice = saleamount * saleunit;
                txttotal.Text = saletotalprice.ToString();

                // Đảm bảo poid được định nghĩa và gán giá trị
                String poid = txtcomboproductid.Text;

                query = "SELECT amount FROM inventory WHERE productid = '" + poid + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Int64 availableAmount = Int64.Parse(ds.Tables[0].Rows[0]["amount"].ToString());
                    if (saleamount > availableAmount)
                    {
                        MessageBox.Show("The number of products sold is greater than the number of products available in inventory", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Product not available", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm thông tin vào bảng sale
                query = "insert into sale (saleinvoiceID, saledate, customer, customerId, productID, product, saleamount, saleunitprice, saletotalprice) values ('" + saleinvoiceID + "','" + saledate + "','" + customer + "','" + customerid + "','" + poid + "','" + product + "','" + saleamount + "','" + saleunit + "','" + saletotalprice + "')";
                fn.setData(query, "Product ID " + txtcomboproductid.Text + " sole");

                // Xóa thông tin khỏi bảng inventory
                query = "UPDATE inventory SET amount = amount - " + saleamount + " WHERE productid = '" + poid + "'";
                fn.setData(query, "amount of productID " + poid + " update ");

                UC_sale_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please enter complete information", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearAll()
        {
            txtinvoiceid.Clear();
            txtamount.Clear();
            txtunit.Clear();
            txtCustomer.Clear();
            txtcustomerID.Clear();
            txtproductname.Clear();
            txtcomboproductid.SelectedIndex = -1;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(txtinvoiceid.Text != "")
            {
                Int64 saleinvoiceID = Int64.Parse(txtinvoiceid.Text);
                query = "DELETE FROM sale WHERE saleinvoiceID = '" + saleinvoiceID + "'";
                fn.setData(query, "Delete product from sale");
                UC_sale_Load(this,null);
                ClearAll();
            }    
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtinvoiceid.Clear();
            txtamount.Clear();
            txtunit.Clear();
            txtCustomer.Clear();
            txtcustomerID.Clear();
            txtproductname.Clear();
            txtcomboproductid.SelectedIndex = -1;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            SaleInvoice saleInvoiceForm = new SaleInvoice();

            // Truyền thông tin từ các ô văn bản sang các Label trên SaleInvoiceForm
            saleInvoiceForm.lblInvoiceID.Text = txtinvoiceid.Text;
            saleInvoiceForm.lblDate.Text = txtsaledate.Text;
            saleInvoiceForm.lblCustomer.Text = txtCustomer.Text;
            saleInvoiceForm.lblCustomerID.Text = txtcustomerID.Text;
            saleInvoiceForm.lblProduct.Text = txtproductname.Text;
            saleInvoiceForm.lblProductID.Text = txtcomboproductid.Text;
            saleInvoiceForm.lblAmount.Text = txtamount.Text;
            saleInvoiceForm.lblUnitPrice.Text = txtunit.Text;
            saleInvoiceForm.lblTotalPrice.Text = txttotal.Text;

            // Hiển thị form mới
            saleInvoiceForm.ShowDialog();
        }
    }
}
