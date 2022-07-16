using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace e_Shift.customer
{
    public partial class profileSettings : Form
    {
        DatabaseClass objdb = new DatabaseClass();
        private string userid = UloginForm.userID;
        string Checkusername = "";
        public profileSettings()
        {
            InitializeComponent();
        }
        
        private void profileSettings_Load(object sender, EventArgs e)
        {
            userDashboard.userinstance.changeheader("Settings");
            string q = "SELECT * FROM userTable WHERE id = '" + userid + "'";
            DataTable dt = new DataTable();
            objdb.readDatathroughAdapter(q, dt);
            objdb.closeConn();

            if (dt.Rows.Count> 0)
            {
               string fullname = (from DataRow dr in dt.Rows
                                  select (string)dr["fullname"]).First();
                var date = (from DataRow dr in dt.Rows
                            select (DateTime)dr["birthday"]).First();
                Checkusername = (from DataRow dr in dt.Rows
                                   select (string)dr["username"]).First();
                string password = (from DataRow dr in dt.Rows
                                   select (string)dr["password"]).First();

                txt_FullName.Texts = fullname.Trim();
                date_userbirthday.Text = date.ToString();
                txt_username.Texts = Checkusername.Trim();
                txt_password.Texts = password.Trim();

            }

        }

        private void btn_updatesettings_Click(object sender, EventArgs e)
        {

            //store fields in variable
            string fullname = txt_FullName.Texts;
            string username = txt_username.Texts;
            string password = txt_password.Texts;
            string birthday = date_userbirthday.Text;

            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            //Validations for user registrations
            if (fullname == "" || username == "" || password == "")
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
                    if(username != Checkusername)
                    {
                        //check if username is unique if its changed
                        string query = "SELECT username From userTable Where username = '" + username + "' ";

                        var reader = objdb.readDatathroughReader(query);

                        if (reader.HasRows)
                        {
                            lbl_userError.Text = "Username already exsit";
                            reader.Close();
                            return;
                        }
                        reader.Close();
                    }

                    else
                    {
                        // insert data into database
                        SqlCommand insertcommand = new SqlCommand(
                            "UPDATE userTable SET fullname=@fullname,password =@password,birthday=@birthday,username=@username " +
                            " WHERE id = '"+userid+"' "
                            );
                        insertcommand.Parameters.AddWithValue("@fullname", fullname);
                        insertcommand.Parameters.AddWithValue("@password", password);
                        insertcommand.Parameters.AddWithValue("@birthday", birthday);
                        insertcommand.Parameters.AddWithValue("@username", username);

                        int row = objdb.executeQuery(insertcommand);

                        if (row == 1)
                        {
                            MessageBox.Show("Account Updated Successfully!");
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

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            loginMenu.loginmenuInstance.showpassword(chk_showpassword, txt_password);
        }
    }
}
