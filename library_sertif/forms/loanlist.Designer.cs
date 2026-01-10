namespace library_sertif.forms
{
    partial class loanlist
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
            this.dgvloan_loanlist = new System.Windows.Forms.DataGridView();
            this.lblBack_loanlist = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloan_loanlist)).BeginInit();
            this.SuspendLayout();
            
            this.dgvloan_loanlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloan_loanlist.Location = new System.Drawing.Point(12, 70);
            this.dgvloan_loanlist.Name = "dgvloan_loanlist";
            this.dgvloan_loanlist.RowHeadersWidth = 62;
            this.dgvloan_loanlist.RowTemplate.Height = 28;
            this.dgvloan_loanlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloan_loanlist.Size = new System.Drawing.Size(776, 368);
            this.dgvloan_loanlist.TabIndex = 0;
            this.dgvloan_loanlist.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvloan_loanlist_CellContentClick);
            
            this.lblBack_loanlist.AutoSize = true;
            this.lblBack_loanlist.Location = new System.Drawing.Point(12, 25);
            this.lblBack_loanlist.Name = "lblBack_loanlist";
            this.lblBack_loanlist.Size = new System.Drawing.Size(65, 20);
            this.lblBack_loanlist.TabIndex = 1;
            this.lblBack_loanlist.TabStop = true;
            this.lblBack_loanlist.Text = "← Back";
            this.lblBack_loanlist.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(
                    this.lblBack_loanlist_LinkClicked);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack_loanlist);
            this.Controls.Add(this.dgvloan_loanlist);
            this.Name = "loanlist";
            this.Text = "My Loans";
            ((System.ComponentModel.ISupportInitialize)(this.dgvloan_loanlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvloan_loanlist;
        private System.Windows.Forms.LinkLabel lblBack_loanlist;
    }
}
