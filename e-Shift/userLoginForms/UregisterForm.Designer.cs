namespace e_Shift.userLogin
{
    partial class UregisterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.link_signin = new System.Windows.Forms.LinkLabel();
            this.chk_showpassword = new System.Windows.Forms.CheckBox();
            this.lbl_pwdError = new System.Windows.Forms.Label();
            this.lbl_formError = new System.Windows.Forms.Label();
            this.lbl_nameError = new System.Windows.Forms.Label();
            this.lbl_userError = new System.Windows.Forms.Label();
            this.btn_reset = new CustomControls.RJControls.RJButton();
            this.btn_userregister = new CustomControls.RJControls.RJButton();
            this.date_userbirthday = new e_Shift.RJDatePicker();
            this.txt_fullname = new CustomControls.RJControls.RJTextBox();
            this.txt_password = new CustomControls.RJControls.RJTextBox();
            this.txt_username = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(388, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Already registered?";
            // 
            // link_signin
            // 
            this.link_signin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.link_signin.AutoSize = true;
            this.link_signin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_signin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_signin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.link_signin.Location = new System.Drawing.Point(498, 196);
            this.link_signin.Name = "link_signin";
            this.link_signin.Size = new System.Drawing.Size(49, 22);
            this.link_signin.TabIndex = 6;
            this.link_signin.TabStop = true;
            this.link_signin.Text = "Signin";
            this.link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signin_LinkClicked);
            // 
            // chk_showpassword
            // 
            this.chk_showpassword.AutoSize = true;
            this.chk_showpassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.chk_showpassword.Location = new System.Drawing.Point(439, 121);
            this.chk_showpassword.Name = "chk_showpassword";
            this.chk_showpassword.Size = new System.Drawing.Size(112, 23);
            this.chk_showpassword.TabIndex = 5;
            this.chk_showpassword.Text = "Show Password";
            this.chk_showpassword.UseVisualStyleBackColor = true;
            this.chk_showpassword.CheckedChanged += new System.EventHandler(this.chk_showpassword_CheckedChanged);
            // 
            // lbl_pwdError
            // 
            this.lbl_pwdError.AutoSize = true;
            this.lbl_pwdError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwdError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwdError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_pwdError.Location = new System.Drawing.Point(302, 182);
            this.lbl_pwdError.Name = "lbl_pwdError";
            this.lbl_pwdError.Size = new System.Drawing.Size(0, 19);
            this.lbl_pwdError.TabIndex = 23;
            // 
            // lbl_formError
            // 
            this.lbl_formError.AutoSize = true;
            this.lbl_formError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_formError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_formError.Location = new System.Drawing.Point(235, 10);
            this.lbl_formError.Name = "lbl_formError";
            this.lbl_formError.Size = new System.Drawing.Size(0, 19);
            this.lbl_formError.TabIndex = 24;
            this.lbl_formError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameError
            // 
            this.lbl_nameError.AutoSize = true;
            this.lbl_nameError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nameError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_nameError.Location = new System.Drawing.Point(48, 99);
            this.lbl_nameError.Name = "lbl_nameError";
            this.lbl_nameError.Size = new System.Drawing.Size(0, 19);
            this.lbl_nameError.TabIndex = 25;
            // 
            // lbl_userError
            // 
            this.lbl_userError.AutoSize = true;
            this.lbl_userError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_userError.Location = new System.Drawing.Point(48, 186);
            this.lbl_userError.Name = "lbl_userError";
            this.lbl_userError.Size = new System.Drawing.Size(0, 19);
            this.lbl_userError.TabIndex = 26;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.BackgroundColor = System.Drawing.Color.White;
            this.btn_reset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_reset.BorderRadius = 10;
            this.btn_reset.BorderSize = 2;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_reset.Location = new System.Drawing.Point(463, 10);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(88, 31);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_userregister
            // 
            this.btn_userregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_userregister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_userregister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_userregister.BorderRadius = 0;
            this.btn_userregister.BorderSize = 0;
            this.btn_userregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userregister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_userregister.FlatAppearance.BorderSize = 0;
            this.btn_userregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userregister.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userregister.ForeColor = System.Drawing.Color.White;
            this.btn_userregister.Location = new System.Drawing.Point(0, 230);
            this.btn_userregister.Name = "btn_userregister";
            this.btn_userregister.Size = new System.Drawing.Size(600, 40);
            this.btn_userregister.TabIndex = 7;
            this.btn_userregister.Text = "Register";
            this.btn_userregister.TextColor = System.Drawing.Color.White;
            this.btn_userregister.UseVisualStyleBackColor = false;
            this.btn_userregister.Click += new System.EventHandler(this.btn_userregister_Click);
            // 
            // date_userbirthday
            // 
            this.date_userbirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.date_userbirthday.BorderSize = 2;
            this.date_userbirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_userbirthday.CustomFormat = "yyyy-M-dd";
            this.date_userbirthday.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_userbirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_userbirthday.Location = new System.Drawing.Point(305, 60);
            this.date_userbirthday.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.date_userbirthday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.date_userbirthday.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_userbirthday.Name = "date_userbirthday";
            this.date_userbirthday.Size = new System.Drawing.Size(245, 35);
            this.date_userbirthday.SkinColor = System.Drawing.Color.White;
            this.date_userbirthday.TabIndex = 2;
            this.date_userbirthday.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.date_userbirthday.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_fullname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_fullname.BorderSize = 2;
            this.txt_fullname.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_fullname.Location = new System.Drawing.Point(52, 57);
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
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_password.Location = new System.Drawing.Point(306, 144);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_password.PasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(245, 38);
            this.txt_password.TabIndex = 4;
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
            this.txt_username.Location = new System.Drawing.Point(52, 144);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(7);
            this.txt_username.PasswordChar = false;
            this.txt_username.Size = new System.Drawing.Size(235, 38);
            this.txt_username.TabIndex = 3;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = true;
            // 
            // UregisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_userError);
            this.Controls.Add(this.lbl_nameError);
            this.Controls.Add(this.lbl_formError);
            this.Controls.Add(this.btn_userregister);
            this.Controls.Add(this.link_signin);
            this.Controls.Add(this.chk_showpassword);
            this.Controls.Add(this.date_userbirthday);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_pwdError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UregisterForm";
            this.Text = "UregisterForm";
            this.Load += new System.EventHandler(this.UregisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txt_password;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txt_username;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txt_fullname;
        private System.Windows.Forms.Label label1;
        private RJDatePicker date_userbirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel link_signin;
        private System.Windows.Forms.CheckBox chk_showpassword;
        private CustomControls.RJControls.RJButton btn_userregister;
        private System.Windows.Forms.Label lbl_pwdError;
        private System.Windows.Forms.Label lbl_formError;
        private System.Windows.Forms.Label lbl_nameError;
        private System.Windows.Forms.Label lbl_userError;
        private CustomControls.RJControls.RJButton btn_reset;
    }
}