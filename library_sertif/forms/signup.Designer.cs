namespace library_sertif.forms
{
    partial class signup
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
            this.txtName_signup = new System.Windows.Forms.TextBox();
            this.txtAddress_signup = new System.Windows.Forms.TextBox();
            this.txtEmail_signup = new System.Windows.Forms.TextBox();
            this.txtPsw_signup = new System.Windows.Forms.TextBox();
            this.txtAge_signup = new System.Windows.Forms.TextBox();
            this.cmbGender_signup = new System.Windows.Forms.ComboBox();
            this.lblJoin_signup = new System.Windows.Forms.Label();
            this.btnSignup_signup = new System.Windows.Forms.Button();
            this.lblName_signup = new System.Windows.Forms.Label();
            this.lblAddress_signup = new System.Windows.Forms.Label();
            this.lblAge_signup = new System.Windows.Forms.Label();
            this.lblEmail_signup = new System.Windows.Forms.Label();
            this.lblPsw_signup = new System.Windows.Forms.Label();
            this.lblGender_signup = new System.Windows.Forms.Label();
            this.lblBack_signup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
           
            this.txtName_signup.Location = new System.Drawing.Point(111, 70);
            this.txtName_signup.Name = "txtName_signup";
            this.txtName_signup.Size = new System.Drawing.Size(174, 26);
            this.txtName_signup.TabIndex = 0;
           
            this.txtAddress_signup.Location = new System.Drawing.Point(111, 143);
            this.txtAddress_signup.Name = "txtAddress_signup";
            this.txtAddress_signup.Size = new System.Drawing.Size(174, 26);
            this.txtAddress_signup.TabIndex = 1;
          
            this.txtEmail_signup.Location = new System.Drawing.Point(548, 70);
            this.txtEmail_signup.Name = "txtEmail_signup";
            this.txtEmail_signup.Size = new System.Drawing.Size(174, 26);
            this.txtEmail_signup.TabIndex = 2;
           
            this.txtPsw_signup.Location = new System.Drawing.Point(548, 143);
            this.txtPsw_signup.Name = "txtPsw_signup";
            this.txtPsw_signup.Size = new System.Drawing.Size(174, 26);
            this.txtPsw_signup.TabIndex = 3;
          
            this.txtAge_signup.Location = new System.Drawing.Point(111, 214);
            this.txtAge_signup.Name = "txtAge_signup";
            this.txtAge_signup.Size = new System.Drawing.Size(174, 26);
            this.txtAge_signup.TabIndex = 4;
           
            this.cmbGender_signup.FormattingEnabled = true;
            this.cmbGender_signup.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender_signup.Location = new System.Drawing.Point(548, 212);
            this.cmbGender_signup.Name = "cmbGender_signup";
            this.cmbGender_signup.Size = new System.Drawing.Size(174, 28);
            this.cmbGender_signup.TabIndex = 5;
           
            this.lblJoin_signup.AutoSize = true;
            this.lblJoin_signup.Location = new System.Drawing.Point(329, 24);
            this.lblJoin_signup.Name = "lblJoin_signup";
            this.lblJoin_signup.Size = new System.Drawing.Size(135, 20);
            this.lblJoin_signup.TabIndex = 6;
            this.lblJoin_signup.Text = "JOIN US TODAY!";
            this.lblJoin_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          
            this.btnSignup_signup.Location = new System.Drawing.Point(283, 288);
            this.btnSignup_signup.Name = "btnSignup_signup";
            this.btnSignup_signup.Size = new System.Drawing.Size(201, 36);
            this.btnSignup_signup.TabIndex = 7;
            this.btnSignup_signup.Text = "Be a Member!";
            this.btnSignup_signup.UseVisualStyleBackColor = true;
            this.btnSignup_signup.Click += new System.EventHandler(this.btnSignup_signup_Click);
           
            this.lblName_signup.AutoSize = true;
            this.lblName_signup.Location = new System.Drawing.Point(12, 76);
            this.lblName_signup.Name = "lblName_signup";
            this.lblName_signup.Size = new System.Drawing.Size(51, 20);
            this.lblName_signup.TabIndex = 8;
            this.lblName_signup.Text = "Name";
            this.lblName_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          
            this.lblAddress_signup.AutoSize = true;
            this.lblAddress_signup.Location = new System.Drawing.Point(12, 149);
            this.lblAddress_signup.Name = "lblAddress_signup";
            this.lblAddress_signup.Size = new System.Drawing.Size(68, 20);
            this.lblAddress_signup.TabIndex = 9;
            this.lblAddress_signup.Text = "Address";
            this.lblAddress_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           
            this.lblAge_signup.AutoSize = true;
            this.lblAge_signup.Location = new System.Drawing.Point(12, 220);
            this.lblAge_signup.Name = "lblAge_signup";
            this.lblAge_signup.Size = new System.Drawing.Size(38, 20);
            this.lblAge_signup.TabIndex = 10;
            this.lblAge_signup.Text = "Age";
            this.lblAge_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          
            this.lblEmail_signup.AutoSize = true;
            this.lblEmail_signup.Location = new System.Drawing.Point(465, 76);
            this.lblEmail_signup.Name = "lblEmail_signup";
            this.lblEmail_signup.Size = new System.Drawing.Size(48, 20);
            this.lblEmail_signup.TabIndex = 11;
            this.lblEmail_signup.Text = "Email";
            this.lblEmail_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            this.lblPsw_signup.AutoSize = true;
            this.lblPsw_signup.Location = new System.Drawing.Point(423, 149);
            this.lblPsw_signup.Name = "lblPsw_signup";
            this.lblPsw_signup.Size = new System.Drawing.Size(119, 20);
            this.lblPsw_signup.TabIndex = 12;
            this.lblPsw_signup.Text = "Input Password";
            this.lblPsw_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          
            this.lblGender_signup.AutoSize = true;
            this.lblGender_signup.Location = new System.Drawing.Point(465, 217);
            this.lblGender_signup.Name = "lblGender_signup";
            this.lblGender_signup.Size = new System.Drawing.Size(63, 20);
            this.lblGender_signup.TabIndex = 13;
            this.lblGender_signup.Text = "Gender";
            this.lblGender_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            this.lblBack_signup.AutoSize = true;
            this.lblBack_signup.Location = new System.Drawing.Point(14, 26);
            this.lblBack_signup.Name = "lblBack_signup";
            this.lblBack_signup.Size = new System.Drawing.Size(65, 20);
            this.lblBack_signup.TabIndex = 14;
            this.lblBack_signup.TabStop = true;
            this.lblBack_signup.Text = "← Back";
            this.lblBack_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_signup_LinkClicked);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack_signup);
            this.Controls.Add(this.lblGender_signup);
            this.Controls.Add(this.lblPsw_signup);
            this.Controls.Add(this.lblEmail_signup);
            this.Controls.Add(this.lblAge_signup);
            this.Controls.Add(this.lblAddress_signup);
            this.Controls.Add(this.lblName_signup);
            this.Controls.Add(this.btnSignup_signup);
            this.Controls.Add(this.lblJoin_signup);
            this.Controls.Add(this.cmbGender_signup);
            this.Controls.Add(this.txtAge_signup);
            this.Controls.Add(this.txtPsw_signup);
            this.Controls.Add(this.txtEmail_signup);
            this.Controls.Add(this.txtAddress_signup);
            this.Controls.Add(this.txtName_signup);
            this.Name = "signup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName_signup;
        private System.Windows.Forms.TextBox txtAddress_signup;
        private System.Windows.Forms.TextBox txtEmail_signup;
        private System.Windows.Forms.TextBox txtPsw_signup;
        private System.Windows.Forms.TextBox txtAge_signup;
        private System.Windows.Forms.ComboBox cmbGender_signup;
        private System.Windows.Forms.Label lblJoin_signup;
        private System.Windows.Forms.Button btnSignup_signup;
        private System.Windows.Forms.Label lblName_signup;
        private System.Windows.Forms.Label lblAddress_signup;
        private System.Windows.Forms.Label lblAge_signup;
        private System.Windows.Forms.Label lblEmail_signup;
        private System.Windows.Forms.Label lblPsw_signup;
        private System.Windows.Forms.Label lblGender_signup;
        private System.Windows.Forms.LinkLabel lblBack_signup;
    }
}