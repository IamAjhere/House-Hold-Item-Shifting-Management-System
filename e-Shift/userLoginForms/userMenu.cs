using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Shift.userLoginForms;

namespace e_Shift.userLogin
{
    public partial class userMenu : Form
    {
        public static userMenu usermenuInstance;
        //import form objects
        UloginForm uloginForm = new UloginForm();
        UregisterForm uregisterForm = new UregisterForm();
        userForgot userForgot = new userForgot();
        public userMenu()
        {
            InitializeComponent();
            usermenuInstance = this;
        }
        private void formLoad(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            pnl_form.Controls.Add(form);
            form.Show();
        }
        //load user register menu
        public void loadloginform()
        {
            pnl_form.Controls.Remove(userForgot);
            pnl_form.Controls.Remove(uregisterForm);
            formLoad(uloginForm);
        }
        //loadsignup form
        public void loadSignup()
        {
            
            pnl_form.Controls.Remove(uloginForm);
            formLoad(uregisterForm);
        }
        //load forgot menu
        public void loadForgot()
        {
            pnl_form.Controls.Remove(uloginForm);
            formLoad(userForgot);
        }
        private void userMenu_Load(object sender, EventArgs e)
        {
            formLoad(uloginForm);
        }


    }
}
