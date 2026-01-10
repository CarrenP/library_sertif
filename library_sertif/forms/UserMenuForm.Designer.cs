namespace library_sertif.forms
{
    partial class UserMenuForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnMyLoans = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(219, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 0;
            // 
            // btnCatalog
            // 
            this.btnCatalog.Location = new System.Drawing.Point(44, 102);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(207, 66);
            this.btnCatalog.TabIndex = 1;
            this.btnCatalog.Text = "Book List";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // btnMyLoans
            // 
            this.btnMyLoans.Location = new System.Drawing.Point(44, 199);
            this.btnMyLoans.Name = "btnMyLoans";
            this.btnMyLoans.Size = new System.Drawing.Size(207, 66);
            this.btnMyLoans.TabIndex = 2;
            this.btnMyLoans.Text = "Borrow Books";
            this.btnMyLoans.UseVisualStyleBackColor = true;
            this.btnMyLoans.Click += new System.EventHandler(this.btnMyLoans_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(44, 295);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 66);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyLoans);
            this.Controls.Add(this.btnCatalog);
            this.Controls.Add(this.lblWelcome);
            this.Name = "UserMenuForm";
            this.Text = "User Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnMyLoans;
        private System.Windows.Forms.Button btnLogout;
    }
}
