namespace e_Shift.admin
{
    partial class orderPending
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
            this.dt_jobTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtproductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_updatejob = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_endloc = new e_Shift.customControls.RJComboBox();
            this.btn_close1 = new System.Windows.Forms.Label();
            this.btn_update = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_startloc = new e_Shift.customControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_jobTable)).BeginInit();
            this.pnl_updatejob.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_jobTable
            // 
            this.dt_jobTable.AllowUserToAddRows = false;
            this.dt_jobTable.AllowUserToDeleteRows = false;
            this.dt_jobTable.AllowUserToResizeColumns = false;
            this.dt_jobTable.AllowUserToResizeRows = false;
            this.dt_jobTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_jobTable.BackgroundColor = System.Drawing.Color.White;
            this.dt_jobTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_jobTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_jobTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dtproductName,
            this.startloc,
            this.endloc,
            this.btnprod,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn1});
            this.dt_jobTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_jobTable.GridColor = System.Drawing.Color.White;
            this.dt_jobTable.Location = new System.Drawing.Point(0, 0);
            this.dt_jobTable.MultiSelect = false;
            this.dt_jobTable.Name = "dt_jobTable";
            this.dt_jobTable.ReadOnly = true;
            this.dt_jobTable.RowHeadersVisible = false;
            this.dt_jobTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_jobTable.RowTemplate.Height = 40;
            this.dt_jobTable.ShowEditingIcon = false;
            this.dt_jobTable.Size = new System.Drawing.Size(1000, 516);
            this.dt_jobTable.TabIndex = 5;
            this.dt_jobTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_jobTable_CellClick);
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
            // btnprod
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.btnprod.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprod.HeaderText = "";
            this.btnprod.Name = "btnprod";
            this.btnprod.ReadOnly = true;
            this.btnprod.Text = "View Products";
            this.btnprod.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn2.FillWeight = 68.4238F;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.Text = "Accept?";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewButtonColumn1.FillWeight = 77.38251F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Update";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Error.Location = new System.Drawing.Point(22, 231);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 22);
            this.lbl_Error.TabIndex = 5;
            // 
            // pnl_updatejob
            // 
            this.pnl_updatejob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_updatejob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_updatejob.Controls.Add(this.lbl_id);
            this.pnl_updatejob.Controls.Add(this.lbl_Error);
            this.pnl_updatejob.Controls.Add(this.label5);
            this.pnl_updatejob.Controls.Add(this.combo_endloc);
            this.pnl_updatejob.Controls.Add(this.btn_close1);
            this.pnl_updatejob.Controls.Add(this.btn_update);
            this.pnl_updatejob.Controls.Add(this.label6);
            this.pnl_updatejob.Controls.Add(this.combo_startloc);
            this.pnl_updatejob.Controls.Add(this.label2);
            this.pnl_updatejob.Location = new System.Drawing.Point(266, 130);
            this.pnl_updatejob.Name = "pnl_updatejob";
            this.pnl_updatejob.Size = new System.Drawing.Size(467, 298);
            this.pnl_updatejob.TabIndex = 15;
            this.pnl_updatejob.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lbl_id.Location = new System.Drawing.Point(25, 3);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 34);
            this.lbl_id.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(20, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "End Location";
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
            this.combo_endloc.Location = new System.Drawing.Point(26, 186);
            this.combo_endloc.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_endloc.Name = "combo_endloc";
            this.combo_endloc.Padding = new System.Windows.Forms.Padding(2);
            this.combo_endloc.Size = new System.Drawing.Size(412, 39);
            this.combo_endloc.TabIndex = 13;
            this.combo_endloc.Texts = "";
            // 
            // btn_close1
            // 
            this.btn_close1.AutoSize = true;
            this.btn_close1.BackColor = System.Drawing.Color.Transparent;
            this.btn_close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close1.Font = new System.Drawing.Font("Poppins Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close1.ForeColor = System.Drawing.Color.Crimson;
            this.btn_close1.Location = new System.Drawing.Point(434, 0);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Size = new System.Drawing.Size(33, 37);
            this.btn_close1.TabIndex = 5;
            this.btn_close1.Text = "X";
            this.btn_close1.Click += new System.EventHandler(this.btn_close1_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_update.BorderRadius = 0;
            this.btn_update.BorderSize = 0;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(0, 256);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(465, 40);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update Job Locations";
            this.btn_update.TextColor = System.Drawing.Color.White;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start Location";
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
            this.combo_startloc.Location = new System.Drawing.Point(26, 87);
            this.combo_startloc.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_startloc.Name = "combo_startloc";
            this.combo_startloc.Padding = new System.Windows.Forms.Padding(2);
            this.combo_startloc.Size = new System.Drawing.Size(412, 39);
            this.combo_startloc.TabIndex = 11;
            this.combo_startloc.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(27, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 5;
            // 
            // orderPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 516);
            this.Controls.Add(this.pnl_updatejob);
            this.Controls.Add(this.dt_jobTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderPending";
            this.Text = "orderPending";
            this.Load += new System.EventHandler(this.orderPending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_jobTable)).EndInit();
            this.pnl_updatejob.ResumeLayout(false);
            this.pnl_updatejob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_jobTable;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtproductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn endloc;
        private System.Windows.Forms.DataGridViewButtonColumn btnprod;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Panel pnl_updatejob;
        private System.Windows.Forms.Label label5;
        private customControls.RJComboBox combo_endloc;
        private System.Windows.Forms.Label btn_close1;
        private CustomControls.RJControls.RJButton btn_update;
        private System.Windows.Forms.Label label6;
        private customControls.RJComboBox combo_startloc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id;
    }
}