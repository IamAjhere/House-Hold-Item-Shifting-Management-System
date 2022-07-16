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

namespace e_Shift.admin
{
    public partial class allUsers : Form
    {
        DatabaseClass objdb = new DatabaseClass();
        string adminq = "SELECT * FROM adminTable";
        string userq = "SELECT id, fullname, birthday FROM userTable";

        public allUsers()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("Admins");
            dt_adminTable.Visible = true;
            dt_usersTable.Visible = false;
            btn_addAdmin.Visible = true;
            objdb.showData(adminq,dt_adminTable);
        }

        private void allUsers_Load(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("Admins");
            objdb.showData(adminq, dt_adminTable);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("Users");
            pnl_admin.Visible = false;
            dt_adminTable.Visible = false;
            btn_addAdmin.Visible = false;
            dt_usersTable.Visible = true;
            objdb.showData(userq, dt_usersTable);

        }

        private void dt_usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = dt_usersTable.Rows[e.RowIndex];
            int userid = int.Parse(row.Cells[1].Value.ToString());

            if(e.ColumnIndex == 0)
            {
                bool delete = MessageBox.Show("Do you want to delete this user?", "User Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes;

                if (delete)
                {
                    SqlCommand deleteuser = new SqlCommand("DELETE FROM userTable WHERE id = '"+userid+"'");
                    objdb.executeQuery(deleteuser);
                    MessageBox.Show("User - "+userid+" is Deleted");
                    objdb.showData(userq, dt_usersTable);
                    objdb.closeConn();
                }

            }
            
        }

        private void btn_addAdmin_Click(object sender, EventArgs e)
        {
            pnl_admin.Visible = true;
        }

        private void btn_addAdminpanel_Click(object sender, EventArgs e)
        {
            string id = lbl_id.Text;
            string username = txt_userName.Texts.Trim();
            string password = txt_password.Texts.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Please Fill Both Fields");
                return;
            }
            if (btn_addAdminpanel.Text == "Add Admin")
            {
                
                SqlCommand newadmin = new SqlCommand("INSERT INTO adminTable(username,password)" +
                    " VALUES(@username,@password)");
                newadmin.Parameters.AddWithValue("@username", username);
                newadmin.Parameters.AddWithValue("@password", password);
                int row = objdb.executeQuery(newadmin);
                if (row > 0)
                {
                    MessageBox.Show("New Admin "+username+ " is Added");
                    txt_password.Texts = "";
                    txt_userName.Texts = "";
                    objdb.showData(adminq, dt_adminTable);
                }
                objdb.closeConn();
                return;
            }
           if(btn_addAdminpanel.Text == "Update Admin")
            {
                SqlCommand updateadmin = new SqlCommand("UPDATE adminTable SET username = @username , password = @password WHERE id = '"+id+"'");
                updateadmin.Parameters.AddWithValue("@username", username);
                updateadmin.Parameters.AddWithValue("@password", password);
                int row = objdb.executeQuery(updateadmin);
                if (row > 0)
                {
                    MessageBox.Show("Admin " + id + " is Updated");
                    txt_password.Texts = "";
                    txt_userName.Texts = "";
                    lbl_id.Text = "";
                    btn_addAdminpanel.Text = "Add Admin";
                    pnl_admin.Visible = false;
                    objdb.showData(adminq, dt_adminTable);
                }
                objdb.closeConn();
                return;
            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_admin.Visible = false;
            btn_addAdminpanel.Text = "Add Admin";
            txt_password.Texts = "";
            txt_userName.Texts = "";
        }

        private void dt_adminTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = dt_adminTable.Rows[e.RowIndex];
            int adminid = int.Parse(row.Cells[2].Value.ToString().Trim());
            string adminuname = row.Cells[3].Value.ToString().Trim();
            string password = row.Cells[4].Value.ToString().Trim();

            if (e.ColumnIndex == 0)
            {
                bool update = MessageBox.Show("Do You want to update?", "Update Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (update)
                {
                    txt_userName.Texts = adminuname;
                    txt_password.Texts = password;
                    btn_addAdminpanel.Text = "Update Admin";
                    lbl_id.Text = adminid.ToString();
                    pnl_admin.Visible = true;
                }
            }
            if (e.ColumnIndex == 1)
            {
                bool delete = MessageBox.Show("Do you want to delete this admin?", "Delete Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (delete)
                {
                    SqlCommand deleteadmin = new SqlCommand("DELETE FROM adminTable WHERE ID= '" + adminid + "'");
                    objdb.executeQuery(deleteadmin);
                    objdb.showData(adminq, dt_adminTable);
                }
            }
        }
    }
}
