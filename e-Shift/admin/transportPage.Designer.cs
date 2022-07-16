namespace e_Shift.admin
{
    partial class transportPage
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
            this.pnl_datatable = new System.Windows.Forms.Panel();
            this.btn_all = new CustomControls.RJControls.RJButton();
            this.btn_available = new CustomControls.RJControls.RJButton();
            this.pnl_addTuni = new System.Windows.Forms.Panel();
            this.combo_status = new e_Shift.customControls.RJComboBox();
            this.combo_containertype = new e_Shift.customControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_assistant = new CustomControls.RJControls.RJTextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt_driverName = new CustomControls.RJControls.RJTextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_addTransport = new CustomControls.RJControls.RJButton();
            this.txt_lorryName = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addTunit = new CustomControls.RJControls.RJButton();
            this.dt_transportTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlorry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_datatable.SuspendLayout();
            this.pnl_addTuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_transportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_datatable
            // 
            this.pnl_datatable.Controls.Add(this.btn_all);
            this.pnl_datatable.Controls.Add(this.btn_available);
            this.pnl_datatable.Controls.Add(this.pnl_addTuni);
            this.pnl_datatable.Controls.Add(this.btn_addTunit);
            this.pnl_datatable.Controls.Add(this.dt_transportTable);
            this.pnl_datatable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_datatable.Location = new System.Drawing.Point(0, 0);
            this.pnl_datatable.Name = "pnl_datatable";
            this.pnl_datatable.Size = new System.Drawing.Size(1024, 611);
            this.pnl_datatable.TabIndex = 2;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_all.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_all.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_all.BorderRadius = 0;
            this.btn_all.BorderSize = 0;
            this.btn_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_all.Location = new System.Drawing.Point(766, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(52, 41);
            this.btn_all.TabIndex = 19;
            this.btn_all.Text = "All";
            this.btn_all.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_available
            // 
            this.btn_available.BackColor = System.Drawing.Color.White;
            this.btn_available.BackgroundColor = System.Drawing.Color.White;
            this.btn_available.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_available.BorderRadius = 0;
            this.btn_available.BorderSize = 3;
            this.btn_available.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_available.FlatAppearance.BorderSize = 0;
            this.btn_available.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_available.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_available.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_available.Location = new System.Drawing.Point(824, 12);
            this.btn_available.Name = "btn_available";
            this.btn_available.Size = new System.Drawing.Size(171, 41);
            this.btn_available.TabIndex = 18;
            this.btn_available.Text = "Available";
            this.btn_available.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_available.UseVisualStyleBackColor = false;
            this.btn_available.Click += new System.EventHandler(this.btn_available_Click);
            // 
            // pnl_addTuni
            // 
            this.pnl_addTuni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_addTuni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_addTuni.Controls.Add(this.combo_status);
            this.pnl_addTuni.Controls.Add(this.combo_containertype);
            this.pnl_addTuni.Controls.Add(this.label4);
            this.pnl_addTuni.Controls.Add(this.txt_assistant);
            this.pnl_addTuni.Controls.Add(this.lbl4);
            this.pnl_addTuni.Controls.Add(this.txt_driverName);
            this.pnl_addTuni.Controls.Add(this.lbl3);
            this.pnl_addTuni.Controls.Add(this.btn_close);
            this.pnl_addTuni.Controls.Add(this.btn_addTransport);
            this.pnl_addTuni.Controls.Add(this.txt_lorryName);
            this.pnl_addTuni.Controls.Add(this.label2);
            this.pnl_addTuni.Controls.Add(this.lbl_Error);
            this.pnl_addTuni.Controls.Add(this.label1);
            this.pnl_addTuni.Location = new System.Drawing.Point(264, 101);
            this.pnl_addTuni.Name = "pnl_addTuni";
            this.pnl_addTuni.Size = new System.Drawing.Size(467, 444);
            this.pnl_addTuni.TabIndex = 0;
            this.pnl_addTuni.Visible = false;
            // 
            // combo_status
            // 
            this.combo_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_status.BorderSize = 2;
            this.combo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_status.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_status.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.combo_status.ListBackColor = System.Drawing.Color.White;
            this.combo_status.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_status.Location = new System.Drawing.Point(27, 298);
            this.combo_status.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_status.Name = "combo_status";
            this.combo_status.Padding = new System.Windows.Forms.Padding(2);
            this.combo_status.Size = new System.Drawing.Size(253, 39);
            this.combo_status.TabIndex = 12;
            this.combo_status.Texts = "Available";
            // 
            // combo_containertype
            // 
            this.combo_containertype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_containertype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_containertype.BorderSize = 2;
            this.combo_containertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_containertype.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_containertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_containertype.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.combo_containertype.Items.AddRange(new object[] {
            "Dry storage container",
            "Flat rack container",
            "Open top container",
            "Open side storage container",
            "Refrigerated ISO containers",
            "ISO Tanks",
            "Half height containers"});
            this.combo_containertype.ListBackColor = System.Drawing.Color.White;
            this.combo_containertype.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.combo_containertype.Location = new System.Drawing.Point(27, 56);
            this.combo_containertype.MinimumSize = new System.Drawing.Size(200, 30);
            this.combo_containertype.Name = "combo_containertype";
            this.combo_containertype.Padding = new System.Windows.Forms.Padding(2);
            this.combo_containertype.Size = new System.Drawing.Size(412, 39);
            this.combo_containertype.TabIndex = 0;
            this.combo_containertype.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(21, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Container Type";
            // 
            // txt_assistant
            // 
            this.txt_assistant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_assistant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_assistant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_assistant.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_assistant.BorderSize = 2;
            this.txt_assistant.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_assistant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_assistant.Location = new System.Drawing.Point(324, 298);
            this.txt_assistant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_assistant.Multiline = false;
            this.txt_assistant.Name = "txt_assistant";
            this.txt_assistant.Padding = new System.Windows.Forms.Padding(7);
            this.txt_assistant.PasswordChar = false;
            this.txt_assistant.Size = new System.Drawing.Size(115, 38);
            this.txt_assistant.TabIndex = 3;
            this.txt_assistant.Texts = "";
            this.txt_assistant.UnderlinedStyle = true;
            this.txt_assistant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_assistant_KeyPress);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lbl4.Location = new System.Drawing.Point(318, 273);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(121, 34);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Assistants";
            // 
            // txt_driverName
            // 
            this.txt_driverName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_driverName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_driverName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_driverName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_driverName.BorderSize = 2;
            this.txt_driverName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_driverName.Location = new System.Drawing.Point(27, 209);
            this.txt_driverName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_driverName.Multiline = false;
            this.txt_driverName.Name = "txt_driverName";
            this.txt_driverName.Padding = new System.Windows.Forms.Padding(7);
            this.txt_driverName.PasswordChar = false;
            this.txt_driverName.Size = new System.Drawing.Size(412, 38);
            this.txt_driverName.TabIndex = 2;
            this.txt_driverName.Texts = "";
            this.txt_driverName.UnderlinedStyle = true;
            this.txt_driverName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_driverName_KeyPress);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lbl3.Location = new System.Drawing.Point(21, 184);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(138, 34);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Driver Name";
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
            // btn_addTransport
            // 
            this.btn_addTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addTransport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addTransport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_addTransport.BorderRadius = 0;
            this.btn_addTransport.BorderSize = 0;
            this.btn_addTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addTransport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_addTransport.FlatAppearance.BorderSize = 0;
            this.btn_addTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTransport.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTransport.ForeColor = System.Drawing.Color.White;
            this.btn_addTransport.Location = new System.Drawing.Point(0, 402);
            this.btn_addTransport.Name = "btn_addTransport";
            this.btn_addTransport.Size = new System.Drawing.Size(465, 40);
            this.btn_addTransport.TabIndex = 4;
            this.btn_addTransport.Text = "Add Transport";
            this.btn_addTransport.TextColor = System.Drawing.Color.White;
            this.btn_addTransport.UseVisualStyleBackColor = false;
            this.btn_addTransport.Click += new System.EventHandler(this.btn_addTransport_Click);
            // 
            // txt_lorryName
            // 
            this.txt_lorryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lorryName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lorryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_lorryName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_lorryName.BorderSize = 2;
            this.txt_lorryName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lorryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_lorryName.Location = new System.Drawing.Point(27, 130);
            this.txt_lorryName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lorryName.Multiline = false;
            this.txt_lorryName.Name = "txt_lorryName";
            this.txt_lorryName.Padding = new System.Windows.Forms.Padding(7);
            this.txt_lorryName.PasswordChar = false;
            this.txt_lorryName.Size = new System.Drawing.Size(412, 38);
            this.txt_lorryName.TabIndex = 1;
            this.txt_lorryName.Texts = "";
            this.txt_lorryName.UnderlinedStyle = true;
            this.txt_lorryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lorryName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lorry";
            // 
            // lbl_Error
            // 
            this.lbl_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Error.Location = new System.Drawing.Point(23, 363);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 23);
            this.lbl_Error.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(21, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status";
            // 
            // btn_addTunit
            // 
            this.btn_addTunit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addTunit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addTunit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_addTunit.BorderRadius = 0;
            this.btn_addTunit.BorderSize = 0;
            this.btn_addTunit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addTunit.FlatAppearance.BorderSize = 0;
            this.btn_addTunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTunit.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTunit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_addTunit.Location = new System.Drawing.Point(12, 12);
            this.btn_addTunit.Name = "btn_addTunit";
            this.btn_addTunit.Size = new System.Drawing.Size(201, 41);
            this.btn_addTunit.TabIndex = 1;
            this.btn_addTunit.Text = "Add Transport Unit";
            this.btn_addTunit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_addTunit.UseVisualStyleBackColor = false;
            this.btn_addTunit.Click += new System.EventHandler(this.btn_addTunit_Click);
            // 
            // dt_transportTable
            // 
            this.dt_transportTable.AllowUserToAddRows = false;
            this.dt_transportTable.AllowUserToDeleteRows = false;
            this.dt_transportTable.AllowUserToResizeColumns = false;
            this.dt_transportTable.AllowUserToResizeRows = false;
            this.dt_transportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_transportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_transportTable.BackgroundColor = System.Drawing.Color.White;
            this.dt_transportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_transportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_transportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dtlorry,
            this.drivername,
            this.Assistant,
            this.containertype,
            this.available,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dt_transportTable.GridColor = System.Drawing.Color.White;
            this.dt_transportTable.Location = new System.Drawing.Point(12, 59);
            this.dt_transportTable.MultiSelect = false;
            this.dt_transportTable.Name = "dt_transportTable";
            this.dt_transportTable.ReadOnly = true;
            this.dt_transportTable.RowHeadersVisible = false;
            this.dt_transportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_transportTable.RowTemplate.Height = 40;
            this.dt_transportTable.ShowEditingIcon = false;
            this.dt_transportTable.Size = new System.Drawing.Size(983, 520);
            this.dt_transportTable.TabIndex = 17;
            this.dt_transportTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_transportTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 49.27983F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dtlorry
            // 
            this.dtlorry.DataPropertyName = "lorry";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtlorry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtlorry.FillWeight = 102.1745F;
            this.dtlorry.HeaderText = "Lorry Brand";
            this.dtlorry.Name = "dtlorry";
            this.dtlorry.ReadOnly = true;
            // 
            // drivername
            // 
            this.drivername.DataPropertyName = "driver";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.drivername.DefaultCellStyle = dataGridViewCellStyle3;
            this.drivername.FillWeight = 80.51353F;
            this.drivername.HeaderText = "Driver Name";
            this.drivername.Name = "drivername";
            this.drivername.ReadOnly = true;
            // 
            // Assistant
            // 
            this.Assistant.DataPropertyName = "assistant";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Assistant.DefaultCellStyle = dataGridViewCellStyle4;
            this.Assistant.FillWeight = 80.51353F;
            this.Assistant.HeaderText = "Assistants";
            this.Assistant.Name = "Assistant";
            this.Assistant.ReadOnly = true;
            // 
            // containertype
            // 
            this.containertype.DataPropertyName = "containertype";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.containertype.DefaultCellStyle = dataGridViewCellStyle5;
            this.containertype.FillWeight = 223.5279F;
            this.containertype.HeaderText = "Container Type";
            this.containertype.Name = "containertype";
            this.containertype.ReadOnly = true;
            // 
            // available
            // 
            this.available.DataPropertyName = "available";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.available.DefaultCellStyle = dataGridViewCellStyle6;
            this.available.FillWeight = 80.51353F;
            this.available.HeaderText = "Status";
            this.available.Name = "available";
            this.available.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewButtonColumn1.FillWeight = 62.30339F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Update";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewButtonColumn2.FillWeight = 55.09042F;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // transportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.pnl_datatable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transportPage";
            this.Text = "transportTable";
            this.Load += new System.EventHandler(this.transportPage_Load);
            this.pnl_datatable.ResumeLayout(false);
            this.pnl_addTuni.ResumeLayout(false);
            this.pnl_addTuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_transportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_datatable;
        private System.Windows.Forms.Panel pnl_addTuni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl4;
        private CustomControls.RJControls.RJTextBox txt_driverName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label btn_close;
        private CustomControls.RJControls.RJButton btn_addTransport;
        private CustomControls.RJControls.RJTextBox txt_lorryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Error;
        private CustomControls.RJControls.RJButton btn_addTunit;
        private customControls.RJComboBox combo_containertype;
        private CustomControls.RJControls.RJTextBox txt_assistant;
        private System.Windows.Forms.DataGridView dt_transportTable;
        private CustomControls.RJControls.RJButton btn_all;
        private CustomControls.RJControls.RJButton btn_available;
        private System.Windows.Forms.Label label1;
        private customControls.RJComboBox combo_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlorry;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn containertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}