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
using System.Text.RegularExpressions;
namespace e_Shift.userLoginForms
{
    public partial class userForgot : Form
    {
        DatabaseClass objdb = new DatabaseClass();

        public userForgot()
        {
            InitializeComponent();
        }

        private void userForgot_Load(object sender, EventArgs e)
        {
            pnl_passwordreset.Visible = false;

        }

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            loginMenu.loginmenuInstance.showpassword(chk_showpassword, txt_password);
        }

        private void link_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userMenu.usermenuInstance.loadloginform();
        }
        //store textbox in variable
        string name;
        string username;
        private void btn_chkUser_Click(object sender, EventArgs e)
        {
            //set variable
            name = txt_fullname.Texts;
            username = txt_username.Texts;
            
            lbl_Error.Text = "asdf";
            if(name == "" || username == "")
            {
                lbl_Error.Text = "please fill the fields";
            }

           else
            {
                //validate the user
                string query = "SELECT * FROM userTable WHERE fullname= '" + name + "' AND username= '" + username + "'";
                var reader = objdb.readDatathroughReader(query);
                if (reader.HasRows)
                {
                    lbl_Error.Text = "";
                    txt_fullname.Enabled = false;
                    txt_username.Enabled = false;
                    btn_chkUser.Visible = false;
                    pnl_passwordreset.Visible = true;
                    reader.Close();
                    objdb.closeConn();
                }
                else
                {
                    reader.Close();
                    lbl_Error.Text = "Invalid User";
                }
            }
        }

        private void btn_passwordrst_Click(object sender, EventArgs e)
        {
            string password = txt_password.Texts;
            var hasNumber = new Regex(@"[0-9]+");
            if (password == "")
            {
                lbl_Error.Text = "Please Enter New Password";
            }
            else if (!hasNumber.IsMatch(password))
            {
                lbl_Error.Text = "At least one numeric value";
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("UPDATE userTable SET password=@password WHERE username=@username");

                insertcommand.Parameters.AddWithValue("@password",password);
                insertcommand.Parameters.AddWithValue("@username", username);

                int row = objdb.executeQuery(insertcommand);

                if (row == 1)
                {
                    string NAME = name.ToUpper();
                    MessageBox.Show(NAME + " - Password Reset Success");
                    userMenu.usermenuInstance.loadloginform();
                    fieldReset();


                }



            }

        }
        public void fieldReset()
        {
            lbl_Error.Text = "";
            txt_fullname.Texts = "";
            txt_username.Texts = "";
            txt_password.Texts = "";
            txt_fullname.Enabled = true;
            txt_username.Enabled = true;
            btn_chkUser.Visible = true;
            pnl_passwordreset.Visible = false;
        }
    }
}
