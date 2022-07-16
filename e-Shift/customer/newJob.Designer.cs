namespace e_Shift.customer
{
    partial class newJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newJob));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_addproduct = new System.Windows.Forms.Panel();
            this.pic_productpicture = new System.Windows.Forms.PictureBox();
            this.combo_productlist = new e_Shift.customControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_addproduct = new CustomControls.RJControls.RJButton();
            this.txt_quantity = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.dt_productTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteimg = new System.Windows.Forms.DataGridViewImageColumn();
            this.combo_endloc = new e_Shift.customControls.RJComboBox();
            this.combo_startloc = new e_Shift.customControls.RJComboBox();
            this.btn_Selectpro = new CustomControls.RJControls.RJButton();
            this.btn_createjob = new CustomControls.RJControls.RJButton();
            this.pnl_addproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_productpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(594, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "End Location";
            // 
            // pnl_addproduct
            // 
            this.pnl_addproduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_addproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_addproduct.Controls.Add(this.pic_productpicture);
            this.pnl_addproduct.Controls.Add(this.combo_productlist);
            this.pnl_addproduct.Controls.Add(this.label4);
            this.pnl_addproduct.Controls.Add(this.btn_close);
            this.pnl_addproduct.Controls.Add(this.btn_addproduct);
            this.pnl_addproduct.Controls.Add(this.txt_quantity);
            this.pnl_addproduct.Controls.Add(this.label3);
            this.pnl_addproduct.Controls.Add(this.lbl_Error);
            this.pnl_addproduct.Location = new System.Drawing.Point(279, 83);
            this.pnl_addproduct.Name = "pnl_addproduct";
            this.pnl_addproduct.Size = new System.Drawing.Size(467, 444);
            this.pnl_addproduct.TabIndex = 10;
            this.pnl_addproduct.Visible = false;
            // 
            // pic_productpicture
            // 
            this.pic_productpicture.Location = new System.Drawing.Point(27, 107);
            this.pic_productpicture.Name = "pic_productpicture";
            this.pic_productpicture.Size = new System.Drawing.Size(412, 196);
            this.pic_productpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_productpicture.TabIndex = 6;
            this.pic_productpicture.TabStop = false;
            // 
            // combo_productlist
            // 
            this.combo_productlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_productlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_productlist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_productlist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_productlist.BorderSize = 2;
            this.combo_productlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_productlist.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_productlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_productlist.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_productlist.Items.AddRange(new object[] {
            "Dry ",
            "poop"});
            this.combo_productlist.ListBackColor = System.Drawing.Color.White;
            this.combo_productlist.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_productlist.Location = new System.Drawing.Point(27, 61);
            this.combo_productlist.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_productlist.Name = "combo_productlist";
            this.combo_productlist.Padding = new System.Windows.Forms.Padding(2);
            this.combo_productlist.Size = new System.Drawing.Size(412, 39);
            this.combo_productlist.TabIndex = 0;
            this.combo_productlist.Texts = "";
            this.combo_productlist.OnSelectedIndexChanged += new System.EventHandler(this.combo_productlist_OnSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Poppins Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Crimson;
            this.btn_close.Location = new System.Drawing.Point(434, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(33, 37);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addproduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addproduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_addproduct.BorderRadius = 0;
            this.btn_addproduct.BorderSize = 0;
            this.btn_addproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addproduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_addproduct.FlatAppearance.BorderSize = 0;
            this.btn_addproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addproduct.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproduct.ForeColor = System.Drawing.Color.White;
            this.btn_addproduct.Location = new System.Drawing.Point(0, 402);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(465, 40);
            this.btn_addproduct.TabIndex = 4;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.TextColor = System.Drawing.Color.White;
            this.btn_addproduct.UseVisualStyleBackColor = false;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_quantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_quantity.BorderSize = 2;
            this.txt_quantity.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_quantity.Location = new System.Drawing.Point(27, 331);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quantity.Multiline = false;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Padding = new System.Windows.Forms.Padding(7);
            this.txt_quantity.PasswordChar = false;
            this.txt_quantity.Size = new System.Drawing.Size(412, 38);
            this.txt_quantity.TabIndex = 1;
            this.txt_quantity.Texts = "";
            this.txt_quantity.UnderlinedStyle = true;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(21, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // lbl_Error
            // 
            this.lbl_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Error.Location = new System.Drawing.Point(27, 373);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 23);
            this.lbl_Error.TabIndex = 5;
            // 
            // dt_productTable
            // 
            this.dt_productTable.AllowUserToAddRows = false;
            this.dt_productTable.AllowUserToDeleteRows = false;
            this.dt_productTable.AllowUserToResizeColumns = false;
            this.dt_productTable.AllowUserToResizeRows = false;
            this.dt_productTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_productTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_productTable.BackgroundColor = System.Drawing.Color.White;
            this.dt_productTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.quantity,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.deleteimg});
            this.dt_productTable.GridColor = System.Drawing.Color.White;
            this.dt_productTable.Location = new System.Drawing.Point(13, 161);
            this.dt_productTable.MultiSelect = false;
            this.dt_productTable.Name = "dt_productTable";
            this.dt_productTable.ReadOnly = true;
            this.dt_productTable.RowHeadersVisible = false;
            this.dt_productTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_productTable.RowTemplate.Height = 40;
            this.dt_productTable.ShowEditingIcon = false;
            this.dt_productTable.Size = new System.Drawing.Size(999, 414);
            this.dt_productTable.TabIndex = 11;
            this.dt_productTable.Visible = false;
            this.dt_productTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_productTable_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.FillWeight = 74.1852F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productname";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.FillWeight = 153.8121F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "productimage";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn1.FillWeight = 201.2995F;
            this.dataGridViewImageColumn1.HeaderText = "Product Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // quantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantity.FillWeight = 121.204F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewButtonColumn1.FillWeight = 40.35494F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "+";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn2.FillWeight = 38.07807F;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.Text = "-";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // deleteimg
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson;
            this.deleteimg.DefaultCellStyle = dataGridViewCellStyle7;
            this.deleteimg.FillWeight = 71.06598F;
            this.deleteimg.HeaderText = "";
            this.deleteimg.Image = global::e_Shift.Properties.Resources.deletewhite;
            this.deleteimg.Name = "deleteimg";
            this.deleteimg.ReadOnly = true;
            this.deleteimg.ToolTipText = "Delete Product";
            // 
            // combo_endloc
            // 
            this.combo_endloc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_endloc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_endloc.BorderSize = 2;
            this.combo_endloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_endloc.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_endloc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_endloc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_endloc.Items.AddRange(new object[] {
            "London",
            "Birmingham",
            "Leeds",
            "Glasgow",
            "Sheffield",
            "Bradford",
            "Liverpool",
            "Edinburgh",
            "Manchester",
            "Bristol",
            "Kirklees",
            "Fife",
            "Wirral",
            "North Lanarkshire",
            "Wakefield",
            "Cardiff",
            "Dudley",
            "Wigan",
            "East Riding",
            "South Lanarkshire",
            "Coventry",
            "Belfast",
            "Leicester",
            "Sunderland",
            "Sandwell",
            "Doncaster",
            "Stockport",
            "Sefton"});
            this.combo_endloc.ListBackColor = System.Drawing.Color.White;
            this.combo_endloc.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_endloc.Location = new System.Drawing.Point(600, 60);
            this.combo_endloc.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_endloc.Name = "combo_endloc";
            this.combo_endloc.Padding = new System.Windows.Forms.Padding(2);
            this.combo_endloc.Size = new System.Drawing.Size(412, 39);
            this.combo_endloc.TabIndex = 7;
            this.combo_endloc.Texts = "";
            // 
            // combo_startloc
            // 
            this.combo_startloc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_startloc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_startloc.BorderSize = 2;
            this.combo_startloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_startloc.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_startloc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_startloc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_startloc.Items.AddRange(new object[] {
            "London",
            "Birmingham",
            "Leeds",
            "Glasgow",
            "Sheffield",
            "Bradford",
            "Liverpool",
            "Edinburgh",
            "Manchester",
            "Bristol",
            "Kirklees",
            "Fife",
            "Wirral",
            "North Lanarkshire",
            "Wakefield",
            "Cardiff",
            "Dudley",
            "Wigan",
            "East Riding",
            "South Lanarkshire",
            "Coventry",
            "Belfast",
            "Leicester",
            "Sunderland",
            "Sandwell",
            "Doncaster",
            "Stockport",
            "Sefton"});
            this.combo_startloc.ListBackColor = System.Drawing.Color.White;
            this.combo_startloc.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_startloc.Location = new System.Drawing.Point(12, 60);
            this.combo_startloc.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_startloc.Name = "combo_startloc";
            this.combo_startloc.Padding = new System.Windows.Forms.Padding(2);
            this.combo_startloc.Size = new System.Drawing.Size(412, 39);
            this.combo_startloc.TabIndex = 5;
            this.combo_startloc.Texts = "";
            // 
            // btn_Selectpro
            // 
            this.btn_Selectpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_Selectpro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_Selectpro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_Selectpro.BorderRadius = 0;
            this.btn_Selectpro.BorderSize = 0;
            this.btn_Selectpro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Selectpro.FlatAppearance.BorderSize = 0;
            this.btn_Selectpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Selectpro.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selectpro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_Selectpro.Location = new System.Drawing.Point(12, 114);
            this.btn_Selectpro.Name = "btn_Selectpro";
            this.btn_Selectpro.Size = new System.Drawing.Size(169, 41);
            this.btn_Selectpro.TabIndex = 2;
            this.btn_Selectpro.Text = "Select Products";
            this.btn_Selectpro.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_Selectpro.UseVisualStyleBackColor = false;
            this.btn_Selectpro.Click += new System.EventHandler(this.btn_Selectpro_Click);
            // 
            // btn_createjob
            // 
            this.btn_createjob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_createjob.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_createjob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_createjob.BorderRadius = 0;
            this.btn_createjob.BorderSize = 0;
            this.btn_createjob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createjob.FlatAppearance.BorderSize = 0;
            this.btn_createjob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createjob.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createjob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_createjob.Location = new System.Drawing.Point(198, 114);
            this.btn_createjob.Name = "btn_createjob";
            this.btn_createjob.Size = new System.Drawing.Size(169, 41);
            this.btn_createjob.TabIndex = 12;
            this.btn_createjob.Text = "Create Job";
            this.btn_createjob.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_createjob.UseVisualStyleBackColor = false;
            this.btn_createjob.Visible = false;
            this.btn_createjob.Click += new System.EventHandler(this.btn_createjob_Click);
            // 
            // newJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.pnl_addproduct);
            this.Controls.Add(this.dt_productTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_endloc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_startloc);
            this.Controls.Add(this.btn_Selectpro);
            this.Controls.Add(this.btn_createjob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newJob";
            this.Text = "newJob";
            this.Load += new System.EventHandler(this.newJob_Load);
            this.pnl_addproduct.ResumeLayout(false);
            this.pnl_addproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_productpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btn_Selectpro;
        private System.Windows.Forms.Label label2;
        private customControls.RJComboBox combo_startloc;
        private System.Windows.Forms.Label label1;
        private customControls.RJComboBox combo_endloc;
        private System.Windows.Forms.Panel pnl_addproduct;
        private System.Windows.Forms.PictureBox pic_productpicture;
        private customControls.RJComboBox combo_productlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btn_close;
        private CustomControls.RJControls.RJButton btn_addproduct;
        private CustomControls.RJControls.RJTextBox txt_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.DataGridView dt_productTable;
        private CustomControls.RJControls.RJButton btn_createjob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewImageColumn deleteimg;
    }
}