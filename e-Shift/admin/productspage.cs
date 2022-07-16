using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace e_Shift.admin
{
    
    public partial class productspage : Form
    {
        string q = "SELECT * FROM productTable ORDER BY id"; //used at showData()

        string rowprodid = "";//product id of specific item for update
        Byte[] rowimgdata = new Byte[0];//Used for storing specific image from datagrid rows for validations
        string rowprodname = "";//update validations
        byte[] img = null; // used when converting local image to byte


        DatabaseClass objdb = new DatabaseClass();
        DataTable dt = new DataTable();
        string imageloc = "";
        public productspage()
        {
            InitializeComponent();
        }
        private void productspage_Activated(object sender, EventArgs e)
        {
            adminDashboard.admininstance.changeheader("Products");
            ((DataGridViewImageColumn)dt_productTable.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            pnl_addProduct.Visible = false;
            objdb.showData(q,dt_productTable);
            

        }
        //browse image
        private void btn_browse_Click(object sender, EventArgs e)
        {
            try 
            {
                //promt file dialog
                OpenFileDialog dlg = new OpenFileDialog();
                //filter file formats
                dlg.Filter = "Image Files(*.JPEG; *.JPG; *.GIF)| *.JPEG; *.JPG; *.GIF | All files(*.*) | *.*";
                dlg.Title = "Select Product Image";
                

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    //display in imagebox
                    imageloc = dlg.FileName.ToString();
                    pic_product.ImageLocation = imageloc;
                    //convert image to byte
                    FileStream fs = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                    BinaryReader bs = new BinaryReader(fs);
                    img = bs.ReadBytes((int)fs.Length);
                    var onlyFileName = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName);
                    txt_productName.Texts = onlyFileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //add product
        private void product_insert(string productname)
        {
            //format the product name
            productname = char.ToUpper(productname[0]) + productname.Substring(1).ToLower();



            //save in database 
            SqlCommand insertcommand = new SqlCommand(
                "INSERT INTO productTable(productname,productimage)" +
                " VALUES(@productname,@productimg)"
                );
            insertcommand.Parameters.AddWithValue("@productname", productname);
            insertcommand.Parameters.AddWithValue("@productimg", img);

            int row = objdb.executeQuery(insertcommand);
            if (row == 1)
            {

                lbl_Error.Text = productname + " - Is added Successfully";
                lbl_Error.ForeColor = Color.LimeGreen;
                txt_productName.Texts = "";
                pic_product.ImageLocation = "";
                imageloc = "";

                objdb.showData(q, dt_productTable);
            }
        }
        private void product_update_both(string productname)
        {
            //update product in database 

            SqlCommand insertcommand = new SqlCommand(
                "UPDATE productTable SET productname = '" + productname + "', productimage = @productimg WHERE id= '" + rowprodid+ "'"
                );
            insertcommand.Parameters.AddWithValue("@productimg", img);
            int row = objdb.executeQuery(insertcommand);
            if (row == 1)
            {

                MessageBox.Show(productname + "\n" + "Product Name and Image Updated Successfully", "Product Update");
                txt_productName.Texts = "";
                pic_product.ImageLocation = "";
                imageloc = "";

                objdb.showData(q, dt_productTable);
            }
        }
        
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            string productname = txt_productName.Texts;
            lbl_Error.ForeColor = Color.Crimson;
            try
            {
                if (btn_addProduct.Text == "Add Product")
                {
                    if (productname == "" || imageloc == "")
                    {
                        lbl_Error.Text = "Add Valid Product Name and Image";
                        return;
                    }
                    product_insert(productname);
                }
                if (btn_addProduct.Text == "Update Product")
                {
                   if(productname == "")
                    {
                        lbl_Error.Text = "Product name cannot be empty";
                        return;
                    }
                    if (productname != rowprodname && imageloc != "")
                    {
                        product_update_both(productname);
                        return;
                    }
                    if(productname != rowprodname)
                    {
                        SqlCommand insertcommand = new SqlCommand(
                         "UPDATE productTable SET productname ='" + productname + "' WHERE id= '" + rowprodid + "'"
                        ); 
                        

                        int row = objdb.executeQuery(insertcommand);
                        if (row == 1)
                        { 
                            objdb.showData(q, dt_productTable); 
                            MessageBox.Show(productname + "\n" + "Product Name Updated Successfully", "Product Update");
                            pnl_addProduct.Visible = false;
                            txt_productName.Texts = "";
                            pic_product.ImageLocation = "";                        
                        }
                        return;
                    }
                    if(imageloc != "")
                    {
                        SqlCommand insertcommand = new SqlCommand(
                         "UPDATE productTable SET productimage = @productimg WHERE id= '" + rowprodid + "'"
                        );

                        insertcommand.Parameters.AddWithValue("@productimg", img);
                        int row = objdb.executeQuery(insertcommand);
                        if (row == 1)
                        {
                            objdb.showData(q, dt_productTable);
                            MessageBox.Show(productname + "\n" + "Product Image Updated Successfully", "Product Update");
                            pnl_addProduct.Visible = false;
                            txt_productName.Texts = "";
                            pic_product.ImageLocation = "";
                        }
                        return;
                    }
                    


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            objdb.closeConn();
        }
       
        // hide and show the other panels 
        private void btn_close_Click(object sender, EventArgs e)
        {
            txt_productName.Texts = "";
            pic_product.Image = null;
            pnl_addProduct.Visible= false;
        }

        private void btn_addpro_Click(object sender, EventArgs e)
        {
            btn_addProduct.Text = "Add Product"; 
            pnl_addProduct.Visible = true;
        }

        private void txt_search__TextChanged(object sender, EventArgs e)
        {
            string searchq = "SELECT * FROM productTable WHERE productname LIKE'%" + txt_search.Texts + "%'";
            objdb.showData(searchq, dt_productTable);
        }

        //update and delete
        private void dt_productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dt_productTable.Rows[e.RowIndex];
            rowprodid = row.Cells[2].Value.ToString();
            rowprodname = row.Cells[3].Value.ToString();


            if (e.ColumnIndex == 0)
            {

                
                if (MessageBox.Show("Do you want to Update " + rowprodname + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    btn_addProduct.Text = "Update Product";
                    txt_productName.Texts = rowprodname;

                    
                    rowimgdata = (Byte[])row.Cells[4].Value;
                    MemoryStream mem = new MemoryStream(rowimgdata);
                    pic_product.Image = Image.FromStream(mem);
                    pnl_addProduct.Visible = true;
                }
             return;
            }
            //delete specific data from database
            if (e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Do you want to delete " +rowprodname+ " from Database?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM productTable WHERE id='" + rowprodid + "'");
                    objdb.executeQuery(delete);
                    dt_productTable.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
