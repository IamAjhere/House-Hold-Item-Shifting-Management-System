namespace e_Shift.customer
{
    partial class jobHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_showProducts = new System.Windows.Forms.Panel();
            this.dt_productOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Label();
            this.dt_alljobsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_showProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_alljobsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_showProducts
            // 
            this.pnl_showProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_showProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_showProducts.Controls.Add(this.dt_productOrder);
            this.pnl_showProducts.Controls.Add(this.btn_close);
            this.pnl_showProducts.Location = new System.Drawing.Point(279, 77);
            this.pnl_showProducts.Name = "pnl_showProducts";
            this.pnl_showProducts.Size = new System.Drawing.Size(467, 456);
            this.pnl_showProducts.TabIndex = 25;
            this.pnl_showProducts.Visible = false;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn3.FillWeight = 52.61168F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "productname";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn4.FillWeight = 232.8067F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle27;
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
            this.startloc,
            this.endloc,
            this.stats,
            this.btnprod});
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
            this.dt_alljobsTable.Size = new System.Drawing.Size(1024, 611);
            this.dt_alljobsTable.TabIndex = 24;
            this.dt_alljobsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_alljobsTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn1.FillWeight = 61.20689F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Job ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // startloc
            // 
            this.startloc.DataPropertyName = "startloc";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.startloc.DefaultCellStyle = dataGridViewCellStyle29;
            this.startloc.HeaderText = "Start Location";
            this.startloc.Name = "startloc";
            this.startloc.ReadOnly = true;
            // 
            // endloc
            // 
            this.endloc.DataPropertyName = "endloc";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.endloc.DefaultCellStyle = dataGridViewCellStyle30;
            this.endloc.HeaderText = "End Location";
            this.endloc.Name = "endloc";
            this.endloc.ReadOnly = true;
            // 
            // stats
            // 
            this.stats.DataPropertyName = "accept";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.stats.DefaultCellStyle = dataGridViewCellStyle31;
            this.stats.HeaderText = "Status";
            this.stats.Name = "stats";
            this.stats.ReadOnly = true;
            // 
            // btnprod
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.btnprod.DefaultCellStyle = dataGridViewCellStyle32;
            this.btnprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprod.HeaderText = "";
            this.btnprod.Name = "btnprod";
            this.btnprod.ReadOnly = true;
            this.btnprod.Text = "View Products";
            this.btnprod.UseColumnTextForButtonValue = true;
            // 
            // jobHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.pnl_showProducts);
            this.Controls.Add(this.dt_alljobsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jobHistory";
            this.Text = "jobHistory";
            this.Load += new System.EventHandler(this.jobHistory_Load);
            this.pnl_showProducts.ResumeLayout(false);
            this.pnl_showProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_alljobsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_showProducts;
        private System.Windows.Forms.DataGridView dt_productOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.DataGridView dt_alljobsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn endloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stats;
        private System.Windows.Forms.DataGridViewButtonColumn btnprod;
    }
}