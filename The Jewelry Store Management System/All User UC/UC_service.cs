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
    public partial class UC_service : UserControl
    {
        function fn = new function();
        String query;
        public UC_service()
        {
            InitializeComponent();
        }

        private void UC_service_Load(object sender, EventArgs e)
        {
            query = "Select * from service ";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtinvoiceID.Text != "" && txtproductid.Text != "" && txtcustomerID.Text != "" && txtcustomer.Text != "" && txttype.Text != "" && txtcombostatus.Text != "" && txttotal.Text != "")
            {
                Int64 serviceinvoiceid = int.Parse(txtinvoiceID.Text);
                String daymake = txtdatemake.Text;
                String productid = txtproductid.Text;
                String customerid = txtcustomerID.Text;
                String customer = txtcustomer.Text;
                String type = txttype.Text;
                String daydelivery = txtdeliverday.Text;
                String status = txtcombostatus.Text;
                Int64 price = int.Parse(txttotal.Text);

                query = "SELECT customerID FROM Customer WHERE customerID = '" + customerid + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Nếu productid tồn tại, thêm dữ liệu vào bảng import
                    query = "insert into service (serviceinvoiceID, datemake, productID, customerid, customer, typeservice, daydelivery, Status, servicetotalprice) values ('" + serviceinvoiceid + "','" + daymake + "','" + productid + "','" + customerid + "','" + customer + "','" + type + "','" + daydelivery + "','" + status + "','" + price + "')";
                    fn.setData(query, "Add service");

                    // Gọi phương thức UpdateInventoryGrid từ User Control của inventory
                    UC_customer customerControl = new UC_customer();
                    customerControl.UpdateCustomerGrid(customerid, customer, productid, type);


                    UC_service_Load(this, null);
                    ClearAll();
                } 
                else
                {
                    // Nếu productid không tồn tại, thêm dữ liệu vào bảng inventory trước
                    query = "INSERT INTO Customer (customerID, customer, productID, service) VALUES ('" + customerid + "', '" + customer + "', '" + productid + "', '" + type + "')";
                    fn.setData(query, "Add customer information");

                    // Sau đó thêm dữ liệu vào bảng import
                    query = "insert into service (serviceinvoiceID, datemake, productID, customerid, customer, typeservice, daydelivery, Status, servicetotalprice) values ('" + serviceinvoiceid + "','" + daymake + "','" + productid + "','" + customerid + "','" + customer + "','" + type + "','" + daydelivery + "','" + status + "','" + price + "')";
                    fn.setData(query, "Add service");

                    // Gọi phương thức UpdateInventoryGrid từ User Control của inventory
                    UC_customer customerControl = new UC_customer();
                    customerControl.UpdateCustomerGrid(customerid, customer, productid, type);


                    UC_service_Load(this, null);
                    ClearAll();
                }    
            }
            else
            {
                MessageBox.Show("Please enter complete information", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearAll()
        {
            txtinvoiceID.Clear();
            txtproductid.Clear();
            txtcustomerID.Clear();
            txtcustomer.Clear();
            txttype.Clear();
            txtcombostatus.SelectedIndex= -1;
            txttotal.Clear();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (txtinvoiceID.Text != "")
            {
                Int64 serviceinvoiceid = int.Parse(txtinvoiceID.Text);
                query = "DELETE FROM service WHERE serviceinvoiceID = '" + serviceinvoiceid + "'";
                fn.setData(query, "Delete service");
                UC_service_Load(this, null);
                ClearAll();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtinvoiceID.Clear();
            txtproductid.Clear();
            txtcustomerID.Clear();
            txtcustomer.Clear();
            txttype.Clear();
            txtcombostatus.SelectedIndex = -1;
            txttotal.Clear();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

            ServiceInvoiceForm serviceInvoiceForm = new ServiceInvoiceForm();
            // Truyền thông tin từ các ô văn bản sang các Label trên ServiceInvoiceForm
            serviceInvoiceForm.lblInvoiceID.Text = txtinvoiceID.Text;
            serviceInvoiceForm.lblDate.Text = txtdatemake.Text;
            serviceInvoiceForm.lblProductID.Text = txtproductid.Text;
            serviceInvoiceForm.lblCustomerID.Text = txtcustomerID.Text;
            serviceInvoiceForm.lblCustomer.Text = txtcustomer.Text;
            serviceInvoiceForm.lblType.Text = txttype.Text;
            serviceInvoiceForm.lblDeliveryDate.Text = txtdeliverday.Text;
            serviceInvoiceForm.lblStatus.Text = txtcombostatus.Text;
            serviceInvoiceForm.lblTotalPrice.Text = txttotal.Text;

            // Hiển thị form mới
            serviceInvoiceForm.ShowDialog();
        }
    }
}
