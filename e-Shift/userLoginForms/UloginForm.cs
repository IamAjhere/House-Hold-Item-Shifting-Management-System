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
using System.Data.SqlClient;
using e_Shift.customer;

namespace e_Shift
{
    public partial class UloginForm : Form 
    {
        DatabaseClass dbClass = new DatabaseClass();
        public static string userID = "1";
        public UloginForm()
        {
            InitializeComponent();
        }

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            loginMenu.loginmenuInstance.showpassword(chk_showpassword, txt_password);
        }
        
        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            userMenu.usermenuInstance.loadSignup();

        }

        private void btn_usersubmit_Click(object sender, EventArgs e)
        {
            //store field in variables
            string username = txt_username.Texts;
            string password = txt_password.Texts;

            //validations
            if (username == "" && password == "")
            {
                lbl_pwdError.Text = "Insert Password";
                lbl_userError.Text = "Insert Username";
            }
            else if (username == "")
            {
                lbl_userError.Text = "Insert Username";
            }
            else if (password == "")
            {
                lbl_pwdError.Text = "Insert Password";
            }
            else
            {
                // database query and check if user available
                string query = "SELECT * FROM userTable WHERE username ='" + username + "' AND password='" + password + "'";
                var reader = dbClass.readDatathroughReader(query);
                //if user and password match Log in to dashboard
                if (reader.HasRows)
                {
                    while (reader.Read()) { userID = reader["id"].ToString(); }
                    
                    userDashboard uDash = new userDashboard();
                    loginMenu.loginmenuInstance.hidemenu(uDash);
                    reader.Close();
                    dbClass.closeConn();

                }
                else
                {
                    reader.Close();
                    dbClass.closeConn();
                    link_forgot.Visible = true;
                    lbl_pwdError.Text = "Invalid Username or Password";
                }
            }
        }

        private void link_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userMenu.usermenuInstance.loadForgot();
        }

        private void UloginForm_Load(object sender, EventArgs e)
        {
            link_forgot.Visible = false;
        }
    }
}
