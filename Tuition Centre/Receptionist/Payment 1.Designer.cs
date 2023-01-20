namespace Tuition_Centre.Receptionist
{
    partial class frmPayment1
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(221, 178);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter Student Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(221, 224);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(334, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // frmPayment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmPayment1";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
    }
}