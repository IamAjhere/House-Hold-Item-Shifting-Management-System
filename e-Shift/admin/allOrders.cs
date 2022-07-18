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

    public partial class allOrders : Form
    {
        public static allOrders allordersInstance;
        DatabaseClass objdb = new DatabaseClass();
        string q = "SELECT jT.id, uT.fullname, jT.startloc, jt.endloc, jt.accept FROM jobTable jT" +
            " Inner join userTable uT on jT.userid = uT.id ";
        int loadid = 1;
        string jobid = "";
        public allOrders()
        {
            InitializeComponent();
            allordersInstance = this;
        }
        //load form function
        private void formLoad(Form form)
        {
            pnl_orders.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            pnl_orders.Controls.Add(form);
            form.Show();

        }
        private void allOrders_Load(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("All Jobs");
            objdb.showData(q, dt_alljobsTable);
        }
        orderPending orderPending = new orderPending();
        private void btn_orderspend_Click(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("Jobs Pending for Approval");
            formLoad(orderPending);
        }

        private void dt_alljobsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dt_alljobsTable.Rows[e.RowIndex];
            string ID = row.Cells[2].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                pnl_forloads.Visible = false;
                showorder_products(ID);
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Do you want to delete JOB ID-"+ ID +" from datebase?","Delete Job", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand deletecommand = new SqlCommand("DELETE FROM jobTable WHERE id = '" + ID + "'");
                    objdb.executeQuery(deletecommand);
                    MessageBox.Show("JOB ID-" + ID + " is deleted.", "Job Deleted");
                    objdb.showData(q, dt_alljobsTable);
                }
            }

        }
        public void showorder_products(string ID)
        {
            string loadprod = "SELECT plT.productid, pT.productname, plT.quantity" +
                  " FROM productlistTable plT INNER JOIN productTable pT ON plt.productid = pT.id " +
                  " WHERE jobid = '" + ID + "'";
            //load products for that items
            objdb.showData(loadprod, dt_productOrder);
            pnl_showProducts.Visible = true;
            return;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_showProducts.Visible = false;
        }

        private void btn_alljobs_Click(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("All Jobs");
            if (!pnl_orders.Controls.Contains(orderPending)) return;
            pnl_orders.Controls.Clear();
            pnl_orders.Controls.Add(dt_alljobsTable);
            
        }

        private void btn_createload_Click(object sender, EventArgs e)
        {
            if (pnl_forloads.Visible == false){
                //reset the combo box with available drivers only
                var getnames = getavailableDrivers();
                var combo = (DataGridViewComboBoxColumn)dt_loadTransport.Columns["drivername"];
                combo.Items.AddRange(getnames);
                pnl_showProducts.Visible = false;
                pnl_forloads.Visible = true;
                foreach (DataGridViewRow dgrv in dt_alljobsTable.Rows)
                {
                    if (dgrv.Cells[6].Value.ToString() == "Accepted")
                    {
                        combo_jobid.Items.Add(dgrv.Cells[2].Value.ToString());
                    }
                }
            }
            
        }

        private void btn_loadclose_Click(object sender, EventArgs e)
        {
            availableTransports.Clear();
            combo_jobid.Items.Clear();
            combo_noLoads.Texts = "";
            dt_loadTransport.Rows.Clear();
            pnl_forloads.Visible = false;
        }
        
        private void combo_noLoads_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            dt_loadTransport.Rows.Clear();
            int noofloads = int.Parse(combo_noLoads.SelectedItem.ToString());

            loadid = 1;
            for (int i = 0; i < noofloads; i++)
            {
                dt_loadTransport.Rows.Add();
                dt_loadTransport.Rows[i].Cells[0].Value = loadid;
                loadid++;
            }

        }
        DataTable availableTransports = new DataTable();
        public string[] getavailableDrivers()
        {
            
            //get available drivers from the database
            string transportquery = "SELECT * FROM transportTable WHERE available='Available'";
            objdb.readDatathroughAdapter(transportquery, availableTransports);
            objdb.closeConn();
            
            string[] drivername = (from DataRow drr in availableTransports.Rows
                                    select (string)drr["driver"]).ToArray();

            
            
            return drivername;
            
            
            
        }

        private void btn_dbCreateload_Click(object sender, EventArgs e)
        {
            jobid = combo_jobid.Texts;
            //validations
           bool id =  (combo_jobid.Texts == "");
           bool loads = (combo_noLoads.Texts == "");
            if (id)
            {
                MessageBox.Show("Please select an ID");
                return;
            }
            if (loads)
            {
                MessageBox.Show("Please Select Number of loads");
                return;
            }


            //get values
            int added = 0;
            foreach (DataGridViewRow dgrv in dt_loadTransport.Rows)
            {
                
                bool driver = (dgrv.Cells[1].Value == null);
                if (driver)
                {
                    MessageBox.Show("Please Select Drivers for the loads");
                    return;
                }

                string driverselected = dgrv.Cells[1].Value.ToString();
                int driverid = (from DataRow dr in availableTransports.Rows
                                   where (string)dr["driver"] == driverselected
                                   select (int)dr["id"]).FirstOrDefault();                
                int loadnumber = int.Parse(dgrv.Cells[0].Value.ToString());
                //send loads to database
                SqlCommand insertloads = new SqlCommand("INSERT INTO jobloadsTable(jobid,transportid,loadnumber) " +
                    "VALUES(@jobid,@transportid,@loadnumber)");
                insertloads.Parameters.AddWithValue("@jobid", jobid);
                insertloads.Parameters.AddWithValue("@transportid", driverid);
                insertloads.Parameters.AddWithValue("@loadnumber", loadnumber);

                objdb.executeQuery(insertloads);
                //update transport available
                SqlCommand changedriverstatus = new SqlCommand("UPDATE transportTable SET available = 'Unavailable'" +
                "WHERE id ='"+driverid+"'");
                objdb.executeQuery(changedriverstatus);
                added++;


                

            }
            
            if(added > 0)
            {
                //update jobs table
                SqlCommand changejobstatus = new SqlCommand("UPDATE jobTable SET accept = 'Loaded' WHERE id = '" + jobid + "'");
                objdb.executeQuery(changejobstatus);

                combo_jobid.Items.Clear();
                combo_noLoads.Text = "";
                dt_loadTransport.Rows.Clear();
                availableTransports.Clear();
                MessageBox.Show("Load created for Job ID - " + jobid);
                pnl_forloads.Visible = false;

                //refresh the datas
                objdb.showData(q, dt_alljobsTable);
            }
        }

    }
    
}
