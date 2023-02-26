namespace Tuition_Centre.Receptionist
{
    partial class Update_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Payment));
            txtCVV = new TextBox();
            txtCard = new TextBox();
            lblPayMethod = new Label();
            lblCard = new Label();
            lblCVV = new Label();
            grpCardInfo = new GroupBox();
            groupBox2 = new GroupBox();
            pictureHome = new PictureBox();
            lblIdS = new Label();
            lblNameS = new Label();
            lblId = new Label();
            lblName = new Label();
            btnUpdate = new Button();
            cmbPayment = new ComboBox();
            grpCardInfo.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(99, 122);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(200, 23);
            txtCVV.TabIndex = 0;
            // 
            // txtCard
            // 
            txtCard.Location = new Point(99, 71);
            txtCard.Name = "txtCard";
            txtCard.Size = new Size(200, 23);
            txtCard.TabIndex = 1;
            // 
            // lblPayMethod
            // 
            lblPayMethod.AutoSize = true;
            lblPayMethod.Location = new Point(48, 219);
            lblPayMethod.Name = "lblPayMethod";
            lblPayMethod.Size = new Size(99, 15);
            lblPayMethod.TabIndex = 3;
            lblPayMethod.Text = "Payment Method";
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Location = new Point(14, 74);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(79, 15);
            lblCard.TabIndex = 4;
            lblCard.Text = "Card Number";
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Location = new Point(14, 125);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(29, 15);
            lblCVV.TabIndex = 5;
            lblCVV.Text = "CVV";
            // 
            // grpCardInfo
            // 
            grpCardInfo.Controls.Add(txtCard);
            grpCardInfo.Controls.Add(txtCVV);
            grpCardInfo.Controls.Add(lblCVV);
            grpCardInfo.Controls.Add(lblCard);
            grpCardInfo.Location = new Point(416, 159);
            grpCardInfo.Name = "grpCardInfo";
            grpCardInfo.Size = new Size(317, 235);
            grpCardInfo.TabIndex = 6;
            grpCardInfo.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureHome);
            groupBox2.Controls.Add(lblIdS);
            groupBox2.Controls.Add(lblNameS);
            groupBox2.Controls.Add(lblId);
            groupBox2.Controls.Add(lblName);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 100);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(725, 9);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 54;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // lblIdS
            // 
            lblIdS.BorderStyle = BorderStyle.Fixed3D;
            lblIdS.Location = new Point(116, 60);
            lblIdS.Name = "lblIdS";
            lblIdS.Size = new Size(200, 25);
            lblIdS.TabIndex = 3;
            // 
            // lblNameS
            // 
            lblNameS.BorderStyle = BorderStyle.Fixed3D;
            lblNameS.Location = new Point(116, 25);
            lblNameS.Name = "lblNameS";
            lblNameS.Size = new Size(200, 25);
            lblNameS.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(68, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Student ID :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(149, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Items.AddRange(new object[] { "", "Cash", "Credit Card", "Online Payment" });
            cmbPayment.Location = new Point(160, 216);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(200, 23);
            cmbPayment.TabIndex = 9;
            // 
            // Update_Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPayment);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox2);
            Controls.Add(grpCardInfo);
            Controls.Add(lblPayMethod);
            Name = "Update_Payment";
            Text = "Update_Payment";
            grpCardInfo.ResumeLayout(false);
            grpCardInfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCVV;
        private TextBox txtCard;
        private TextBox textBox3;
        private Label lblPayMethod;
        private Label lblCard;
        private Label lblCVV;
        private GroupBox grpCardInfo;
        private GroupBox groupBox2;
        private Label lblIdS;
        private Label lblNameS;
        private Label lblId;
        private Label lblName;
        private Button btnUpdate;
        private PictureBox pictureHome;
        private ComboBox cmbPayment;
    }
}