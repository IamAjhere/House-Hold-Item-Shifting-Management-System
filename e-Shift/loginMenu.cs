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
using CustomControls.RJControls;

namespace e_Shift
{
    public partial class loginMenu : Form
    {
        public static loginMenu loginmenuInstance;

        //create form objects
        userMenu userform = new userMenu();
        adminLogin adminform = new adminLogin();

        public loginMenu()
        {
            InitializeComponent();
            loginmenuInstance = this;
        }
        //form load fucntion to load inside panel
        private void formLoad(Form form)
        {
            pnl_form.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            pnl_form.Controls.Add(form);
            form.Show();
        }
        private void loginMenu_Load(object sender, EventArgs e)
        {
            formLoad(adminform);
        }

        //form hide when logged in
        public void hidemenu(Form form)
        {

            form.Show();
        }
        private void btn_adminlogin_Click(object sender, EventArgs e)
        {
            //Load Admin Form
            
            formLoad(adminform);

            //UI
            btn_userlogin.FlatAppearance.BorderColor = Color.FromArgb(79, 88, 111);
            btn_adminlogin.FlatAppearance.BorderColor = Color.FromArgb(247, 131, 97);
        }

        private void btn_userlogin_Click(object sender, EventArgs e)
        {
            //Load User Form
            
            formLoad(userform);

            //UI
            btn_adminlogin.FlatAppearance.BorderColor = Color.FromArgb(79, 88, 111);
            btn_userlogin.FlatAppearance.BorderColor = Color.FromArgb(247, 131, 97);
        }

        //show Password Function
        public void showpassword(CheckBox chk_showpassword, RJTextBox txt_password)
        {
            if (chk_showpassword.Checked)
            {
                txt_password.PasswordChar = false;
            }
            else
            {
                txt_password.PasswordChar = true;
            }
        }


    }
}
