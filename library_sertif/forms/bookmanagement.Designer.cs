namespace library_sertif.forms
{
    partial class bookmanagement
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
            this.btnAdd_bookmag = new System.Windows.Forms.Button();
            this.btnRemove_bookmag = new System.Windows.Forms.Button();
            this.lblTitle_bookmag = new System.Windows.Forms.Label();
            this.lblAuthor_bookmag = new System.Windows.Forms.Label();
            this.lblStock_bookmag = new System.Windows.Forms.Label();
            this.txtTitle_bookmag = new System.Windows.Forms.TextBox();
            this.txtAuthor_bookmag = new System.Windows.Forms.TextBox();
            this.txtStock_bookmag = new System.Windows.Forms.TextBox();
            this.dgvBook_bookmag = new System.Windows.Forms.DataGridView();
            this.lblBack_bookmag = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook_bookmag)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd_bookmag
            // 
            this.btnAdd_bookmag.Location = new System.Drawing.Point(14, 327);
            this.btnAdd_bookmag.Name = "btnAdd_bookmag";
            this.btnAdd_bookmag.Size = new System.Drawing.Size(106, 39);
            this.btnAdd_bookmag.TabIndex = 0;
            this.btnAdd_bookmag.Text = "ADD";
            this.btnAdd_bookmag.UseVisualStyleBackColor = true;
            this.btnAdd_bookmag.Click += new System.EventHandler(this.btnAdd_bookmag_Click);
            // 
            // btnRemove_bookmag
            // 
            this.btnRemove_bookmag.Location = new System.Drawing.Point(160, 327);
            this.btnRemove_bookmag.Name = "btnRemove_bookmag";
            this.btnRemove_bookmag.Size = new System.Drawing.Size(106, 39);
            this.btnRemove_bookmag.TabIndex = 1;
            this.btnRemove_bookmag.Text = "REMOVE";
            this.btnRemove_bookmag.UseVisualStyleBackColor = true;
            this.btnRemove_bookmag.Click += new System.EventHandler(this.btnRemove_bookmag_Click);
            // 
            // lblTitle_bookmag
            // 
            this.lblTitle_bookmag.AutoSize = true;
            this.lblTitle_bookmag.Location = new System.Drawing.Point(18, 104);
            this.lblTitle_bookmag.Name = "lblTitle_bookmag";
            this.lblTitle_bookmag.Size = new System.Drawing.Size(38, 20);
            this.lblTitle_bookmag.TabIndex = 2;
            this.lblTitle_bookmag.Text = "Title";
            // 
            // lblAuthor_bookmag
            // 
            this.lblAuthor_bookmag.AutoSize = true;
            this.lblAuthor_bookmag.Location = new System.Drawing.Point(18, 141);
            this.lblAuthor_bookmag.Name = "lblAuthor_bookmag";
            this.lblAuthor_bookmag.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor_bookmag.TabIndex = 3;
            this.lblAuthor_bookmag.Text = "Author";
            // 
            // lblStock_bookmag
            // 
            this.lblStock_bookmag.AutoSize = true;
            this.lblStock_bookmag.Location = new System.Drawing.Point(18, 186);
            this.lblStock_bookmag.Name = "lblStock_bookmag";
            this.lblStock_bookmag.Size = new System.Drawing.Size(50, 20);
            this.lblStock_bookmag.TabIndex = 4;
            this.lblStock_bookmag.Text = "Stock";
            // 
            // txtTitle_bookmag
            // 
            this.txtTitle_bookmag.Location = new System.Drawing.Point(105, 98);
            this.txtTitle_bookmag.Name = "txtTitle_bookmag";
            this.txtTitle_bookmag.Size = new System.Drawing.Size(129, 26);
            this.txtTitle_bookmag.TabIndex = 5;
            // 
            // txtAuthor_bookmag
            // 
            this.txtAuthor_bookmag.Location = new System.Drawing.Point(105, 141);
            this.txtAuthor_bookmag.Name = "txtAuthor_bookmag";
            this.txtAuthor_bookmag.Size = new System.Drawing.Size(129, 26);
            this.txtAuthor_bookmag.TabIndex = 6;
            // 
            // txtStock_bookmag
            // 
            this.txtStock_bookmag.Location = new System.Drawing.Point(105, 186);
            this.txtStock_bookmag.Name = "txtStock_bookmag";
            this.txtStock_bookmag.Size = new System.Drawing.Size(129, 26);
            this.txtStock_bookmag.TabIndex = 7;
            // 
            // dgvBook_bookmag
            // 
            this.dgvBook_bookmag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook_bookmag.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBook_bookmag.Location = new System.Drawing.Point(340, 0);
            this.dgvBook_bookmag.Name = "dgvBook_bookmag";
            this.dgvBook_bookmag.ReadOnly = true;
            this.dgvBook_bookmag.RowHeadersWidth = 62;
            this.dgvBook_bookmag.RowTemplate.Height = 28;
            this.dgvBook_bookmag.Size = new System.Drawing.Size(460, 450);
            this.dgvBook_bookmag.TabIndex = 8;
            // 
            // lblBack_bookmag
            // 
            this.lblBack_bookmag.AutoSize = true;
            this.lblBack_bookmag.Location = new System.Drawing.Point(18, 21);
            this.lblBack_bookmag.Name = "lblBack_bookmag";
            this.lblBack_bookmag.Size = new System.Drawing.Size(65, 20);
            this.lblBack_bookmag.TabIndex = 9;
            this.lblBack_bookmag.TabStop = true;
            this.lblBack_bookmag.Text = "← Back";
            this.lblBack_bookmag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_bookmag_LinkClicked);
            // 
            // bookmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack_bookmag);
            this.Controls.Add(this.dgvBook_bookmag);
            this.Controls.Add(this.txtStock_bookmag);
            this.Controls.Add(this.txtAuthor_bookmag);
            this.Controls.Add(this.txtTitle_bookmag);
            this.Controls.Add(this.lblStock_bookmag);
            this.Controls.Add(this.lblAuthor_bookmag);
            this.Controls.Add(this.lblTitle_bookmag);
            this.Controls.Add(this.btnRemove_bookmag);
            this.Controls.Add(this.btnAdd_bookmag);
            this.Name = "bookmanagement";
            this.Text = "bookmanagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook_bookmag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_bookmag;
        private System.Windows.Forms.Button btnRemove_bookmag;
        private System.Windows.Forms.Label lblTitle_bookmag;
        private System.Windows.Forms.Label lblAuthor_bookmag;
        private System.Windows.Forms.Label lblStock_bookmag;
        private System.Windows.Forms.TextBox txtTitle_bookmag;
        private System.Windows.Forms.TextBox txtAuthor_bookmag;
        private System.Windows.Forms.TextBox txtStock_bookmag;
        private System.Windows.Forms.DataGridView dgvBook_bookmag;
        private System.Windows.Forms.LinkLabel lblBack_bookmag;
    }
}