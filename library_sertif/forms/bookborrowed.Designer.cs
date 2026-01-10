namespace library_sertif.forms
{
    partial class bookborrowed
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
            this.dgvBorrowed = new System.Windows.Forms.DataGridView();
            this.lblBack_bookborrow = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowed.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBorrowed.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.ReadOnly = true;
            this.dgvBorrowed.RowHeadersWidth = 62;
            this.dgvBorrowed.RowTemplate.Height = 28;
            this.dgvBorrowed.Size = new System.Drawing.Size(800, 450);
            this.dgvBorrowed.TabIndex = 9;
            // 
            // lblBack_bookborrow
            // 
            this.lblBack_bookborrow.AutoSize = true;
            this.lblBack_bookborrow.Location = new System.Drawing.Point(12, 9);
            this.lblBack_bookborrow.Name = "lblBack_bookborrow";
            this.lblBack_bookborrow.Size = new System.Drawing.Size(65, 20);
            this.lblBack_bookborrow.TabIndex = 10;
            this.lblBack_bookborrow.TabStop = true;
            this.lblBack_bookborrow.Text = "← Back";
            this.lblBack_bookborrow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_bookborrow_LinkClicked);
            // 
            // BorrowedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack_bookborrow);
            this.Controls.Add(this.dgvBorrowed);
            this.Name = "BorrowedBooksForm";
            this.Text = "bookborrowed";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowed;
        private System.Windows.Forms.LinkLabel lblBack_bookborrow;
    }
}