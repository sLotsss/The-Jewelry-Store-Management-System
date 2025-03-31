using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Jewelry_Store_Management_System.All_User_UC;

namespace The_Jewelry_Store_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            import1.Visible = true;
            import1.BringToFront();
        }

        private void btsale_Click(object sender, EventArgs e)
        {
            uC_sale1.Visible = true;
            uC_sale1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btinventory_Click(object sender, EventArgs e)
        {
           uc_Inventory1.Visible = true;
            uc_Inventory1.BringToFront();
        }

        private void btservice_Click(object sender, EventArgs e)
        {
            uC_service1.Visible = true;
            uC_service1.BringToFront();
        }

        private void btcustomer_Click(object sender, EventArgs e)
        {
            uC_customer1.Visible = true;
            uC_customer1.BringToFront();
        }

        private void btstaff_Click(object sender, EventArgs e)
        {
            productView1.Visible = true;
            productView1.BringToFront();
        }
    }
}
