namespace library_sertif.forms
{
    partial class AdminMenuForm
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btn_mag_book = new System.Windows.Forms.Button();
            this.btnBookBorrow_admin = new System.Windows.Forms.Button();
            this.lblBack_admin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(79, 78);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.RowTemplate.Height = 28;
            this.dgvBooks.Size = new System.Drawing.Size(653, 305);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // btn_mag_book
            // 
            this.btn_mag_book.Location = new System.Drawing.Point(228, 400);
            this.btn_mag_book.Name = "btn_mag_book";
            this.btn_mag_book.Size = new System.Drawing.Size(156, 38);
            this.btn_mag_book.TabIndex = 2;
            this.btn_mag_book.Text = "Book Management";
            this.btn_mag_book.UseVisualStyleBackColor = true;
            this.btn_mag_book.Click += new System.EventHandler(this.btn_rmv_book_Click_1);
            // 
            // btnBookBorrow_admin
            // 
            this.btnBookBorrow_admin.Location = new System.Drawing.Point(420, 400);
            this.btnBookBorrow_admin.Name = "btnBookBorrow_admin";
            this.btnBookBorrow_admin.Size = new System.Drawing.Size(180, 38);
            this.btnBookBorrow_admin.TabIndex = 3;
            this.btnBookBorrow_admin.Text = "BORROW LIST";
            this.btnBookBorrow_admin.UseVisualStyleBackColor = true;
            this.btnBookBorrow_admin.Click += new System.EventHandler(this.btnBookBorrow_admin_Click_1);
            // 
            // lblBack_admin
            // 
            this.lblBack_admin.AutoSize = true;
            this.lblBack_admin.Location = new System.Drawing.Point(26, 24);
            this.lblBack_admin.Name = "lblBack_admin";
            this.lblBack_admin.Size = new System.Drawing.Size(65, 20);
            this.lblBack_admin.TabIndex = 10;
            this.lblBack_admin.TabStop = true;
            this.lblBack_admin.Text = "← Back";
            this.lblBack_admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_admin_LinkClicked);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack_admin);
            this.Controls.Add(this.btnBookBorrow_admin);
            this.Controls.Add(this.btn_mag_book);
            this.Controls.Add(this.dgvBooks);
            this.Name = "AdminMenuForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btn_mag_book;
        private System.Windows.Forms.Button btnBookBorrow_admin;
        private System.Windows.Forms.LinkLabel lblBack_admin;
    }
}