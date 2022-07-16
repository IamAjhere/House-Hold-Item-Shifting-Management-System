using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Shift.userLogin;

namespace e_Shift.customer
{
    public partial class userDashboard : Form
    {
        public static userDashboard userinstance;
       
        public userDashboard()
        {
            InitializeComponent();
            userinstance = this;
        }
        //load form function
        private void formLoad(Form form)
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
        //load create new jobs form on click
        private void btn_newjob_Click(object sender, EventArgs e)
        {
            newJob NewJob = new newJob();
            formLoad(NewJob);
        }
        //load job history form on click
        private void btn_jobhistory_Click(object sender, EventArgs e)
        {
            jobHistory jobHistory = new jobHistory();
            formLoad(jobHistory);
        }
        
        public void changeheader(string header)
        {
            lbl_header.Text = header;
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            newJob NewJob = new newJob();
            formLoad(NewJob);
        }

        private void btn_profileSettings_Click(object sender, EventArgs e)
        {
            profileSettings profileSettings = new profileSettings();
            formLoad(profileSettings);
        }
    }
}
