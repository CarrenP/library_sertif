namespace library_sertif.forms
{
    partial class home
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
            this.Title_lbl = new System.Windows.Forms.Label();
            this.btn_signin_home = new System.Windows.Forms.Button();
            this.btn_Signup_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
          
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Location = new System.Drawing.Point(305, 27);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(181, 20);
            this.Title_lbl.TabIndex = 0;
            this.Title_lbl.Text = "Welcome to ABC Library";
            this.Title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            this.btn_signin_home.Location = new System.Drawing.Point(100, 178);
            this.btn_signin_home.Name = "btn_signin_home";
            this.btn_signin_home.Size = new System.Drawing.Size(192, 70);
            this.btn_signin_home.TabIndex = 1;
            this.btn_signin_home.Text = "MEMBER SIGN IN";
            this.btn_signin_home.UseVisualStyleBackColor = true;
            this.btn_signin_home.Click += new System.EventHandler(this.btn_signin_home_Click);
           
            this.btn_Signup_home.Location = new System.Drawing.Point(423, 178);
            this.btn_Signup_home.Name = "btn_Signup_home";
            this.btn_Signup_home.Size = new System.Drawing.Size(192, 70);
            this.btn_Signup_home.TabIndex = 2;
            this.btn_Signup_home.Text = "MEMBER SIGN UP";
            this.btn_Signup_home.UseVisualStyleBackColor = true;
            this.btn_Signup_home.Click += new System.EventHandler(this.btn_Signup_home_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Signup_home);
            this.Controls.Add(this.btn_signin_home);
            this.Controls.Add(this.Title_lbl);
            this.Name = "home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.Button btn_signin_home;
        private System.Windows.Forms.Button btn_Signup_home;
    }
}