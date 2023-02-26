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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment1));
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvStuInfo = new DataGridView();
            btnSearch = new Button();
            pictureHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvStuInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(166, 73);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(113, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Enter Student Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(166, 113);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(334, 23);
            txtSearch.TabIndex = 1;
            // 
            // dgvStuInfo
            // 
            dgvStuInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStuInfo.Location = new Point(109, 175);
            dgvStuInfo.Margin = new Padding(3, 2, 3, 2);
            dgvStuInfo.Name = "dgvStuInfo";
            dgvStuInfo.RowHeadersWidth = 51;
            dgvStuInfo.RowTemplate.Height = 29;
            dgvStuInfo.Size = new Size(569, 232);
            dgvStuInfo.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(543, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(737, 12);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 48;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // frmPayment1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureHome);
            Controls.Add(btnSearch);
            Controls.Add(dgvStuInfo);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Name = "frmPayment1";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dgvStuInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvStuInfo;
        private Button btnSearch;
        private PictureBox pictureHome;
    }
}