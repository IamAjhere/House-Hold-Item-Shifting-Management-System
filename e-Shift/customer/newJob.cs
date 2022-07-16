using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Shift;

namespace e_Shift.customer
{
    public partial class newJob : Form
    {
        private string userid = UloginForm.userID;
        string q = "SELECT * FROM productTable";
        DatabaseClass objdb = new DatabaseClass();
        DataTable dt = new DataTable();
        private DataGridView dg = new DataGridView();
        public newJob()
        {
            InitializeComponent();
        }
        //load product details into private datagrid
        private void showData(string query)
        {
            try
            {
                dt.Rows.Clear();

                objdb.readDatathroughAdapter(query, dt);
                if (dt.Rows.Count > 0)
                {
                    dg.DataSource = dt;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            objdb.closeConn();
        }

        private void newJob_Load(object sender, EventArgs e)
        {
            objdb.closeConn();
            userDashboard.userinstance.changeheader("Create New Job");
            showData(q);
        }
        
        private void btn_Selectpro_Click(object sender, EventArgs e)
        {
            pnl_addproduct.Visible = true;
            combo_productlist.Items.Clear();
 
            foreach (DataRow row in dt.Rows)
            {
               combo_productlist.Items.Add(row["productname"].ToString());
            }

        }

        private void combo_productlist_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           string productselect = combo_productlist.SelectedItem.ToString();

            //show image of product when selecting from combo box
           byte[] img = (from DataRow dr in dt.Rows
                        where (string)dr["productname"] == productselect
                        select (byte[])dr["productimage"]).FirstOrDefault();

           MemoryStream mem = new MemoryStream(img);
           pic_productpicture.Image = Image.FromStream(mem);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_addproduct.Visible = false;
            combo_productlist.Texts = "";
            pic_productpicture.Image = null;
            txt_quantity.Texts = "";
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            if(combo_productlist.Texts == "")
            {
                lbl_Error.Text = "Select a Product";
                return;
            }
            if(txt_quantity.Texts == "")
            {
                lbl_Error.Text = "Input a valid quantity";
                return;
            }
            //linear search algoritm to iterate through items in product table
            foreach (DataGridViewRow dgrow in dt_productTable.Rows)
            {
                if (dgrow.Cells[1].Value.ToString() == combo_productlist.Texts)
                {
                    lbl_Error.Text = "Product Already Added to List";
                    return;
                }
            }
            //insert product to table
            int id = (from DataRow dr in dt.Rows
                      where (string)dr["productname"] == combo_productlist.Texts
                      select (int)dr["id"]).FirstOrDefault();

            byte[] img = (from DataRow dr in dt.Rows
                          where (string)dr["productname"] == combo_productlist.Texts
                          select (byte[])dr["productimage"]).FirstOrDefault();

            DataGridViewRow row = new DataGridViewRow();
            row.Height = 100;
            row.CreateCells(dt_productTable);
            row.Cells[0].Value = id;
            row.Cells[1].Value = combo_productlist.Texts;
            row.Cells[2].Value = img;
            row.Cells[3].Value = txt_quantity.Texts;
            dt_productTable.Rows.Add(row);

            ((DataGridViewImageColumn)dt_productTable.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dt_productTable.Visible = true;
            btn_createjob.Visible = true;

            combo_productlist.Texts = "";
            pic_productpicture.Image = null;
            txt_quantity.Texts = "";

        }

        private void dt_productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore header click
            if (e.RowIndex == -1) return;
            
            var row = dt_productTable.Rows[e.RowIndex];
            int quantity = int.Parse(row.Cells[3].Value.ToString());

            if (e.ColumnIndex == 4)
            {
                quantity++;
                row.Cells[3].Value = quantity.ToString();
                return;
                
            }
            if (e.ColumnIndex == 5)
            {
                if(quantity == 1)
                {
                    if(MessageBox.Show("Do you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int rowindex = e.RowIndex;
                        dt_productTable.Rows.RemoveAt(rowindex);
                        
                    }
                    return;
                }
                quantity--;
                row.Cells[3].Value = quantity.ToString();
                return;

            }
            if(e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Do you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int rowindex = e.RowIndex;
                    dt_productTable.Rows.RemoveAt(rowindex);

                }
                return;
            }    
        }
        //type only number
        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        //create the job
        private void btn_createjob_Click(object sender, EventArgs e)
        {
            //store variables
            int gotMAXid = 1;
            string endloc = combo_endloc.Texts;
            string startloc = combo_startloc.Texts;
            string statpend = "Pending";

            if(endloc == "" || startloc == "")
            {
                MessageBox.Show("Please Select Start Location and End Location.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(startloc == endloc)
            {
                MessageBox.Show("Start Location and End Location Cannot be same.", "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check if user already have pending job
            string alreadypending = "SELECT * FROM jobTable WHERE id = '" + userid + "' AND accept = '" + statpend + "'";
            var statreader = objdb.readDatathroughReader(alreadypending);
            if (statreader.HasRows)
            {
                MessageBox.Show("You Already Have Pending Order", "Already Pending", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                statreader.Close();
                return;
            }
            statreader.Close();
            if (MessageBox.Show("Do you want to Create a new job?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                
                
                //insert the order first
                SqlCommand insertorder = new SqlCommand("INSERT INTO jobTable(userId,startloc,endloc,accept) VALUES(@userid,@startloc,@endloc,@accept)");
                insertorder.Parameters.AddWithValue("@userid", userid);
                insertorder.Parameters.AddWithValue("@startloc", startloc);
                insertorder.Parameters.AddWithValue("@endloc", endloc);
                insertorder.Parameters.AddWithValue("@accept", statpend);
                int row = objdb.executeQuery(insertorder);
                if (row == 1)
                {
                    //get the last inserted order id
                    string maxid = "SELECT MAX(id) FROM jobTable";
                    using (var maxreader = objdb.readDatathroughReader(maxid))
                    {
                        while (maxreader.Read())
                        {
                            gotMAXid = maxreader.GetInt32(0);
                        }
                    }
                    //insert the product
                    //iterate through all products and add it to database
                    int prodrow = 0;
                    foreach (DataGridViewRow dgvr in dt_productTable.Rows)
                    {
                        int productid = int.Parse(dgvr.Cells[0].Value.ToString());
                        int prodQuant = int.Parse(dgvr.Cells[3].Value.ToString());

                        SqlCommand insertProduct = new SqlCommand("INSERT INTO productlistTable(jobid,productid,quantity) VALUES(@jobid,@productid,@quantity)");
                        insertProduct.Parameters.AddWithValue("@jobid", gotMAXid);
                        insertProduct.Parameters.AddWithValue("@productid", productid);
                        insertProduct.Parameters.AddWithValue("@quantity", prodQuant);

                        int addprodrow = objdb.executeQuery(insertProduct);
                        if (addprodrow > 0)
                        {
                            prodrow++;
                        }
                    }
                    if (prodrow > 0)
                    {
                        MessageBox.Show("Your Job(" + gotMAXid.ToString() + ") Has Been Created with " + prodrow.ToString() + " prouct.");
                        combo_endloc.Texts = "";
                        combo_startloc.Texts = "";
                        dt_productTable.Rows.Clear();
                        dt_productTable.Visible = false;
                        btn_createjob.Visible = false;
                    }

                    ///:::
                }
                objdb.closeConn();

                ///::::
            }
        }
    }
}
