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
    public partial class ServiceInvoiceForm : Form
    {
        public ServiceInvoiceForm()
        {
            InitializeComponent();
            print();
        }
        public Label lblInvoiceID;
        public Label lblDate;
        public Label lblProductID;
        public Label lblCustomerID;
        public Label lblCustomer;
        public Label lblType;
        public Label lblDeliveryDate;
        public Label lblStatus;
        public Label lblTotalPrice;

        private void print()
        {
            this.lblInvoiceID = new Label();
            this.lblDate = new Label();
            this.lblProductID = new Label();
            this.lblCustomerID = new Label();
            this.lblCustomer = new Label();
            this.lblType = new Label();
            this.lblDeliveryDate = new Label();
            this.lblStatus = new Label();
            this.lblTotalPrice = new Label();

            // Thêm các Label để hiển thị nhãn
            Label lblInvoiceIDLabel = new Label();
            Label lblDateLabel = new Label();
            Label lblProductIDLabel = new Label();
            Label lblCustomerIDLabel = new Label();
            Label lblCustomerLabel = new Label();
            Label lblTypeLabel = new Label();
            Label lblDeliveryDateLabel = new Label();
            Label lblStatusLabel = new Label();
            Label lblTotalPriceLabel = new Label();

            // Thiết lập vị trí và kích thước cho các Label
            lblInvoiceIDLabel.Text = "Invoice ID:";
            lblInvoiceIDLabel.Location = new Point(10, 10);
            lblInvoiceID.Location = new Point(120, 10);

            lblDateLabel.Text = "Date:";
            lblDateLabel.Location = new Point(10, 40);
            lblDate.Location = new Point(120, 40);

            lblProductIDLabel.Text = "Product ID:";
            lblProductIDLabel.Location = new Point(10, 70);
            lblProductID.Location = new Point(120, 70);

            lblCustomerIDLabel.Text = "Customer ID:";
            lblCustomerIDLabel.Location = new Point(10, 100);
            lblCustomerID.Location = new Point(120, 100);

            lblCustomerLabel.Text = "Customer:";
            lblCustomerLabel.Location = new Point(10, 130);
            lblCustomer.Location = new Point(120, 130);

            lblTypeLabel.Text = "Type:";
            lblTypeLabel.Location = new Point(10, 160);
            lblType.Location = new Point(120, 160);

            lblDeliveryDateLabel.Text = "Delivery Date:";
            lblDeliveryDateLabel.Location = new Point(10, 190);
            lblDeliveryDate.Location = new Point(120, 190);

            lblStatusLabel.Text = "Status:";
            lblStatusLabel.Location = new Point(10, 220);
            lblStatus.Location = new Point(120, 220);

            lblTotalPriceLabel.Text = "Total Price:";
            lblTotalPriceLabel.Location = new Point(10, 250);
            lblTotalPrice.Location = new Point(120, 250);

            // Thêm các Label vào form
            this.Controls.Add(lblInvoiceIDLabel);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(lblDateLabel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(lblProductIDLabel);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(lblCustomerIDLabel);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(lblCustomerLabel);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(lblTypeLabel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(lblDeliveryDateLabel);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(lblStatusLabel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(lblTotalPriceLabel);
            this.Controls.Add(this.lblTotalPrice);

            // Thiết lập các thuộc tính khác của form
            this.Text = "Service invoice";
            this.Size = new Size(300, 400);
        }
    }
}
