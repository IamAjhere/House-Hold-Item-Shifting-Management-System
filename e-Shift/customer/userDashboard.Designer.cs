namespace e_Shift.customer
{
    partial class userDashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_profileSettings = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_jobhistory = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_jobs = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnl_form.TabIndex = 4;
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
            this.gradientPanel2.TabIndex = 5;
            this.gradientPanel2.topcolor = System.Drawing.Color.Empty;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.lbl_header.Location = new System.Drawing.Point(6, 2);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(320, 48);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Customer Dashboard";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_logout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_logout.BorderRadius = 6;
            this.btn_logout.BorderSize = 0;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(160, 661);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.topcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_profileSettings);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel4.Size = new System.Drawing.Size(160, 75);
            this.panel4.TabIndex = 5;
            // 
            // btn_profileSettings
            // 
            this.btn_profileSettings.BackColor = System.Drawing.Color.Transparent;
            this.btn_profileSettings.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_profileSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_profileSettings.BorderRadius = 0;
            this.btn_profileSettings.BorderSize = 1;
            this.btn_profileSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profileSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profileSettings.FlatAppearance.BorderSize = 0;
            this.btn_profileSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profileSettings.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profileSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_profileSettings.Image = global::e_Shift.Properties.Resources.icons8_gear_50;
            this.btn_profileSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profileSettings.Location = new System.Drawing.Point(5, 2);
            this.btn_profileSettings.Name = "btn_profileSettings";
            this.btn_profileSettings.Size = new System.Drawing.Size(154, 68);
            this.btn_profileSettings.TabIndex = 0;
            this.btn_profileSettings.Text = "Settings";
            this.btn_profileSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_profileSettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_profileSettings.UseVisualStyleBackColor = false;
            this.btn_profileSettings.Click += new System.EventHandler(this.btn_profileSettings_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_jobhistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel3.Size = new System.Drawing.Size(160, 75);
            this.panel3.TabIndex = 4;
            // 
            // btn_jobhistory
            // 
            this.btn_jobhistory.BackColor = System.Drawing.Color.Transparent;
            this.btn_jobhistory.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_jobhistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_jobhistory.BorderRadius = 0;
            this.btn_jobhistory.BorderSize = 1;
            this.btn_jobhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jobhistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_jobhistory.FlatAppearance.BorderSize = 0;
            this.btn_jobhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jobhistory.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jobhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_jobhistory.Image = global::e_Shift.Properties.Resources.order_history;
            this.btn_jobhistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_jobhistory.Location = new System.Drawing.Point(5, 2);
            this.btn_jobhistory.Name = "btn_jobhistory";
            this.btn_jobhistory.Size = new System.Drawing.Size(154, 68);
            this.btn_jobhistory.TabIndex = 0;
            this.btn_jobhistory.Text = "Job History";
            this.btn_jobhistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_jobhistory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_jobhistory.UseVisualStyleBackColor = false;
            this.btn_jobhistory.Click += new System.EventHandler(this.btn_jobhistory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_jobs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.panel2.Size = new System.Drawing.Size(160, 75);
            this.panel2.TabIndex = 3;
            // 
            // btn_jobs
            // 
            this.btn_jobs.BackColor = System.Drawing.Color.Transparent;
            this.btn_jobs.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_jobs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_jobs.BorderRadius = 0;
            this.btn_jobs.BorderSize = 1;
            this.btn_jobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jobs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_jobs.FlatAppearance.BorderSize = 0;
            this.btn_jobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jobs.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_jobs.Image = global::e_Shift.Properties.Resources.create_order;
            this.btn_jobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_jobs.Location = new System.Drawing.Point(5, 2);
            this.btn_jobs.Name = "btn_jobs";
            this.btn_jobs.Size = new System.Drawing.Size(154, 68);
            this.btn_jobs.TabIndex = 0;
            this.btn_jobs.Text = "New Job";
            this.btn_jobs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_jobs.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_jobs.UseVisualStyleBackColor = false;
            this.btn_jobs.Click += new System.EventHandler(this.btn_newjob_Click);
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
            // userDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.userDashboard_Load);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_form;
        private customControls.gradientPanel gradientPanel2;
        private System.Windows.Forms.Label lbl_header;
        private CustomControls.RJControls.RJButton btn_logout;
        private customControls.gradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton btn_jobhistory;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btn_jobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.RJControls.RJButton btn_profileSettings;
    }
}