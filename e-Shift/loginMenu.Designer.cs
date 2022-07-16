namespace e_Shift
{
    partial class loginMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.btn_userlogin = new System.Windows.Forms.Button();
            this.btn_adminlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Account Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_form
            // 
            this.pnl_form.BackColor = System.Drawing.Color.Transparent;
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_form.Location = new System.Drawing.Point(0, 287);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(584, 350);
            this.pnl_form.TabIndex = 3;
            // 
            // btn_userlogin
            // 
            this.btn_userlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_userlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.btn_userlogin.FlatAppearance.BorderSize = 2;
            this.btn_userlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_userlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btn_userlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userlogin.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_userlogin.Image = global::e_Shift.Properties.Resources.MinUser;
            this.btn_userlogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_userlogin.Location = new System.Drawing.Point(332, 104);
            this.btn_userlogin.Name = "btn_userlogin";
            this.btn_userlogin.Size = new System.Drawing.Size(200, 170);
            this.btn_userlogin.TabIndex = 1;
            this.btn_userlogin.Text = "User Login";
            this.btn_userlogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_userlogin.UseVisualStyleBackColor = true;
            this.btn_userlogin.Click += new System.EventHandler(this.btn_userlogin_Click);
            // 
            // btn_adminlogin
            // 
            this.btn_adminlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_adminlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_adminlogin.FlatAppearance.BorderSize = 2;
            this.btn_adminlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_adminlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btn_adminlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminlogin.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btn_adminlogin.Image = global::e_Shift.Properties.Resources.MinAdmin;
            this.btn_adminlogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_adminlogin.Location = new System.Drawing.Point(51, 104);
            this.btn_adminlogin.Name = "btn_adminlogin";
            this.btn_adminlogin.Size = new System.Drawing.Size(200, 170);
            this.btn_adminlogin.TabIndex = 0;
            this.btn_adminlogin.Text = "Admin Login";
            this.btn_adminlogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_adminlogin.UseVisualStyleBackColor = true;
            this.btn_adminlogin.Click += new System.EventHandler(this.btn_adminlogin_Click);
            // 
            // loginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 637);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_userlogin);
            this.Controls.Add(this.btn_adminlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "loginMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shift";
            this.Load += new System.EventHandler(this.loginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adminlogin;
        private System.Windows.Forms.Button btn_userlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_form;
    }
}

