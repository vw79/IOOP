namespace Tuition_Centre.Receptionist
{
    partial class frmSearchDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchDelete));
            pictureHome = new PictureBox();
            btnSearch = new Button();
            dgvStuInfo = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStuInfo).BeginInit();
            SuspendLayout();
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(737, 12);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 53;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(567, 79);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 52;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvStuInfo
            // 
            dgvStuInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStuInfo.Location = new Point(115, 181);
            dgvStuInfo.Margin = new Padding(3, 2, 3, 2);
            dgvStuInfo.Name = "dgvStuInfo";
            dgvStuInfo.RowHeadersWidth = 51;
            dgvStuInfo.RowTemplate.Height = 29;
            dgvStuInfo.Size = new Size(569, 232);
            dgvStuInfo.TabIndex = 51;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(172, 119);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(334, 23);
            txtSearch.TabIndex = 50;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(172, 79);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(113, 15);
            lblSearch.TabIndex = 49;
            lblSearch.Text = "Enter Student Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(567, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmSearchDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(pictureHome);
            Controls.Add(btnSearch);
            Controls.Add(dgvStuInfo);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Name = "frmSearchDelete";
            Text = "Delete Student";
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStuInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureHome;
        private Button btnSearch;
        private DataGridView dgvStuInfo;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnDelete;
    }
}