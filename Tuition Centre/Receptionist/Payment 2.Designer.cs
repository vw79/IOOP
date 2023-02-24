namespace Tuition_Centre.Receptionist
{
    partial class frmPayment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment2));
            panel2 = new Panel();
            lblStuIDS = new Label();
            lblStuNameS = new Label();
            lblStuID = new Label();
            lblStuName = new Label();
            panel3 = new Panel();
            btnReceipt = new Button();
            cmbPay = new ComboBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            pictureHome = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureHome);
            panel2.Controls.Add(lblStuIDS);
            panel2.Controls.Add(lblStuNameS);
            panel2.Controls.Add(lblStuID);
            panel2.Controls.Add(lblStuName);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 105);
            panel2.TabIndex = 4;
            // 
            // lblStuIDS
            // 
            lblStuIDS.BorderStyle = BorderStyle.Fixed3D;
            lblStuIDS.Location = new Point(132, 55);
            lblStuIDS.Name = "lblStuIDS";
            lblStuIDS.Size = new Size(200, 17);
            lblStuIDS.TabIndex = 4;
            // 
            // lblStuNameS
            // 
            lblStuNameS.BorderStyle = BorderStyle.Fixed3D;
            lblStuNameS.Location = new Point(132, 22);
            lblStuNameS.Name = "lblStuNameS";
            lblStuNameS.Size = new Size(200, 17);
            lblStuNameS.TabIndex = 3;
            // 
            // lblStuID
            // 
            lblStuID.AutoSize = true;
            lblStuID.Location = new Point(18, 55);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(68, 15);
            lblStuID.TabIndex = 2;
            lblStuID.Text = "Student ID: ";
            // 
            // lblStuName
            // 
            lblStuName.AutoSize = true;
            lblStuName.Location = new Point(18, 22);
            lblStuName.Name = "lblStuName";
            lblStuName.Size = new Size(45, 15);
            lblStuName.TabIndex = 1;
            lblStuName.Text = "Name: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnReceipt);
            panel3.Controls.Add(cmbPay);
            panel3.Controls.Add(lblAmount);
            panel3.Controls.Add(txtAmount);
            panel3.Location = new Point(12, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 315);
            panel3.TabIndex = 5;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(513, 228);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(150, 23);
            btnReceipt.TabIndex = 3;
            btnReceipt.Text = "Generate Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            // 
            // cmbPay
            // 
            cmbPay.FormattingEnabled = true;
            cmbPay.Location = new Point(124, 163);
            cmbPay.Name = "cmbPay";
            cmbPay.Size = new Size(200, 23);
            cmbPay.TabIndex = 2;
            cmbPay.Text = "Payment Method";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(124, 68);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(124, 86);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter Amount";
            txtAmount.Size = new Size(200, 23);
            txtAmount.TabIndex = 0;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(725, 0);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 48;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // frmPayment2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmPayment2";
            Text = "Payment";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblStuID;
        private Label lblStuName;
        private Panel panel3;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnReceipt;
        private ComboBox cmbPay;
        private Label lblStuIDS;
        private Label lblStuNameS;
        private PictureBox pictureHome;
    }
}