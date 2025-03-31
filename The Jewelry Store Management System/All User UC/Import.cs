using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Jewelry_Store_Management_System.All_User_UC
{
    public partial class Import : UserControl
    {
        function fn = new function();
        String query;
        public Import()
        {
            InitializeComponent();
            txtunitprice.TextChanged += new EventHandler(CalculateTotalPrice);
            txtamount.TextChanged += new EventHandler(CalculateTotalPrice);
        }
        private void CalculateTotalPrice(object sender, EventArgs e)
        {
            if (txtamount.Text != "" && txtunitprice.Text != "")
            {
                if (Int64.TryParse(txtamount.Text, out Int64 importamount) && Int64.TryParse(txtunitprice.Text, out Int64 importunitprice))
                {
                    Int64 importtotalprice = importamount * importunitprice;
                    txttotal.Text = importtotalprice.ToString();
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

        private void Import_Load(object sender, EventArgs e)
        {
            query = "Select * from import ";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtamount.Text != "" && txtInvoiceid.Text != "" && txtproduct.Text != "" && txtproductid.Text != "" && txtproducttype.Text != "" && txtsupplier.Text != "" && txtunitprice.Text != "")
            {
                Int64 inportinvoiceid = int.Parse(txtInvoiceid.Text);
                String importdate = txtdatemake.Text;
                String product = txtproduct.Text;
                Int64 productid = int.Parse(txtproductid.Text);
                String producttype = txtproducttype.Text;
                String supplier = txtsupplier.Text;
                Int64 importamount = int.Parse(txtamount.Text);
                Int64 importunitprice = int.Parse(txtunitprice.Text);
                Int64 importtotalprice = importamount * importunitprice;
                txttotal.Text = importtotalprice.ToString();

                // Kiểm tra xem productid có tồn tại trong bảng inventory không
                query = "SELECT productid FROM inventory WHERE productid = '" + productid + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Nếu productid tồn tại, thêm dữ liệu vào bảng import
                    query = "INSERT INTO import (importinvoiceID, importdate, product, productID, producttype, supplier, importamount, importunitprice, importtotalprice) " +
                            "VALUES ('" + inportinvoiceid + "','" + importdate + "','" + product + "','" + productid + "','" + producttype + "','" + supplier + "','" + importamount + "','" + importunitprice + "','" + importtotalprice + "')";
                    fn.setData(query, "Add product");

                    // Cập nhật dữ liệu trong UserControl của inventory
                    Uc_Inventory inventoryControl = new Uc_Inventory();
                    inventoryControl.UpdateInventoryGrid(productid, product, producttype, supplier, importamount);

                    // Thêm dữ liệu vào bảng Table_1
                    AddToTable1(productid, product, importamount);

                    Import_Load(this, null);
                    ClearAll();
                }
                else
                {
                    // Nếu productid không tồn tại, thêm dữ liệu vào bảng inventory trước
                    query = "INSERT INTO inventory (productid, product, producttype, supplier, amount) " +
                            "VALUES ('" + productid + "', '" + product + "', '" + producttype + "', '" + supplier + "', '" + importamount + "')";
                    fn.setData(query, "Add product to inventory");

                    // Sau đó thêm dữ liệu vào bảng import
                    query = "INSERT INTO import (importinvoiceID, importdate, product, productID, producttype, supplier, importamount, importunitprice, importtotalprice) " +
                            "VALUES ('" + inportinvoiceid + "','" + importdate + "','" + product + "','" + productid + "','" + producttype + "','" + supplier + "','" + importamount + "','" + importunitprice + "','" + importtotalprice + "')";
                    fn.setData(query, "Add product");

                    // Cập nhật dữ liệu trong UserControl của inventory
                    Uc_Inventory inventoryControl = new Uc_Inventory();
                    inventoryControl.UpdateInventoryGrid(productid, product, producttype, supplier, importamount);

                    // Thêm dữ liệu vào bảng Table_1
                    AddToTable1(productid, product, importamount);

                    Import_Load(this, null);
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter complete information", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AddToTable1(Int64 productid, string productName, Int64 amountProduct)
        {
            // Thêm dữ liệu vào bảng Table_1
            query = "INSERT INTO Table_1 (productid, productName, amountProduct) VALUES ('" + productid + "', '" + productName + "', '" + amountProduct + "')";
            fn.setData(query, "Data added to Table_1");

            // Cập nhật UserControl ProductView
            ProductView productViewControl = new ProductView();
            productViewControl.UpdateInventoryGrid(productid, productName, amountProduct);
        }


        public void ClearAll()
        {
            txtInvoiceid.Clear();
            txtproduct.Clear();
            txtsupplier.Clear();
            txtproductid.Clear();
            txtproducttype.Clear();
            txtamount.Clear();
            txtunitprice.Clear();
            txttotal.Clear();
        }


        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtamount.Text != "" && txtInvoiceid.Text != "" && txtproduct.Text != "" && txtproductid.Text != "" && txtproducttype.Text != "" && txtsupplier.Text != "" && txtunitprice.Text != "")
            {
                Int64 inportinvoiceid = int.Parse(txtInvoiceid.Text);
                String importdate = txtdatemake.Text;
                String product = txtproduct.Text;
                Int64 productid = int.Parse(txtproductid.Text);
                String producttype = txtproducttype.Text;
                String supplier = txtsupplier.Text;
                Int64 importamount = int.Parse(txtamount.Text);
                Int64 importunitprice = int.Parse(txtunitprice.Text);
                Int64 importtotalprice = importamount * importunitprice;
                txttotal.Text = importtotalprice.ToString();

                query = "UPDATE import SET importdate = '" + importdate + "', product = '" + product + "', productID = '" + productid + "', producttype = '" + producttype + "', supplier = '" + supplier + "', importamount = '" + importamount + "', importunitprice = '" + importunitprice + "', importtotalprice = '" + importtotalprice + "' WHERE importinvoiceID = '" + inportinvoiceid + "'";
                fn.setData(query, "Update product");

                query = "UPDATE inventory SET product = '" + product + "', producttype = '" + producttype + "', supplier = '" + supplier + "', amount = '" + importamount + "' WHERE productid = '" + productid + "'";
                fn.setData(query, "Update inventory");

                // Refresh the inventory grid
                Uc_Inventory inventoryControl = new Uc_Inventory();
                inventoryControl.UpdateInventoryGrid(productid, product, producttype, supplier, importamount);

                Import_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please enter complete information", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtInvoiceid.Text != "")
            {
                Int64 inportinvoiceid = int.Parse(txtInvoiceid.Text);

                // Lấy productid từ bảng import trước khi xóa
                query = "SELECT productID FROM import WHERE importinvoiceID = '" + inportinvoiceid + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Int64 productid = Int64.Parse(ds.Tables[0].Rows[0]["productID"].ToString());

                    // Xóa dữ liệu từ bảng import
                    query = "DELETE FROM import WHERE importinvoiceID = '" + inportinvoiceid + "'";
                    fn.setData(query, "Delete product from import");

                    // Xóa dữ liệu từ bảng inventory
                    query = "DELETE FROM inventory WHERE productid = '" + productid + "'";
                    fn.setData(query, "Delete product from inventory");

                    // Làm mới giao diện bảng inventory
                    Uc_Inventory inventoryControl = new Uc_Inventory();
                    inventoryControl.UpdateInventoryGrid(productid, "", "", "", 0);

                    Import_Load(this, null);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Product ID not found in import table", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter the Invoice ID", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtInvoiceid.Clear();
            txtproduct.Clear();
            txtsupplier.Clear();
            txtproductid.Clear();
            txtproducttype.Clear();
            txtamount.Clear();
            txtunitprice.Clear();
            txttotal.Clear();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();

            // Truyền thông tin từ các ô văn bản sang các Label trên InvoiceForm
            invoiceForm.lblInvoiceID.Text = txtInvoiceid.Text;
            invoiceForm.lblDate.Text = txtdatemake.Text;
            invoiceForm.lblProduct.Text = txtproduct.Text;
            invoiceForm.lblProductID.Text = txtproductid.Text;
            invoiceForm.lblProductType.Text = txtproducttype.Text;
            invoiceForm.lblSupplier.Text = txtsupplier.Text;
            invoiceForm.lblAmount.Text = txtamount.Text;
            invoiceForm.lblUnitPrice.Text = txtunitprice.Text;
            invoiceForm.lblTotalPrice.Text = txttotal.Text;

            // Hiển thị form mới
            invoiceForm.ShowDialog();
        }
       
    }
}
