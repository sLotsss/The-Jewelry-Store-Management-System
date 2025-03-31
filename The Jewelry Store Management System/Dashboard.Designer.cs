namespace The_Jewelry_Store_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btImport = new System.Windows.Forms.Button();
            this.btinventory = new System.Windows.Forms.Button();
            this.btsale = new System.Windows.Forms.Button();
            this.btservice = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btcustomer = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btstaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_customer1 = new The_Jewelry_Store_Management_System.All_User_UC.UC_customer();
            this.uC_service1 = new The_Jewelry_Store_Management_System.All_User_UC.UC_service();
            this.uc_Inventory1 = new The_Jewelry_Store_Management_System.All_User_UC.Uc_Inventory();
            this.uC_sale1 = new The_Jewelry_Store_Management_System.All_User_UC.UC_sale();
            this.import1 = new The_Jewelry_Store_Management_System.All_User_UC.Import();
            this.productView1 = new The_Jewelry_Store_Management_System.All_User_UC.ProductView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 1209);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 1202);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btImport);
            this.tabPage1.Controls.Add(this.btinventory);
            this.tabPage1.Controls.Add(this.btsale);
            this.tabPage1.Controls.Add(this.btservice);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(363, 1169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(19, 208);
            this.btImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(316, 122);
            this.btImport.TabIndex = 1;
            this.btImport.Text = "Import invoice";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btinventory
            // 
            this.btinventory.Location = new System.Drawing.Point(19, 28);
            this.btinventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btinventory.Name = "btinventory";
            this.btinventory.Size = new System.Drawing.Size(316, 122);
            this.btinventory.TabIndex = 0;
            this.btinventory.Text = "Inventory";
            this.btinventory.UseVisualStyleBackColor = true;
            this.btinventory.Click += new System.EventHandler(this.btinventory_Click);
            // 
            // btsale
            // 
            this.btsale.Location = new System.Drawing.Point(19, 398);
            this.btsale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btsale.Name = "btsale";
            this.btsale.Size = new System.Drawing.Size(316, 122);
            this.btsale.TabIndex = 2;
            this.btsale.Text = "Sales invoice";
            this.btsale.UseVisualStyleBackColor = true;
            this.btsale.Click += new System.EventHandler(this.btsale_Click);
            // 
            // btservice
            // 
            this.btservice.Location = new System.Drawing.Point(19, 594);
            this.btservice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btservice.Name = "btservice";
            this.btservice.Size = new System.Drawing.Size(316, 122);
            this.btservice.TabIndex = 3;
            this.btservice.Text = "Service invoice";
            this.btservice.UseVisualStyleBackColor = true;
            this.btservice.Click += new System.EventHandler(this.btservice_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btcustomer);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(363, 1169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btcustomer
            // 
            this.btcustomer.Location = new System.Drawing.Point(7, 26);
            this.btcustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcustomer.Name = "btcustomer";
            this.btcustomer.Size = new System.Drawing.Size(343, 122);
            this.btcustomer.TabIndex = 5;
            this.btcustomer.Text = "Customer information";
            this.btcustomer.UseVisualStyleBackColor = true;
            this.btcustomer.Click += new System.EventHandler(this.btcustomer_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btstaff);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(363, 1169);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btstaff
            // 
            this.btstaff.Location = new System.Drawing.Point(7, 8);
            this.btstaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btstaff.Name = "btstaff";
            this.btstaff.Size = new System.Drawing.Size(343, 122);
            this.btstaff.TabIndex = 4;
            this.btstaff.Text = "View product";
            this.btstaff.UseVisualStyleBackColor = true;
            this.btstaff.Click += new System.EventHandler(this.btstaff_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.productView1);
            this.panel2.Controls.Add(this.uC_customer1);
            this.panel2.Controls.Add(this.uC_service1);
            this.panel2.Controls.Add(this.uc_Inventory1);
            this.panel2.Controls.Add(this.uC_sale1);
            this.panel2.Controls.Add(this.import1);
            this.panel2.Location = new System.Drawing.Point(416, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1710, 1209);
            this.panel2.TabIndex = 1;
            // 
            // uC_customer1
            // 
            this.uC_customer1.Location = new System.Drawing.Point(-2, -1);
            this.uC_customer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_customer1.Name = "uC_customer1";
            this.uC_customer1.Size = new System.Drawing.Size(1710, 1210);
            this.uC_customer1.TabIndex = 4;
            // 
            // uC_service1
            // 
            this.uC_service1.Location = new System.Drawing.Point(-2, -1);
            this.uC_service1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_service1.Name = "uC_service1";
            this.uC_service1.Size = new System.Drawing.Size(1710, 1210);
            this.uC_service1.TabIndex = 3;
            // 
            // uc_Inventory1
            // 
            this.uc_Inventory1.Location = new System.Drawing.Point(-2, 4);
            this.uc_Inventory1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uc_Inventory1.Name = "uc_Inventory1";
            this.uc_Inventory1.Size = new System.Drawing.Size(1710, 1210);
            this.uc_Inventory1.TabIndex = 2;
            // 
            // uC_sale1
            // 
            this.uC_sale1.Location = new System.Drawing.Point(-2, -2);
            this.uC_sale1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_sale1.Name = "uC_sale1";
            this.uC_sale1.Size = new System.Drawing.Size(1710, 1210);
            this.uC_sale1.TabIndex = 1;
            // 
            // import1
            // 
            this.import1.Location = new System.Drawing.Point(-2, -2);
            this.import1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.import1.Name = "import1";
            this.import1.Size = new System.Drawing.Size(1710, 1210);
            this.import1.TabIndex = 0;
            // 
            // productView1
            // 
            this.productView1.Location = new System.Drawing.Point(3, -3);
            this.productView1.Name = "productView1";
            this.productView1.Size = new System.Drawing.Size(1710, 1210);
            this.productView1.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btinventory;
        private System.Windows.Forms.Button btcustomer;
        private System.Windows.Forms.Button btstaff;
        private System.Windows.Forms.Button btservice;
        private System.Windows.Forms.Button btsale;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Panel panel2;
        private All_User_UC.Import import1;
        private All_User_UC.UC_sale uC_sale1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private All_User_UC.Uc_Inventory uc_Inventory1;
        private All_User_UC.UC_service uC_service1;
        private All_User_UC.UC_customer uC_customer1;
        private All_User_UC.ProductView productView1;
    }
}