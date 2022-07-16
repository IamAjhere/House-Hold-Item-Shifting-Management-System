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
using System.Text.RegularExpressions;

namespace e_Shift.userLogin
{
    public partial class UregisterForm : Form
    {
        DatabaseClass objdb = new DatabaseClass();

        public UregisterForm()
        {
            InitializeComponent();
        }
        private void UregisterForm_Load(object sender, EventArgs e)
        {


        }
        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            loginMenu.loginmenuInstance.showpassword(chk_showpassword, txt_password);
        }

        private void link_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            userMenu.usermenuInstance.loadloginform();
        }

        private void btn_userregister_Click(object sender, EventArgs e)
        {

            //store fields in variable
            string fullname = txt_fullname.Texts;
            string username = txt_username.Texts;
            string password = txt_password.Texts;
            string birthday = date_userbirthday.Text;

            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            //Validations for user registrations
            if (fullname == "" || username =="" || password == "" )
            {
                lbl_formError.Text = "*Please fill all fields";
            }
            else if (hasNumber.IsMatch(fullname) || hasSymbols.IsMatch(fullname))
            {
                lbl_nameError.Text = "Use only Alphabetic character ";
            }
            else if (hasSymbols.IsMatch(username))
            {
                lbl_userError.Text = "Use only Alphanumeric character ";
            }
            else if (!hasNumber.IsMatch(password))
            {
                lbl_pwdError.Text = "At least one numeric value";
            }
            
            
            else
            {
                try
                {
                    //check if username is unique
                    string query = "SELECT username From userTable Where username = '" + username + "' ";

                    var reader = objdb.readDatathroughReader(query);

                    if (reader.HasRows) {
                        lbl_userError.Text = "Username already exsit";
                    }
                    else
                    {
                        reader.Close();
                        // insert data into database
                        SqlCommand insertcommand = new SqlCommand(
                            "INSERT INTO userTable(fullname,password,birthday,username) VALUES(@fullname,@password,@birthday,@username)"
                            );
                        insertcommand.Parameters.AddWithValue("@fullname", fullname);
                        insertcommand.Parameters.AddWithValue("@password", password);
                        insertcommand.Parameters.AddWithValue("@birthday", birthday);
                        insertcommand.Parameters.AddWithValue("@username", username);

                        int row = objdb.executeQuery(insertcommand);

                        if (row == 1)
                        {
                            MessageBox.Show("Account Created Successfully!");
                            userMenu.usermenuInstance.loadloginform();
                            resetFields();
                            objdb.closeConn();
                        }
                    }
                     
                    
                }
                catch (Exception)
                {
                    objdb.closeConn();
                    MessageBox.Show("There was an error please try again.");
                }


                
            }


        }
       
        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetFields();

        }

        private void resetFields()
        {
            lbl_formError.Text = 
            lbl_nameError.Text = 
            lbl_pwdError.Text = 
            lbl_userError.Text =
            txt_fullname.Texts =
            txt_password.Texts =
            txt_username.Texts = string.Empty;
        }

    }
}
