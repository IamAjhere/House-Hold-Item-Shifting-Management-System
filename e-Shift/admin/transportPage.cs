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
using e_Shift;


namespace e_Shift.admin
{
    
    public partial class transportPage : Form
    {
        string q = "SELECT * FROM transportTable";
        DatabaseClass objdb = new DatabaseClass();
        string availables = "Available";

        string rowtransid = "";//transport id of specific item for update
        string rowlorry = "";
        string rowdriver = "";
        string rowcontainer = "";
        string rowstatus = "";
        string rowassist = "";


        public transportPage()
        {
            InitializeComponent();
        }

        private void transportPage_Load(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("All Transport");
            objdb.showData(q,dt_transportTable);
        }

        private void btn_addTunit_Click(object sender, EventArgs e)
        {
            pnl_addTuni.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            btn_addTransport.Text = "Add Transport";
            pnl_addTuni.Visible = false;
            lbl_Error.Text = 
            txt_assistant.Texts =
            txt_driverName.Texts =
            txt_lorryName.Texts =
            combo_containertype.Texts = string.Empty;
        }

        //add transport
        private void btn_addTransport_Click(object sender, EventArgs e)
        {
            //store values in variables

            int assistant = 0;
            string lorryname = txt_lorryName.Texts.Trim();
            string drivername = txt_driverName.Texts.Trim();
            string container = combo_containertype.Texts.Trim();
            string status = combo_status.Texts.Trim();
            if (container == string.Empty)
            {
                lbl_Error.Text = "Please Select a Container Type";
                return;
            }
            if (lorryname == string.Empty)
            {
                lbl_Error.Text = "Please Enter the Lorry";
                return;
            }
            if (drivername == string.Empty)
            {
                lbl_Error.Text = "Please Enter the Driver Name";
                return;
            }
            if (txt_assistant.Texts != "")
            {
                assistant = int.Parse(txt_assistant.Texts);
            }
            if (assistant >= 100 || assistant == 0)
            {

                lbl_Error.Text = "Enter Number Between 0 - 100";
                return;
            }
            if (btn_addTransport.Text == "Add Transport") {
                try
                {
                    
                    SqlCommand insertcommand = new SqlCommand(
                        "INSERT INTO transportTable(lorry,driver,assistant,containertype,available) " +
                        "VALUES(@lorry,@drivername,@assistant,@containerType,'"+ status +"')");
                    insertcommand.Parameters.AddWithValue("@lorry", lorryname);
                    insertcommand.Parameters.AddWithValue("@drivername", drivername);
                    insertcommand.Parameters.AddWithValue("@assistant", assistant);
                    insertcommand.Parameters.AddWithValue("@containerType", container);

                    int row = objdb.executeQuery(insertcommand);
                    if (row == 1)
                    {
                        MessageBox.Show(lorryname + "\n" + "Transport Unit Added Successfully", "Transport Unit Add");
                        objdb.showData(q, dt_transportTable);

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Adding Transport" + ex, "Adding Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            if (btn_addTransport.Text == "Update Product")
            {
                try
                {

                    SqlCommand insertcommand = new SqlCommand(
                        "UPDATE transportTable SET driver = @drivername, lorry = @lorry, assistant = @assistant, containertype = @containerType, available = @available " +
                        "WHERE id = '"+ rowtransid +"'");
                    insertcommand.Parameters.AddWithValue("@lorry", lorryname);
                    insertcommand.Parameters.AddWithValue("@drivername", drivername);
                    insertcommand.Parameters.AddWithValue("@assistant", assistant);
                    insertcommand.Parameters.AddWithValue("@containerType", container);
                    insertcommand.Parameters.AddWithValue("@available", status);

                    int row = objdb.executeQuery(insertcommand);
                    if (row == 1)
                    {
                        MessageBox.Show(lorryname + "\n" + "Transport Unit Updated Successfully", "Transport Unit Updated");
                        objdb.showData(q, dt_transportTable);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Transport" + ex, "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //controls the key pressed in textboxs
        private void txt_assistant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
           {
                e.Handled = true;

            }

        }
        private void txt_lorryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txt_driverName_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;

             }
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("All Transport");
            objdb.showData(q, dt_transportTable);
        }

        private void btn_available_Click(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("All Transport");
            string availq = ("SELECT * FROM transportTable WHERE available = '"+availables+"' ");
            objdb.showData(availq, dt_transportTable);
        }

        private void dt_transportTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore header click
            if (e.RowIndex == -1) return;
            var row = dt_transportTable.Rows[e.RowIndex];
            rowtransid = row.Cells[2].Value.ToString();
            rowlorry = row.Cells[3].Value.ToString();
            rowdriver = row.Cells[4].Value.ToString();
            rowassist = row.Cells[5].Value.ToString();
            rowcontainer = row.Cells[6].Value.ToString();
            rowstatus = row.Cells[7].Value.ToString();



            if (e.ColumnIndex == 0)
            {


                if (MessageBox.Show("Do you want to Update " + rowlorry + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    btn_addTransport.Text = "Update Product";
                    combo_containertype.Texts = rowcontainer;
                    txt_assistant.Texts = rowassist;
                    txt_driverName.Texts = rowdriver;
                    combo_status.Texts = rowstatus;
                    txt_lorryName.Texts = rowlorry;

                    pnl_addTuni.Visible = true;

                }
                return;
            }
            //delete specific data from database
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowlorry + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM transportTable WHERE id='" + rowtransid + "'");
                    objdb.executeQuery(delete);
                    dt_transportTable.Rows.RemoveAt(row.Index);

                }
            }
        }
    }
}
