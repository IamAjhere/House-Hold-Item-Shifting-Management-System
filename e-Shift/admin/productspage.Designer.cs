namespace e_Shift.admin
{
    partial class productspage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_datatable = new System.Windows.Forms.Panel();
            this.pnl_addProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.dt_productTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtproductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtproductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_browse = new CustomControls.RJControls.RJButton();
            this.btn_addProduct = new CustomControls.RJControls.RJButton();
            this.txt_productName = new CustomControls.RJControls.RJTextBox();
            this.btn_addpro = new CustomControls.RJControls.RJButton();
            this.txt_search = new CustomControls.RJControls.RJTextBox();
            this.pnl_datatable.SuspendLayout();
            this.pnl_addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_datatable
            // 
            this.pnl_datatable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datatable.Controls.Add(this.pnl_addProduct);
            this.pnl_datatable.Controls.Add(this.btn_addpro);
            this.pnl_datatable.Controls.Add(this.pic_search);
            this.pnl_datatable.Controls.Add(this.txt_search);
            this.pnl_datatable.Controls.Add(this.dt_productTable);
            this.pnl_datatable.Location = new System.Drawing.Point(0, 0);
            this.pnl_datatable.Name = "pnl_datatable";
            this.pnl_datatable.Size = new System.Drawing.Size(1024, 611);
            this.pnl_datatable.TabIndex = 1;
            // 
            // pnl_addProduct
            // 
            this.pnl_addProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_addProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_addProduct.Controls.Add(this.label1);
            this.pnl_addProduct.Controls.Add(this.btn_browse);
            this.pnl_addProduct.Controls.Add(this.pic_product);
            this.pnl_addProduct.Controls.Add(this.btn_close);
            this.pnl_addProduct.Controls.Add(this.btn_addProduct);
            this.pnl_addProduct.Controls.Add(this.txt_productName);
            this.pnl_addProduct.Controls.Add(this.label2);
            this.pnl_addProduct.Controls.Add(this.lbl_Error);
            this.pnl_addProduct.Location = new System.Drawing.Point(264, 89);
            this.pnl_addProduct.Name = "pnl_addProduct";
            this.pnl_addProduct.Size = new System.Drawing.Size(467, 456);
            this.pnl_addProduct.TabIndex = 1;
            this.pnl_addProduct.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Upload Image";
            // 
            // pic_product
            // 
            this.pic_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_product.Location = new System.Drawing.Point(27, 69);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(412, 241);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_product.TabIndex = 15;
            this.pic_product.TabStop = false;
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
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(21, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Error.Location = new System.Drawing.Point(23, 378);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 22);
            this.lbl_Error.TabIndex = 5;
            // 
            // pic_search
            // 
            this.pic_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_search.Image = global::e_Shift.Properties.Resources.search;
            this.pic_search.Location = new System.Drawing.Point(707, 12);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(53, 41);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search.TabIndex = 16;
            this.pic_search.TabStop = false;
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
            this.dataGridViewTextBoxColumn1,
            this.dtproductName,
            this.dtproductImage,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dt_productTable.GridColor = System.Drawing.Color.White;
            this.dt_productTable.Location = new System.Drawing.Point(12, 59);
            this.dt_productTable.MultiSelect = false;
            this.dt_productTable.Name = "dt_productTable";
            this.dt_productTable.ReadOnly = true;
            this.dt_productTable.RowHeadersVisible = false;
            this.dt_productTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_productTable.RowTemplate.Height = 40;
            this.dt_productTable.ShowEditingIcon = false;
            this.dt_productTable.Size = new System.Drawing.Size(999, 540);
            this.dt_productTable.TabIndex = 4;
            this.dt_productTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_productTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.FillWeight = 61.20689F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dtproductName
            // 
            this.dtproductName.DataPropertyName = "productname";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtproductName.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtproductName.FillWeight = 126.9035F;
            this.dtproductName.HeaderText = "Product Name";
            this.dtproductName.Name = "dtproductName";
            this.dtproductName.ReadOnly = true;
            // 
            // dtproductImage
            // 
            this.dtproductImage.DataPropertyName = "productimage";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtproductImage.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtproductImage.FillWeight = 166.0832F;
            this.dtproductImage.HeaderText = "Product Image";
            this.dtproductImage.Name = "dtproductImage";
            this.dtproductImage.ReadOnly = true;
            this.dtproductImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtproductImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewButtonColumn1.FillWeight = 77.38251F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Update";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewButtonColumn2.FillWeight = 68.4238F;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_browse.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btn_browse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_browse.BorderRadius = 0;
            this.btn_browse.BorderSize = 2;
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_browse.Location = new System.Drawing.Point(325, 33);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(114, 30);
            this.btn_browse.TabIndex = 13;
            this.btn_browse.Text = "Browse";
            this.btn_browse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_addProduct.BorderRadius = 0;
            this.btn_addProduct.BorderSize = 0;
            this.btn_addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.Location = new System.Drawing.Point(0, 414);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(465, 40);
            this.btn_addProduct.TabIndex = 0;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.TextColor = System.Drawing.Color.White;
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // txt_productName
            // 
            this.txt_productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_productName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_productName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_productName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_productName.BorderSize = 2;
            this.txt_productName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_productName.Location = new System.Drawing.Point(27, 337);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productName.Multiline = false;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Padding = new System.Windows.Forms.Padding(7);
            this.txt_productName.PasswordChar = false;
            this.txt_productName.Size = new System.Drawing.Size(412, 38);
            this.txt_productName.TabIndex = 2;
            this.txt_productName.Texts = "";
            this.txt_productName.UnderlinedStyle = true;
            // 
            // btn_addpro
            // 
            this.btn_addpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addpro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addpro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addpro.BorderRadius = 0;
            this.btn_addpro.BorderSize = 0;
            this.btn_addpro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addpro.FlatAppearance.BorderSize = 0;
            this.btn_addpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addpro.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addpro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_addpro.Location = new System.Drawing.Point(12, 12);
            this.btn_addpro.Name = "btn_addpro";
            this.btn_addpro.Size = new System.Drawing.Size(150, 41);
            this.btn_addpro.TabIndex = 1;
            this.btn_addpro.Text = "Add Product";
            this.btn_addpro.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_addpro.UseVisualStyleBackColor = false;
            this.btn_addpro.Click += new System.EventHandler(this.btn_addpro_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_search.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_search.BorderSize = 2;
            this.txt_search.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(761, 12);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(7);
            this.txt_search.PasswordChar = false;
            this.txt_search.Size = new System.Drawing.Size(250, 41);
            this.txt_search.TabIndex = 2;
            this.txt_search.Texts = "";
            this.txt_search.UnderlinedStyle = false;
            this.txt_search._TextChanged += new System.EventHandler(this.txt_search__TextChanged);
            // 
            // productspage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.pnl_datatable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productspage";
            this.Text = "productspage";
            this.Load += new System.EventHandler(this.productspage_Activated);
            this.pnl_datatable.ResumeLayout(false);
            this.pnl_addProduct.ResumeLayout(false);
            this.pnl_addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_datatable;
        private System.Windows.Forms.PictureBox pic_search;
        private CustomControls.RJControls.RJTextBox txt_search;
        private CustomControls.RJControls.RJButton btn_addpro;
        private System.Windows.Forms.Panel pnl_addProduct;
        private System.Windows.Forms.Label btn_close;
        private CustomControls.RJControls.RJButton btn_addProduct;
        private CustomControls.RJControls.RJTextBox txt_productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btn_browse;
        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.DataGridView dt_productTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtproductName;
        private System.Windows.Forms.DataGridViewImageColumn dtproductImage;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}