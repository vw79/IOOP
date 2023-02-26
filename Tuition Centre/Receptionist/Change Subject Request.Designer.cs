namespace Tuition_Centre.Receptionist
{
    partial class frmChangeSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeSub));
            dgvChangeSub = new DataGridView();
            pictureHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvChangeSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // dgvChangeSub
            // 
            dgvChangeSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChangeSub.Location = new Point(12, 76);
            dgvChangeSub.Name = "dgvChangeSub";
            dgvChangeSub.RowTemplate.Height = 25;
            dgvChangeSub.Size = new Size(776, 362);
            dgvChangeSub.TabIndex = 0;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(737, 12);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 49;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // frmChangeSub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureHome);
            Controls.Add(dgvChangeSub);
            Name = "frmChangeSub";
            Text = "Change Subject Request";
            ((System.ComponentModel.ISupportInitialize)dgvChangeSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChangeSub;
        private PictureBox pictureHome;
    }
}