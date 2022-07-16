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
    

    public partial class orderPending : Form
    {
        
        readonly string q = "SELECT jT.id, uT.fullname, jT.startloc, jt.endloc FROM jobTable jT" +
            " Inner join userTable uT on jT.userid = uT.id WHERE accept = 'Pending' ";

        DatabaseClass objdb = new DatabaseClass();
        DataTable dt = new DataTable();
        public orderPending()
        {
            InitializeComponent();
        }
        private void orderPending_Load(object sender, EventArgs e)
        {
            objdb.showData(q, dt_jobTable);
        }

        private void dt_jobTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            var row = dt_jobTable.Rows[e.RowIndex];
            string ID = row.Cells[3].Value.ToString();
            string Rstartloc = row.Cells[5].Value.ToString();
            string Rendloc = row.Cells[6].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                pnl_updatejob.Visible = false;
                allOrders.allordersInstance.showorder_products(ID);
                return;
            }
            //update the job if its accepted or declined
            if(e.ColumnIndex == 1)
            {
                DialogResult accept_decline = MessageBox.Show("Do you want to accept this order?", "Order Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if ( accept_decline == DialogResult.Yes)
                {
                    SqlCommand penaccept = new SqlCommand("UPDATE jobTable SET accept = 'Accept' WHERE id='"+ID+"'");
                    int accepted = objdb.executeQuery(penaccept);
                    dt_jobTable.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Job - " + ID + " Is Accepted", "Job Accepted");
                    return;
                }
                else if (accept_decline == DialogResult.No)
                {
                    if(MessageBox.Show("Confirm Order Declining?", "Order Declining", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand pendecline = new SqlCommand("UPDATE jobTable SET accept = 'Declined' WHERE id='" + ID + "'");
                        int accepted = objdb.executeQuery(pendecline);
                        if (accepted == 1)
                        {
                            dt_jobTable.Rows.RemoveAt(row.Index);
                            MessageBox.Show("Job - " + ID + " Is Declined", "Job Declined");
                            return;
                        }
                    }
                    
                }
                return;
            }
            if(e.ColumnIndex == 2)
            {
                
                DialogResult accept_decline = MessageBox.Show("Do you want to Update the Location?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(accept_decline == DialogResult.Yes)
                {
                    lbl_id.Text = ID.ToString();
                    combo_startloc.Texts = Rstartloc;
                    combo_endloc.Texts = Rendloc;
                    pnl_updatejob.Visible = true;
                }
            }
        }
        
        private void btn_close1_Click(object sender, EventArgs e)
        {
            pnl_updatejob.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string endloc = combo_endloc.Texts;
            string startloc = combo_startloc.Texts;
            string id = lbl_id.Text;

            if (endloc == "" || startloc == "")
            {
                lbl_Error.Text = "Please Select Start Location and End Location.";
                return;
            }
            if (startloc == endloc)
            {
                lbl_Error.Text = "Start Location and End Location Cannot be same.";
                return;
            }
            SqlCommand updateloc = new SqlCommand("UPDATE jobTable SET startloc='" + startloc + "', endloc='" + endloc + "' " +
                "Where id = '" + id + "'");
            objdb.executeQuery(updateloc);
            MessageBox.Show("Job ID- "+ id + " is Updated");
            pnl_updatejob.Visible = false;
            objdb.showData(q,dt_jobTable);

        }
    }
}
