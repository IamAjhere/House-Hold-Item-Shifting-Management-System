namespace e_Shift
{
    partial class UloginForm
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
            this.chk_showpassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link_signup = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.link_forgot = new System.Windows.Forms.LinkLabel();
            this.txt_password = new CustomControls.RJControls.RJTextBox();
            this.txt_username = new CustomControls.RJControls.RJTextBox();
            this.btn_usersubmit = new CustomControls.RJControls.RJButton();
            this.lbl_userError = new System.Windows.Forms.Label();
            this.lbl_pwdError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_showpassword
            // 
            this.chk_showpassword.AutoSize = true;
            this.chk_showpassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.chk_showpassword.Location = new System.Drawing.Point(188, 188);
            this.chk_showpassword.Name = "chk_showpassword";
            this.chk_showpassword.Size = new System.Drawing.Size(112, 23);
            this.chk_showpassword.TabIndex = 16;
            this.chk_showpassword.Text = "Show Password";
            this.chk_showpassword.UseVisualStyleBackColor = true;
            this.chk_showpassword.CheckedChanged += new System.EventHandler(this.chk_showpassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(49, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // link_signup
            // 
            this.link_signup.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.link_signup.AutoSize = true;
            this.link_signup.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_signup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_signup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.link_signup.Location = new System.Drawing.Point(477, 185);
            this.link_signup.Name = "link_signup";
            this.link_signup.Size = new System.Drawing.Size(53, 22);
            this.link_signup.TabIndex = 17;
            this.link_signup.TabStop = true;
            this.link_signup.Text = "Signup";
            this.link_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signup_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(416, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "New user?";
            // 
            // link_forgot
            // 
            this.link_forgot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.link_forgot.AutoSize = true;
            this.link_forgot.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_forgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_forgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.link_forgot.Location = new System.Drawing.Point(477, 139);
            this.link_forgot.Name = "link_forgot";
            this.link_forgot.Size = new System.Drawing.Size(57, 22);
            this.link_forgot.TabIndex = 19;
            this.link_forgot.TabStop = true;
            this.link_forgot.Text = "Forgot?";
            this.link_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgot_LinkClicked);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_password.Location = new System.Drawing.Point(188, 131);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_password.PasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(335, 38);
            this.txt_password.TabIndex = 15;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = true;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_username.BorderSize = 2;
            this.txt_username.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_username.Location = new System.Drawing.Point(188, 47);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(7);
            this.txt_username.PasswordChar = false;
            this.txt_username.Size = new System.Drawing.Size(335, 38);
            this.txt_username.TabIndex = 13;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = true;
            // 
            // btn_usersubmit
            // 
            this.btn_usersubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_usersubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_usersubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_usersubmit.BorderRadius = 0;
            this.btn_usersubmit.BorderSize = 0;
            this.btn_usersubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_usersubmit.FlatAppearance.BorderSize = 0;
            this.btn_usersubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usersubmit.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usersubmit.ForeColor = System.Drawing.Color.White;
            this.btn_usersubmit.Location = new System.Drawing.Point(0, 230);
            this.btn_usersubmit.Name = "btn_usersubmit";
            this.btn_usersubmit.Size = new System.Drawing.Size(600, 40);
            this.btn_usersubmit.TabIndex = 11;
            this.btn_usersubmit.Text = "Login";
            this.btn_usersubmit.TextColor = System.Drawing.Color.White;
            this.btn_usersubmit.UseVisualStyleBackColor = false;
            this.btn_usersubmit.Click += new System.EventHandler(this.btn_usersubmit_Click);
            // 
            // lbl_userError
            // 
            this.lbl_userError.AutoSize = true;
            this.lbl_userError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_userError.Location = new System.Drawing.Point(184, 89);
            this.lbl_userError.Name = "lbl_userError";
            this.lbl_userError.Size = new System.Drawing.Size(0, 19);
            this.lbl_userError.TabIndex = 20;
            // 
            // lbl_pwdError
            // 
            this.lbl_pwdError.AutoSize = true;
            this.lbl_pwdError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwdError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwdError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_pwdError.Location = new System.Drawing.Point(184, 173);
            this.lbl_pwdError.Name = "lbl_pwdError";
            this.lbl_pwdError.Size = new System.Drawing.Size(0, 19);
            this.lbl_pwdError.TabIndex = 21;
            // 
            // UloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.lbl_pwdError);
            this.Controls.Add(this.lbl_userError);
            this.Controls.Add(this.link_forgot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_signup);
            this.Controls.Add(this.chk_showpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_usersubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UloginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.UloginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton btn_usersubmit;
        private System.Windows.Forms.CheckBox chk_showpassword;
        private CustomControls.RJControls.RJTextBox txt_password;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_forgot;
        private System.Windows.Forms.Label lbl_userError;
        private System.Windows.Forms.Label lbl_pwdError;
    }
}