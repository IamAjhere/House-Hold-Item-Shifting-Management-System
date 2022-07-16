namespace e_Shift.admin
{
    partial class allOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_orders = new System.Windows.Forms.Panel();
            this.dt_alljobsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtproductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_showProducts = new System.Windows.Forms.Panel();
            this.dt_productOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Label();
            this.pnl_forloads = new System.Windows.Forms.Panel();
            this.btn_dbCreateload = new CustomControls.RJControls.RJButton();
            this.dt_loadTransport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivername = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.combo_noLoads = new e_Shift.customControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_jobid = new e_Shift.customControls.RJComboBox();
            this.btn_loadclose = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_alljobs = new CustomControls.RJControls.RJButton();
            this.btn_createload = new CustomControls.RJControls.RJButton();
            this.btn_orderspend = new CustomControls.RJControls.RJButton();
            this.pnl_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_alljobsTable)).BeginInit();
            this.pnl_showProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productOrder)).BeginInit();
            this.pnl_forloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_loadTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_orders
            // 
            this.pnl_orders.BackColor = System.Drawing.Color.White;
            this.pnl_orders.Controls.Add(this.dt_alljobsTable);
            this.pnl_orders.Location = new System.Drawing.Point(4, 52);
            this.pnl_orders.Name = "pnl_orders";
            this.pnl_orders.Size = new System.Drawing.Size(1015, 547);
            this.pnl_orders.TabIndex = 21;
            // 
            // dt_alljobsTable
            // 
            this.dt_alljobsTable.AllowUserToAddRows = false;
            this.dt_alljobsTable.AllowUserToDeleteRows = false;
            this.dt_alljobsTable.AllowUserToResizeColumns = false;
            this.dt_alljobsTable.AllowUserToResizeRows = false;
            this.dt_alljobsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_alljobsTable.BackgroundColor = System.Drawing.Color.White;
            this.dt_alljobsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_alljobsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_alljobsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dtproductName,
            this.startloc,
            this.endloc,
            this.stats,
            this.btnprod,
            this.dataGridViewButtonColumn1});
            this.dt_alljobsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_alljobsTable.GridColor = System.Drawing.Color.White;
            this.dt_alljobsTable.Location = new System.Drawing.Point(0, 0);
            this.dt_alljobsTable.MultiSelect = false;
            this.dt_alljobsTable.Name = "dt_alljobsTable";
            this.dt_alljobsTable.ReadOnly = true;
            this.dt_alljobsTable.RowHeadersVisible = false;
            this.dt_alljobsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_alljobsTable.RowTemplate.Height = 40;
            this.dt_alljobsTable.ShowEditingIcon = false;
            this.dt_alljobsTable.Size = new System.Drawing.Size(1015, 547);
            this.dt_alljobsTable.TabIndex = 6;
            this.dt_alljobsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_alljobsTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 61.20689F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Job ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dtproductName
            // 
            this.dtproductName.DataPropertyName = "fullname";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtproductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtproductName.FillWeight = 126.9035F;
            this.dtproductName.HeaderText = "Customer Name";
            this.dtproductName.Name = "dtproductName";
            this.dtproductName.ReadOnly = true;
            // 
            // startloc
            // 
            this.startloc.DataPropertyName = "startloc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.startloc.DefaultCellStyle = dataGridViewCellStyle3;
            this.startloc.HeaderText = "Start Location";
            this.startloc.Name = "startloc";
            this.startloc.ReadOnly = true;
            // 
            // endloc
            // 
            this.endloc.DataPropertyName = "endloc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.endloc.DefaultCellStyle = dataGridViewCellStyle4;
            this.endloc.HeaderText = "End Location";
            this.endloc.Name = "endloc";
            this.endloc.ReadOnly = true;
            // 
            // stats
            // 
            this.stats.DataPropertyName = "accept";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.stats.DefaultCellStyle = dataGridViewCellStyle5;
            this.stats.HeaderText = "Status";
            this.stats.Name = "stats";
            this.stats.ReadOnly = true;
            // 
            // btnprod
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.btnprod.DefaultCellStyle = dataGridViewCellStyle6;
            this.btnprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprod.HeaderText = "";
            this.btnprod.Name = "btnprod";
            this.btnprod.ReadOnly = true;
            this.btnprod.Text = "View Products";
            this.btnprod.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewButtonColumn1.FillWeight = 77.38251F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // pnl_showProducts
            // 
            this.pnl_showProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_showProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_showProducts.Controls.Add(this.dt_productOrder);
            this.pnl_showProducts.Controls.Add(this.btn_close);
            this.pnl_showProducts.Location = new System.Drawing.Point(285, 95);
            this.pnl_showProducts.Name = "pnl_showProducts";
            this.pnl_showProducts.Size = new System.Drawing.Size(467, 456);
            this.pnl_showProducts.TabIndex = 22;
            this.pnl_showProducts.Visible = false;
            this.pnl_showProducts.Leave += new System.EventHandler(this.btn_close_Click);
            // 
            // dt_productOrder
            // 
            this.dt_productOrder.AllowUserToAddRows = false;
            this.dt_productOrder.AllowUserToDeleteRows = false;
            this.dt_productOrder.AllowUserToResizeColumns = false;
            this.dt_productOrder.AllowUserToResizeRows = false;
            this.dt_productOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_productOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_productOrder.BackgroundColor = System.Drawing.Color.White;
            this.dt_productOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_productOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_productOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dt_productOrder.GridColor = System.Drawing.Color.White;
            this.dt_productOrder.Location = new System.Drawing.Point(8, 39);
            this.dt_productOrder.MultiSelect = false;
            this.dt_productOrder.Name = "dt_productOrder";
            this.dt_productOrder.ReadOnly = true;
            this.dt_productOrder.RowHeadersVisible = false;
            this.dt_productOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_productOrder.RowTemplate.Height = 40;
            this.dt_productOrder.ShowEditingIcon = false;
            this.dt_productOrder.Size = new System.Drawing.Size(448, 396);
            this.dt_productOrder.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productid";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.FillWeight = 52.61168F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "productname";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.FillWeight = 232.8067F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.FillWeight = 41.48522F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // pnl_forloads
            // 
            this.pnl_forloads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_forloads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_forloads.Controls.Add(this.btn_dbCreateload);
            this.pnl_forloads.Controls.Add(this.dt_loadTransport);
            this.pnl_forloads.Controls.Add(this.combo_noLoads);
            this.pnl_forloads.Controls.Add(this.label1);
            this.pnl_forloads.Controls.Add(this.combo_jobid);
            this.pnl_forloads.Controls.Add(this.btn_loadclose);
            this.pnl_forloads.Controls.Add(this.label6);
            this.pnl_forloads.Location = new System.Drawing.Point(103, 80);
            this.pnl_forloads.Name = "pnl_forloads";
            this.pnl_forloads.Size = new System.Drawing.Size(799, 471);
            this.pnl_forloads.TabIndex = 23;
            this.pnl_forloads.Visible = false;
            // 
            // btn_dbCreateload
            // 
            this.btn_dbCreateload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_dbCreateload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_dbCreateload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_dbCreateload.BorderRadius = 0;
            this.btn_dbCreateload.BorderSize = 1;
            this.btn_dbCreateload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dbCreateload.FlatAppearance.BorderSize = 0;
            this.btn_dbCreateload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dbCreateload.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dbCreateload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_dbCreateload.Location = new System.Drawing.Point(588, 52);
            this.btn_dbCreateload.Name = "btn_dbCreateload";
            this.btn_dbCreateload.Size = new System.Drawing.Size(121, 41);
            this.btn_dbCreateload.TabIndex = 28;
            this.btn_dbCreateload.Text = "Create Loads";
            this.btn_dbCreateload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dbCreateload.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_dbCreateload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dbCreateload.UseVisualStyleBackColor = false;
            this.btn_dbCreateload.Click += new System.EventHandler(this.btn_dbCreateload_Click);
            // 
            // dt_loadTransport
            // 
            this.dt_loadTransport.AllowUserToAddRows = false;
            this.dt_loadTransport.AllowUserToDeleteRows = false;
            this.dt_loadTransport.AllowUserToResizeColumns = false;
            this.dt_loadTransport.AllowUserToResizeRows = false;
            this.dt_loadTransport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_loadTransport.BackgroundColor = System.Drawing.Color.White;
            this.dt_loadTransport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_loadTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_loadTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.drivername});
            this.dt_loadTransport.GridColor = System.Drawing.Color.White;
            this.dt_loadTransport.Location = new System.Drawing.Point(14, 99);
            this.dt_loadTransport.MultiSelect = false;
            this.dt_loadTransport.Name = "dt_loadTransport";
            this.dt_loadTransport.RowHeadersVisible = false;
            this.dt_loadTransport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_loadTransport.RowTemplate.Height = 40;
            this.dt_loadTransport.Size = new System.Drawing.Size(766, 351);
            this.dt_loadTransport.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.FillWeight = 61.20689F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Load No.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // drivername
            // 
            this.drivername.DataPropertyName = "drivername";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.drivername.DefaultCellStyle = dataGridViewCellStyle12;
            this.drivername.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.drivername.HeaderText = "Driver Name";
            this.drivername.Name = "drivername";
            this.drivername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // combo_noLoads
            // 
            this.combo_noLoads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_noLoads.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_noLoads.BorderSize = 2;
            this.combo_noLoads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_noLoads.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_noLoads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_noLoads.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_noLoads.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combo_noLoads.ListBackColor = System.Drawing.Color.White;
            this.combo_noLoads.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_noLoads.Location = new System.Drawing.Point(258, 54);
            this.combo_noLoads.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_noLoads.Name = "combo_noLoads";
            this.combo_noLoads.Padding = new System.Windows.Forms.Padding(2);
            this.combo_noLoads.Size = new System.Drawing.Size(229, 39);
            this.combo_noLoads.TabIndex = 26;
            this.combo_noLoads.Texts = "";
            this.combo_noLoads.OnSelectedIndexChanged += new System.EventHandler(this.combo_noLoads_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(252, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Number of Loads";
            // 
            // combo_jobid
            // 
            this.combo_jobid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_jobid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_jobid.BorderSize = 2;
            this.combo_jobid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_jobid.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_jobid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_jobid.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_jobid.ListBackColor = System.Drawing.Color.White;
            this.combo_jobid.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_jobid.Location = new System.Drawing.Point(14, 54);
            this.combo_jobid.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_jobid.Name = "combo_jobid";
            this.combo_jobid.Padding = new System.Windows.Forms.Padding(2);
            this.combo_jobid.Size = new System.Drawing.Size(229, 39);
            this.combo_jobid.TabIndex = 7;
            this.combo_jobid.Texts = "";
            // 
            // btn_loadclose
            // 
            this.btn_loadclose.AutoSize = true;
            this.btn_loadclose.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadclose.Font = new System.Drawing.Font("Poppins Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadclose.ForeColor = System.Drawing.Color.Crimson;
            this.btn_loadclose.Location = new System.Drawing.Point(761, 0);
            this.btn_loadclose.Name = "btn_loadclose";
            this.btn_loadclose.Size = new System.Drawing.Size(33, 37);
            this.btn_loadclose.TabIndex = 6;
            this.btn_loadclose.Text = "X";
            this.btn_loadclose.Click += new System.EventHandler(this.btn_loadclose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "Job ID";
            // 
            // btn_alljobs
            // 
            this.btn_alljobs.BackColor = System.Drawing.Color.White;
            this.btn_alljobs.BackgroundColor = System.Drawing.Color.White;
            this.btn_alljobs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_alljobs.BorderRadius = 0;
            this.btn_alljobs.BorderSize = 3;
            this.btn_alljobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alljobs.FlatAppearance.BorderSize = 0;
            this.btn_alljobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alljobs.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alljobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_alljobs.Location = new System.Drawing.Point(181, 5);
            this.btn_alljobs.Name = "btn_alljobs";
            this.btn_alljobs.Size = new System.Drawing.Size(57, 41);
            this.btn_alljobs.TabIndex = 23;
            this.btn_alljobs.Text = "ALL";
            this.btn_alljobs.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_alljobs.UseVisualStyleBackColor = false;
            this.btn_alljobs.Click += new System.EventHandler(this.btn_alljobs_Click);
            // 
            // btn_createload
            // 
            this.btn_createload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_createload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_createload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_createload.BorderRadius = 0;
            this.btn_createload.BorderSize = 1;
            this.btn_createload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createload.FlatAppearance.BorderSize = 0;
            this.btn_createload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createload.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_createload.Image = global::e_Shift.Properties.Resources.small_transport;
            this.btn_createload.Location = new System.Drawing.Point(848, 5);
            this.btn_createload.Name = "btn_createload";
            this.btn_createload.Size = new System.Drawing.Size(171, 41);
            this.btn_createload.TabIndex = 20;
            this.btn_createload.Text = "Create Loads";
            this.btn_createload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createload.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_createload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_createload.UseVisualStyleBackColor = false;
            this.btn_createload.Click += new System.EventHandler(this.btn_createload_Click);
            // 
            // btn_orderspend
            // 
            this.btn_orderspend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_orderspend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_orderspend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_orderspend.BorderRadius = 0;
            this.btn_orderspend.BorderSize = 1;
            this.btn_orderspend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orderspend.FlatAppearance.BorderSize = 0;
            this.btn_orderspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderspend.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderspend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_orderspend.Image = global::e_Shift.Properties.Resources.small_pending_order;
            this.btn_orderspend.Location = new System.Drawing.Point(4, 5);
            this.btn_orderspend.Name = "btn_orderspend";
            this.btn_orderspend.Size = new System.Drawing.Size(171, 41);
            this.btn_orderspend.TabIndex = 19;
            this.btn_orderspend.Text = "Pending Jobs";
            this.btn_orderspend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_orderspend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_orderspend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_orderspend.UseVisualStyleBackColor = false;
            this.btn_orderspend.Click += new System.EventHandler(this.btn_orderspend_Click);
            // 
            // allOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.pnl_forloads);
            this.Controls.Add(this.btn_alljobs);
            this.Controls.Add(this.pnl_showProducts);
            this.Controls.Add(this.pnl_orders);
            this.Controls.Add(this.btn_createload);
            this.Controls.Add(this.btn_orderspend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "allOrders";
            this.Text = "allOrders";
            this.Load += new System.EventHandler(this.allOrders_Load);
            this.pnl_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_alljobsTable)).EndInit();
            this.pnl_showProducts.ResumeLayout(false);
            this.pnl_showProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productOrder)).EndInit();
            this.pnl_forloads.ResumeLayout(false);
            this.pnl_forloads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_loadTransport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton btn_orderspend;
        private CustomControls.RJControls.RJButton btn_createload;
        private System.Windows.Forms.Panel pnl_orders;
        private System.Windows.Forms.DataGridView dt_alljobsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtproductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn endloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stats;
        private System.Windows.Forms.DataGridViewButtonColumn btnprod;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Panel pnl_showProducts;
        private System.Windows.Forms.DataGridView dt_productOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label btn_close;
        private CustomControls.RJControls.RJButton btn_alljobs;
        private System.Windows.Forms.Panel pnl_forloads;
        private System.Windows.Forms.Label btn_loadclose;
        private customControls.RJComboBox combo_jobid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_loadTransport;
        private customControls.RJComboBox combo_noLoads;
        private CustomControls.RJControls.RJButton btn_dbCreateload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn drivername;
    }
}