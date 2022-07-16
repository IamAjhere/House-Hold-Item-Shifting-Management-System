using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using e_Shift.admin;
namespace e_Shift
{
    public partial class adminLogin : Form
    {
        DatabaseClass dbClass = new DatabaseClass();
        
        public adminLogin()
        {
            InitializeComponent();

        }
        
        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            //call to show password fuction in loginmenu
            loginMenu.loginmenuInstance.showpassword(chk_showpassword, txt_password);
        }

        private void btn_adminsubmit_Click(object sender, EventArgs e)
        {
            // store text box text in variables
            string uName = txt_username.Texts;
            string uPassword = txt_password.Texts;

            //validations
            if (uName == "" && uPassword == "")//if both fields null
            {
                lbl_unameError.Text = "Please insert Username";
                lbl_pwdError.Text = "Please insert Password";
            }
            else if (uName == "")//if username is null
            {
                lbl_pwdError.Text = "";
                lbl_unameError.Text = "Please insert Username";
            }
            else if (uPassword == "")//if password is null
            {
                lbl_unameError.Text = "";
                lbl_pwdError.Text = "Please insert Password";
            }
            else
            {
                //sql query saved in a string
               string query = "SELECT * FROM adminTable BINARY WHERE username ='" + uName+"' AND password='"+uPassword+"'";

               //use sqlreader to check if user is valid and save it in variable
               var reader =  dbClass.readDatathroughReader(query);

                //if user and password match Log in to dashboard
                if (reader.HasRows)
                {

                    //MessageBox.Show("Admin Loggin Successfull");
                    reader.Close();
                    dbClass.closeConn();
                    adminDashboard AdminDashboard = new adminDashboard();
                    loginMenu.loginmenuInstance.hidemenu(AdminDashboard);
                    

                }
                else
                {
                    reader.Close();
                    dbClass.closeConn();
                    lbl_pwdError.Text = "Invalid Username or Password";
                }


            }
        }
    }
    
}
