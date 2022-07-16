namespace e_Shift
{
    partial class adminLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_showpassword = new System.Windows.Forms.CheckBox();
            this.btn_adminsubmit = new CustomControls.RJControls.RJButton();
            this.txt_password = new CustomControls.RJControls.RJTextBox();
            this.txt_username = new CustomControls.RJControls.RJTextBox();
            this.lbl_unameError = new System.Windows.Forms.Label();
            this.lbl_pwdError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Admin!\r\nPlease fill out the form below to get started";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // chk_showpassword
            // 
            this.chk_showpassword.AutoSize = true;
            this.chk_showpassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showpassword.Location = new System.Drawing.Point(188, 268);
            this.chk_showpassword.Name = "chk_showpassword";
            this.chk_showpassword.Size = new System.Drawing.Size(112, 23);
            this.chk_showpassword.TabIndex = 6;
            this.chk_showpassword.Text = "Show Password";
            this.chk_showpassword.UseVisualStyleBackColor = true;
            this.chk_showpassword.CheckedChanged += new System.EventHandler(this.chk_showpassword_CheckedChanged);
            // 
            // btn_adminsubmit
            // 
            this.btn_adminsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_adminsubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.btn_adminsubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_adminsubmit.BorderRadius = 0;
            this.btn_adminsubmit.BorderSize = 0;
            this.btn_adminsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminsubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_adminsubmit.FlatAppearance.BorderSize = 0;
            this.btn_adminsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminsubmit.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminsubmit.ForeColor = System.Drawing.Color.White;
            this.btn_adminsubmit.Location = new System.Drawing.Point(0, 310);
            this.btn_adminsubmit.Name = "btn_adminsubmit";
            this.btn_adminsubmit.Size = new System.Drawing.Size(600, 40);
            this.btn_adminsubmit.TabIndex = 5;
            this.btn_adminsubmit.Text = "Login";
            this.btn_adminsubmit.TextColor = System.Drawing.Color.White;
            this.btn_adminsubmit.UseVisualStyleBackColor = false;
            this.btn_adminsubmit.Click += new System.EventHandler(this.btn_adminsubmit_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.txt_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.txt_password.Location = new System.Drawing.Point(188, 211);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_password.PasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(335, 38);
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
            this.txt_username.Location = new System.Drawing.Point(188, 127);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(7);
            this.txt_username.PasswordChar = false;
            this.txt_username.Size = new System.Drawing.Size(335, 38);
            this.txt_username.TabIndex = 2;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = true;
            // 
            // lbl_unameError
            // 
            this.lbl_unameError.AutoSize = true;
            this.lbl_unameError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unameError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_unameError.Location = new System.Drawing.Point(184, 169);
            this.lbl_unameError.Name = "lbl_unameError";
            this.lbl_unameError.Size = new System.Drawing.Size(0, 19);
            this.lbl_unameError.TabIndex = 7;
            // 
            // lbl_pwdError
            // 
            this.lbl_pwdError.AutoSize = true;
            this.lbl_pwdError.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwdError.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_pwdError.Location = new System.Drawing.Point(184, 253);
            this.lbl_pwdError.Name = "lbl_pwdError";
            this.lbl_pwdError.Size = new System.Drawing.Size(0, 19);
            this.lbl_pwdError.TabIndex = 8;
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lbl_pwdError);
            this.Controls.Add(this.lbl_unameError);
            this.Controls.Add(this.chk_showpassword);
            this.Controls.Add(this.btn_adminsubmit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminLogin";
            this.Text = "adminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txt_username;
        private CustomControls.RJControls.RJTextBox txt_password;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btn_adminsubmit;
        private System.Windows.Forms.CheckBox chk_showpassword;
        private System.Windows.Forms.Label lbl_unameError;
        private System.Windows.Forms.Label lbl_pwdError;
    }
}