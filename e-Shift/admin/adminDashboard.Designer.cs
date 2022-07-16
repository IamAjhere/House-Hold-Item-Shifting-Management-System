namespace e_Shift.admin
{
    partial class adminDashboard
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
            this.pnl_form = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new e_Shift.customControls.gradientPanel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_logout = new CustomControls.RJControls.RJButton();
            this.gradientPanel1 = new e_Shift.customControls.gradientPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_users = new CustomControls.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_allJobs = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_transport = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_products = new CustomControls.RJControls.RJButton();
            this.prd_btnpnl = new System.Windows.Forms.Panel();
            this.btn_home = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.prd_btnpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_form
            // 
            this.pnl_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_form.Location = new System.Drawing.Point(160, 50);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Padding = new System.Windows.Forms.Padding(7);
            this.pnl_form.Size = new System.Drawing.Size(1024, 611);
            this.pnl_form.TabIndex = 1;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.gradientPanel2.botColor = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.lbl_header);
            this.gradientPanel2.Controls.Add(this.btn_logout);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.Location = new System.Drawing.Point(160, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1024, 50);
            this.gradientPanel2.TabIndex = 2;
            this.gradientPanel2.topcolor = System.Drawing.Color.Empty;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.lbl_header.Location = new System.Drawing.Point(6, 2);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(273, 48);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Admin Dashboard";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_logout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_logout.BorderRadius = 6;
            this.btn_logout.BorderSize = 0;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::e_Shift.Properties.Resources.logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(889, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(114, 40);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.TextColor = System.Drawing.Color.White;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 270F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.botColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.gradientPanel1.Controls.Add(this.panel5);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.prd_btnpnl);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(160, 661);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.topcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_users);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 350);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel5.Size = new System.Drawing.Size(160, 75);
            this.panel5.TabIndex = 5;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.Transparent;
            this.btn_users.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_users.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_users.BorderRadius = 0;
            this.btn_users.BorderSize = 1;
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_users.Image = global::e_Shift.Properties.Resources.users;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users.Location = new System.Drawing.Point(5, 2);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(154, 68);
            this.btn_users.TabIndex = 1;
            this.btn_users.Text = "All Users";
            this.btn_users.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_allJobs);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 275);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel4.Size = new System.Drawing.Size(160, 75);
            this.panel4.TabIndex = 6;
            // 
            // btn_allJobs
            // 
            this.btn_allJobs.BackColor = System.Drawing.Color.Transparent;
            this.btn_allJobs.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_allJobs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_allJobs.BorderRadius = 0;
            this.btn_allJobs.BorderSize = 1;
            this.btn_allJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allJobs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_allJobs.FlatAppearance.BorderSize = 0;
            this.btn_allJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allJobs.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_allJobs.Image = global::e_Shift.Properties.Resources.orders1;
            this.btn_allJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_allJobs.Location = new System.Drawing.Point(5, 2);
            this.btn_allJobs.Name = "btn_allJobs";
            this.btn_allJobs.Size = new System.Drawing.Size(154, 68);
            this.btn_allJobs.TabIndex = 0;
            this.btn_allJobs.Text = "All Jobs";
            this.btn_allJobs.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_allJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_allJobs.UseVisualStyleBackColor = false;
            this.btn_allJobs.Click += new System.EventHandler(this.btn_allJobs_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_transport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel3.Size = new System.Drawing.Size(160, 75);
            this.panel3.TabIndex = 4;
            // 
            // btn_transport
            // 
            this.btn_transport.BackColor = System.Drawing.Color.Transparent;
            this.btn_transport.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_transport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_transport.BorderRadius = 0;
            this.btn_transport.BorderSize = 1;
            this.btn_transport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_transport.FlatAppearance.BorderSize = 0;
            this.btn_transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transport.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_transport.Image = global::e_Shift.Properties.Resources.TransportAdd;
            this.btn_transport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transport.Location = new System.Drawing.Point(5, 2);
            this.btn_transport.Name = "btn_transport";
            this.btn_transport.Size = new System.Drawing.Size(154, 68);
            this.btn_transport.TabIndex = 0;
            this.btn_transport.Text = "Transport";
            this.btn_transport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_transport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_transport.UseVisualStyleBackColor = false;
            this.btn_transport.Click += new System.EventHandler(this.btn_transport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_products);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel2.Size = new System.Drawing.Size(160, 75);
            this.panel2.TabIndex = 3;
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.Color.Transparent;
            this.btn_products.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_products.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_products.BorderRadius = 0;
            this.btn_products.BorderSize = 1;
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_products.Image = global::e_Shift.Properties.Resources.products;
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(5, 2);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(154, 68);
            this.btn_products.TabIndex = 0;
            this.btn_products.Text = "Products";
            this.btn_products.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_products.UseVisualStyleBackColor = false;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // prd_btnpnl
            // 
            this.prd_btnpnl.Controls.Add(this.btn_home);
            this.prd_btnpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.prd_btnpnl.Location = new System.Drawing.Point(0, 50);
            this.prd_btnpnl.Name = "prd_btnpnl";
            this.prd_btnpnl.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.prd_btnpnl.Size = new System.Drawing.Size(160, 75);
            this.prd_btnpnl.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_home.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_home.BorderRadius = 0;
            this.btn_home.BorderSize = 1;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_home.Image = global::e_Shift.Properties.Resources.Home;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(5, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(154, 68);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "e-Shift";
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.prd_btnpnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customControls.gradientPanel gradientPanel1;
        private customControls.gradientPanel gradientPanel2;
        private System.Windows.Forms.Panel pnl_form;
        private CustomControls.RJControls.RJButton btn_logout;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel prd_btnpnl;
        private CustomControls.RJControls.RJButton btn_home;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton btn_transport;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btn_products;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.RJControls.RJButton btn_allJobs;
        private CustomControls.RJControls.RJButton btn_users;
    }
}