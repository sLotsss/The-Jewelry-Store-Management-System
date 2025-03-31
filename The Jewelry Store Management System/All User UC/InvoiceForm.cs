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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            Print();
        }

        public Label lblInvoiceID;
        public Label lblDate;
        public Label lblProduct;
        public Label lblProductID;
        public Label lblProductType;
        public Label lblSupplier;
        public Label lblAmount;
        public Label lblUnitPrice;
        public Label lblTotalPrice;

        private void Print()
        {
            this.lblInvoiceID = new Label();
            this.lblDate = new Label();
            this.lblProduct = new Label();
            this.lblProductID = new Label();
            this.lblProductType = new Label();
            this.lblSupplier = new Label();
            this.lblAmount = new Label();
            this.lblUnitPrice = new Label();
            this.lblTotalPrice = new Label();

            // Thêm các Label để hiển thị nhãn
            Label lblInvoiceIDLabel = new Label();
            Label lblDateLabel = new Label();
            Label lblProductLabel = new Label();
            Label lblProductIDLabel = new Label();
            Label lblProductTypeLabel = new Label();
            Label lblSupplierLabel = new Label();
            Label lblAmountLabel = new Label();
            Label lblUnitPriceLabel = new Label();
            Label lblTotalPriceLabel = new Label();

            // Thiết lập vị trí và kích thước cho các Label
            lblInvoiceIDLabel.Text = "Invoice ID:";
            lblInvoiceIDLabel.Location = new Point(10, 10);
            lblInvoiceID.Location = new Point(120, 10);

            lblDateLabel.Text = "Date:";
            lblDateLabel.Location = new Point(10, 40);
            lblDate.Location = new Point(120, 40);

            lblProductLabel.Text = "Product:";
            lblProductLabel.Location = new Point(10, 70);
            lblProduct.Location = new Point(120, 70);

            lblProductIDLabel.Text = "Product ID:";
            lblProductIDLabel.Location = new Point(10, 100);
            lblProductID.Location = new Point(120, 100);

            lblProductTypeLabel.Text = "Product Type:";
            lblProductTypeLabel.Location = new Point(10, 130);
            lblProductType.Location = new Point(120, 130);

            lblSupplierLabel.Text = "Supplier:";
            lblSupplierLabel.Location = new Point(10, 160);
            lblSupplier.Location = new Point(120, 160);

            lblAmountLabel.Text = "Amount:";
            lblAmountLabel.Location = new Point(10, 190);
            lblAmount.Location = new Point(120, 190);

            lblUnitPriceLabel.Text = "Unit Price:";
            lblUnitPriceLabel.Location = new Point(10, 220);
            lblUnitPrice.Location = new Point(120, 220);

            lblTotalPriceLabel.Text = "Total Price:";
            lblTotalPriceLabel.Location = new Point(10, 250);
            lblTotalPrice.Location = new Point(120, 250);

            // Thêm các Label vào form
            this.Controls.Add(lblInvoiceIDLabel);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(lblDateLabel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(lblProductLabel);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(lblProductIDLabel);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(lblProductTypeLabel);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(lblSupplierLabel);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(lblAmountLabel);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(lblUnitPriceLabel);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(lblTotalPriceLabel);
            this.Controls.Add(this.lblTotalPrice);

            // Thiết lập các thuộc tính khác của form
            this.Text = "Import invoice";
            this.Size = new Size(300, 400);
        }
    }


}
