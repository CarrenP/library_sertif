namespace library_sertif.forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBack_login = new System.Windows.Forms.LinkLabel();
            this.lblMemID_login = new System.Windows.Forms.Label();
            this.lblPassword_login = new System.Windows.Forms.Label();
            this.lbl_signup_login = new System.Windows.Forms.LinkLabel();
            this.txtMemID_login = new System.Windows.Forms.TextBox();
            this.txtPassword_login = new System.Windows.Forms.TextBox();
            this.btnLogin_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back!";
            
            this.lblBack_login.AutoSize = true;
            this.lblBack_login.Location = new System.Drawing.Point(12, 9);
            this.lblBack_login.Name = "lblBack_login";
            this.lblBack_login.Size = new System.Drawing.Size(65, 20);
            this.lblBack_login.TabIndex = 1;
            this.lblBack_login.TabStop = true;
            this.lblBack_login.Text = "← Back";
            this.lblBack_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_login_LinkClicked);
             
            this.lblMemID_login.AutoSize = true;
            this.lblMemID_login.Location = new System.Drawing.Point(16, 92);
            this.lblMemID_login.Name = "lblMemID_login";
            this.lblMemID_login.Size = new System.Drawing.Size(88, 20);
            this.lblMemID_login.TabIndex = 2;
            this.lblMemID_login.Text = "Member ID";
            
            this.lblPassword_login.AutoSize = true;
            this.lblPassword_login.Location = new System.Drawing.Point(16, 172);
            this.lblPassword_login.Name = "lblPassword_login";
            this.lblPassword_login.Size = new System.Drawing.Size(78, 20);
            this.lblPassword_login.TabIndex = 3;
            this.lblPassword_login.Text = "Password";
            
            this.lbl_signup_login.AutoSize = true;
            this.lbl_signup_login.Location = new System.Drawing.Point(110, 272);
            this.lbl_signup_login.Name = "lbl_signup_login";
            this.lbl_signup_login.Size = new System.Drawing.Size(138, 20);
            this.lbl_signup_login.TabIndex = 4;
            this.lbl_signup_login.TabStop = true;
            this.lbl_signup_login.Text = "Not a Member Yet";
            this.lbl_signup_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_signup_login_LinkClicked);
            
            this.txtMemID_login.Location = new System.Drawing.Point(114, 92);
            this.txtMemID_login.Name = "txtMemID_login";
            this.txtMemID_login.Size = new System.Drawing.Size(153, 26);
            this.txtMemID_login.TabIndex = 5;
            
            this.txtPassword_login.Location = new System.Drawing.Point(114, 169);
            this.txtPassword_login.Name = "txtPassword_login";
            this.txtPassword_login.Size = new System.Drawing.Size(153, 26);
            this.txtPassword_login.TabIndex = 6;
            this.txtPassword_login.UseSystemPasswordChar = true;
            
            this.btnLogin_login.Location = new System.Drawing.Point(84, 222);
            this.btnLogin_login.Name = "btnLogin_login";
            this.btnLogin_login.Size = new System.Drawing.Size(198, 36);
            this.btnLogin_login.TabIndex = 7;
            this.btnLogin_login.Text = "LOG IN";
            this.btnLogin_login.UseVisualStyleBackColor = true;
            this.btnLogin_login.Click += new System.EventHandler(this.btnLogin_login_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 390);
            this.Controls.Add(this.btnLogin_login);
            this.Controls.Add(this.txtPassword_login);
            this.Controls.Add(this.txtMemID_login);
            this.Controls.Add(this.lbl_signup_login);
            this.Controls.Add(this.lblPassword_login);
            this.Controls.Add(this.lblMemID_login);
            this.Controls.Add(this.lblBack_login);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblBack_login;
        private System.Windows.Forms.Label lblMemID_login;
        private System.Windows.Forms.Label lblPassword_login;
        private System.Windows.Forms.LinkLabel lbl_signup_login;
        private System.Windows.Forms.TextBox txtMemID_login;
        private System.Windows.Forms.TextBox txtPassword_login;
        private System.Windows.Forms.Button btnLogin_login;
    }
}
