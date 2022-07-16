namespace e_Shift.userLoginForms
{
    partial class userForgot
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
            this.link_signin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_showpassword = new System.Windows.Forms.CheckBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_passwordreset = new System.Windows.Forms.Panel();
            this.btn_chkUser = new CustomControls.RJControls.RJButton();
            this.btn_passwordrst = new CustomControls.RJControls.RJButton();
            this.txt_password = new CustomControls.RJControls.RJTextBox();
            this.txt_fullname = new CustomControls.RJControls.RJTextBox();
            this.txt_username = new CustomControls.RJControls.RJTextBox();
            this.pnl_passwordreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_signin
            // 
            this.link_signin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.link_signin.AutoSize = true;
            this.link_signin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_signin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_signin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.link_signin.Location = new System.Drawing.Point(187, 85);
            this.link_signin.Name = "link_signin";
            this.link_signin.Size = new System.Drawing.Size(49, 22);
            this.link_signin.TabIndex = 3;
            this.link_signin.TabStop = true;
            this.link_signin.Text = "Signin";
            this.link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(49, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Remember password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "New Password";
            // 
            // chk_showpassword
            // 
            this.chk_showpassword.AutoSize = true;
            this.chk_showpassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.chk_showpassword.Location = new System.Drawing.Point(451, 69);
            this.chk_showpassword.Name = "chk_showpassword";
            this.chk_showpassword.Size = new System.Drawing.Size(112, 23);
            this.chk_showpassword.TabIndex = 35;
            this.chk_showpassword.Text = "Show Password";
            this.chk_showpassword.UseVisualStyleBackColor = true;
            this.chk_showpassword.CheckedChanged += new System.EventHandler(this.chk_showpassword_CheckedChanged);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Error.Location = new System.Drawing.Point(213, 179);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 19);
            this.lbl_Error.TabIndex = 38;
            // 
            // pnl_passwordreset
            // 
            this.pnl_passwordreset.Controls.Add(this.btn_passwordrst);
            this.pnl_passwordreset.Controls.Add(this.chk_showpassword);
            this.pnl_passwordreset.Controls.Add(this.txt_password);
            this.pnl_passwordreset.Controls.Add(this.label3);
            this.pnl_passwordreset.Location = new System.Drawing.Point(0, 110);
            this.pnl_passwordreset.Name = "pnl_passwordreset";
            this.pnl_passwordreset.Size = new System.Drawing.Size(600, 160);
            this.pnl_passwordreset.TabIndex = 33;
            // 
            // btn_chkUser
            // 
            this.btn_chkUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_chkUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_chkUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_chkUser.BorderRadius = 0;
            this.btn_chkUser.BorderSize = 0;
            this.btn_chkUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chkUser.FlatAppearance.BorderSize = 0;
            this.btn_chkUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chkUser.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chkUser.ForeColor = System.Drawing.Color.White;
            this.btn_chkUser.Location = new System.Drawing.Point(217, 136);
            this.btn_chkUser.Name = "btn_chkUser";
            this.btn_chkUser.Size = new System.Drawing.Size(158, 40);
            this.btn_chkUser.TabIndex = 4;
            this.btn_chkUser.Text = "Validate";
            this.btn_chkUser.TextColor = System.Drawing.Color.White;
            this.btn_chkUser.UseVisualStyleBackColor = false;
            this.btn_chkUser.Click += new System.EventHandler(this.btn_chkUser_Click);
            // 
            // btn_passwordrst
            // 
            this.btn_passwordrst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_passwordrst.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_passwordrst.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_passwordrst.BorderRadius = 0;
            this.btn_passwordrst.BorderSize = 0;
            this.btn_passwordrst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_passwordrst.FlatAppearance.BorderSize = 0;
            this.btn_passwordrst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_passwordrst.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_passwordrst.ForeColor = System.Drawing.Color.White;
            this.btn_passwordrst.Location = new System.Drawing.Point(0, 120);
            this.btn_passwordrst.Name = "btn_passwordrst";
            this.btn_passwordrst.Size = new System.Drawing.Size(600, 40);
            this.btn_passwordrst.TabIndex = 36;
            this.btn_passwordrst.Text = "Reset Password";
            this.btn_passwordrst.TextColor = System.Drawing.Color.White;
            this.btn_passwordrst.UseVisualStyleBackColor = false;
            this.btn_passwordrst.Click += new System.EventHandler(this.btn_passwordrst_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_password.Location = new System.Drawing.Point(191, 20);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_password.PasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(360, 38);
            this.txt_password.TabIndex = 34;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = true;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_fullname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_fullname.BorderSize = 2;
            this.txt_fullname.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_fullname.Location = new System.Drawing.Point(52, 40);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullname.Multiline = false;
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Padding = new System.Windows.Forms.Padding(7);
            this.txt_fullname.PasswordChar = false;
            this.txt_fullname.Size = new System.Drawing.Size(235, 38);
            this.txt_fullname.TabIndex = 1;
            this.txt_fullname.Texts = "";
            this.txt_fullname.UnderlinedStyle = true;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_username.BorderSize = 2;
            this.txt_username.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_username.Location = new System.Drawing.Point(316, 40);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(7);
            this.txt_username.PasswordChar = false;
            this.txt_username.Size = new System.Drawing.Size(235, 38);
            this.txt_username.TabIndex = 2;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = true;
            // 
            // userForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_chkUser);
            this.Controls.Add(this.pnl_passwordreset);
            this.Controls.Add(this.link_signin);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userForgot";
            this.Text = "userForgot";
            this.Load += new System.EventHandler(this.userForgot_Load);
            this.pnl_passwordreset.ResumeLayout(false);
            this.pnl_passwordreset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel link_signin;
        private CustomControls.RJControls.RJTextBox txt_fullname;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJButton btn_chkUser;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txt_password;
        private System.Windows.Forms.CheckBox chk_showpassword;
        private CustomControls.RJControls.RJButton btn_passwordrst;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Panel pnl_passwordreset;
    }
}