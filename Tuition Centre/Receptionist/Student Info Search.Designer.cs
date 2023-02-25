namespace Tuition_Centre.Receptionist
{
    partial class frmStuSearch
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
            dgvChangeSub = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvChangeSub).BeginInit();
            SuspendLayout();
            // 
            // dgvChangeSub
            // 
            dgvChangeSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChangeSub.Location = new Point(1, 5);
            dgvChangeSub.Name = "dgvChangeSub";
            dgvChangeSub.RowTemplate.Height = 25;
            dgvChangeSub.Size = new Size(572, 268);
            dgvChangeSub.TabIndex = 0;
            // 
            // frmStuSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 276);
            Controls.Add(dgvChangeSub);
            Name = "frmStuSearch";
            Text = "Student_Info_Search";
            ((System.ComponentModel.ISupportInitialize)dgvChangeSub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChangeSub;
    }
}