namespace Tuition_Centre.Receptionist
{
    partial class frmUpdateStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStu));
            panel1 = new Panel();
            btnDeleteStu = new Button();
            btnUpPay = new Button();
            btnUpSub = new Button();
            pictureHome = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDeleteStu);
            panel1.Controls.Add(btnUpPay);
            panel1.Controls.Add(btnUpSub);
            panel1.Location = new Point(12, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 315);
            panel1.TabIndex = 0;
            // 
            // btnDeleteStu
            // 
            btnDeleteStu.Location = new Point(541, 134);
            btnDeleteStu.Name = "btnDeleteStu";
            btnDeleteStu.Size = new Size(176, 49);
            btnDeleteStu.TabIndex = 2;
            btnDeleteStu.Text = "Delete Student";
            btnDeleteStu.UseVisualStyleBackColor = true;
            btnDeleteStu.Click += btnDeleteStu_Click;
            // 
            // btnUpPay
            // 
            btnUpPay.Location = new Point(296, 134);
            btnUpPay.Name = "btnUpPay";
            btnUpPay.Size = new Size(176, 49);
            btnUpPay.TabIndex = 1;
            btnUpPay.Text = "Update Payment";
            btnUpPay.UseVisualStyleBackColor = true;
            btnUpPay.Click += btnUpPay_Click;
            // 
            // btnUpSub
            // 
            btnUpSub.Location = new Point(50, 134);
            btnUpSub.Name = "btnUpSub";
            btnUpSub.Size = new Size(176, 49);
            btnUpSub.TabIndex = 0;
            btnUpSub.Text = "Update Subject";
            btnUpSub.UseVisualStyleBackColor = true;
            btnUpSub.Click += btnUpSub_Click;
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
            // frmUpdateStu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureHome);
            Name = "frmUpdateStu";
            Text = "Update Student Info";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureHome;
        private Button btnDeleteStu;
        private Button btnUpPay;
        private Button btnUpSub;
    }
}