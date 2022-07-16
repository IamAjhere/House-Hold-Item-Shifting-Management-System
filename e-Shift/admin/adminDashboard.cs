using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift.admin
{
    public partial class adminDashboard : Form
    {
        public static adminDashboard admininstance;
        public adminDashboard()
        {
            InitializeComponent();
            admininstance = this;
        }
        //load form function
        private void formLoad (Form form)
        {
            pnl_form.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            pnl_form.Controls.Add(form);
            form.Show();
            
        }
        //logout fucntion
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        //load product form on click
        private void btn_products_Click(object sender, EventArgs e)
        {

            productspage ProductsPage = new productspage();
            formLoad(ProductsPage);

        }
        //load transport form on click
        private  void btn_transport_Click(object sender, EventArgs e)
        {
            transportPage transportpage = new transportPage();
            formLoad(transportpage);
            
        }
        //load homepage
        private void btn_home_Click(object sender, EventArgs e)
        {
            homePage homePage = new homePage();
            formLoad(homePage);

        }
        //load all jobs form
        private void btn_allJobs_Click(object sender, EventArgs e)
        {
            allOrders allorders = new allOrders();
            formLoad(allorders);
            
        }
        //load all users
        private void btn_users_Click(object sender, EventArgs e)
        {
            allUsers allusers = new allUsers();
            formLoad(allusers);
        }
        //homepage when programe loads
        private void adminDashboard_Load(object sender, EventArgs e)
        {
            homePage homePage = new homePage();
            formLoad(homePage);
        }
 
        //change header of the page
        public void changeheader(string header)
        {
            lbl_header.Text = header;
        }
    }
}
