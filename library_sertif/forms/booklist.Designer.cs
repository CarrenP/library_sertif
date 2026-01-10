namespace library_sertif.forms
{
    partial class booklist
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
            this.dgvBooks_booklist = new System.Windows.Forms.DataGridView();
            this.lblBack_booklist = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks_booklist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks_booklist
            // 
            this.dgvBooks_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks_booklist.Location = new System.Drawing.Point(2, 51);
            this.dgvBooks_booklist.Name = "dgvBooks_booklist";
            this.dgvBooks_booklist.ReadOnly = true;
            this.dgvBooks_booklist.RowHeadersWidth = 62;
            this.dgvBooks_booklist.RowTemplate.Height = 28;
            this.dgvBooks_booklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks_booklist.Size = new System.Drawing.Size(798, 398);
            this.dgvBooks_booklist.TabIndex = 0;
            this.dgvBooks_booklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
            // 
            // lblBack_booklist
            // 
            this.lblBack_booklist.AutoSize = true;
            this.lblBack_booklist.Location = new System.Drawing.Point(13, 15);
            this.lblBack_booklist.Name = "lblBack_booklist";
            this.lblBack_booklist.Size = new System.Drawing.Size(65, 20);
            this.lblBack_booklist.TabIndex = 1;
            this.lblBack_booklist.TabStop = true;
            this.lblBack_booklist.Text = "← Back";
            this.lblBack_booklist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_booklist_LinkClicked);
            // 
            // booklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack_booklist);
            this.Controls.Add(this.dgvBooks_booklist);
            this.Name = "booklist";
            this.Text = "booklist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks_booklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks_booklist;
        private System.Windows.Forms.LinkLabel lblBack_booklist;
    }
}