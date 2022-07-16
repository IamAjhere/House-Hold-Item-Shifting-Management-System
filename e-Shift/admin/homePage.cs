using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace e_Shift.admin
{
    public partial class homePage : Form
    {
        DatabaseClass objdb = new DatabaseClass();
        string allorder = "SELECT * FROM jobTable";
        string allusers = "SELECT * FROM userTable";
        string transport = "SELECT * FROM transportTable";
        string products = "SELECT * FROM productTable";
        string loads = "SELECT * FROM jobloadsTable";
        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("Admin Dashboard");
            objdb.closeConn();
            homepageDetails();
        }
        DataTable dgv = new DataTable();
        public void homepageDetails()
        {
            //Data for jobs 
            
            objdb.readDatathroughAdapter(allorder, dgv);
            if (dgv.Rows.Count > 0)
            {
                alljobslbl.Text = dgv.Rows.Count.ToString();

                int pending = (from DataRow dt in dgv.Rows
                               where (string)dt["accept"] == "Pending"
                               select dt).Count();
                int accepted = (from DataRow dt in dgv.Rows
                                where (string)dt["accept"] == "Accepted"
                                select dt).Count();
                int declined = (from DataRow dt in dgv.Rows
                                where (string)dt["accept"] == "Declined"
                                select dt).Count();
                int loaded = (from DataRow dt in dgv.Rows
                              where (string)dt["accept"] == "Loaded"
                              select dt).Count();

                jobspendingLBL.Text = pending.ToString();
                jobsAcceptedlbl.Text = accepted.ToString();
                jobsDeclinedlbl.Text = declined.ToString();
                jobsLoadedlbl.Text = loaded.ToString();
            }
            dgv.Rows.Clear();
            objdb.closeConn();
            //data for products
            objdb.readDatathroughAdapter(products, dgv);
            if (dgv.Rows.Count > 0)
            {
                allproductslbl.Text = dgv.Rows.Count.ToString();
            }
            dgv.Rows.Clear();
            objdb.closeConn();

            //data for users
            objdb.readDatathroughAdapter(allusers, dgv);
            if (dgv.Rows.Count > 0)
            {
                registereduserslbl.Text = dgv.Rows.Count.ToString();
            }
            dgv.Rows.Clear();
            objdb.closeConn();

            //data for Transport Units
            objdb.readDatathroughAdapter(transport, dgv);
            if (dgv.Rows.Count > 0)
            {
                transportUnitslbl.Text = dgv.Rows.Count.ToString();
                int availableunits = (from DataRow dt in dgv.Rows
                                      where (string)dt["available"] == "Available"
                                      select dt).Count();
                availabletransportslbl.Text = availableunits.ToString();
            }
            dgv.Rows.Clear();
            objdb.closeConn();

            //data for users
            objdb.readDatathroughAdapter(loads, dgv);
            if (dgv.Rows.Count > 0)
            {
                allloadslbl.Text = dgv.Rows.Count.ToString();
            }
            //dgv.Rows.Clear();
            objdb.closeConn();

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            pnl_reports.Visible= true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //create a new empty datagridview
            DataGridView exportdata = new DataGridView();
            //fill the new datagrid with selected data grid view
            exportdata = dt_select;
            if (exportdata.Rows.Count > 0)
            {
                try
                {
                    //access the excel application create new object reference
                    Excel.Application xcelApp = new Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);

                    //fill the excel table data with corresponding data coloumn header text
                    for (int i = 1; i < exportdata.Columns.Count + 1; i++)
                    {
                        xcelApp.Cells[1, i] = exportdata.Columns[i - 1].HeaderText;
                    }
                    //fill the excel table data with corresponding data rows
                    for (int i = 0; i < exportdata.Rows.Count; i++)
                    {
                        for (int j = 0; j < exportdata.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j + 1] = exportdata.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    xcelApp.Columns.AutoFit();
                    //open excel application with those data
                    xcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
        }

        private void combo_reportType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string acceptedjobs = "SELECT * FROM jobTable WHERE accept = 'Accepted'";
            string users = "SELECT * FROM userTable";
            string table = combo_reportType.SelectedItem.ToString();
            switch (table)
            {
                case "Jobs":
                    objdb.showData(allorder, dt_select);
                    break;
                case "Accepted Jobs":
                    objdb.showData(acceptedjobs, dt_select);
                    break;
                case "Products":
                    objdb.showData(products, dt_select);
                    break;
                case "Transports":
                    objdb.showData(transport, dt_select);
                    break;
                case "Customers":
                    objdb.showData(users, dt_select);
                    break;
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_reports.Visible = false;
        }
    }
}
