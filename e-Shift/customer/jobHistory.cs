using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift.customer
{

    public partial class jobHistory : Form
    {
        private string userid = UloginForm.userID;
        DatabaseClass objdb = new DatabaseClass();
        public jobHistory()
        {
            InitializeComponent();
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

        private void dt_alljobsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = dt_alljobsTable.Rows[e.RowIndex];
            string ID = row.Cells[1].Value.ToString();
            if (e.ColumnIndex == 0)
            {

                showorder_products(ID);
            }
        }

        private void jobHistory_Load(object sender, EventArgs e)
        {
            string userhistory = "SELECT id,startloc,endloc,accept FROM jobTable WHERE userid = '" + userid + "'";
            objdb.showData(userhistory, dt_alljobsTable);
            userDashboard.userinstance.changeheader("Job History");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_showProducts.Visible = false;
        }
    }
}
