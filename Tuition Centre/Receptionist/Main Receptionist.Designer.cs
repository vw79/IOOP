namespace Tuition_Centre.Receptionist
{
    partial class frmMainReceptionist
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
            btnRegNewStu = new Button();
            btnUpdateRcpInfo = new Button();
            btnUpdateStudentInfo = new Button();
            btnPayment = new Button();
            lblWlcRcp = new Label();
            picLogout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            SuspendLayout();
            // 
            // btnRegNewStu
            // 
            btnRegNewStu.Location = new Point(173, 186);
            btnRegNewStu.Name = "btnRegNewStu";
            btnRegNewStu.Size = new Size(160, 23);
            btnRegNewStu.TabIndex = 0;
            btnRegNewStu.Text = "Register New Student";
            btnRegNewStu.UseVisualStyleBackColor = true;
            btnRegNewStu.Click += btnRegNewStu_Click;
            // 
            // btnUpdateRcpInfo
            // 
            btnUpdateRcpInfo.Location = new Point(443, 186);
            btnUpdateRcpInfo.Name = "btnUpdateRcpInfo";
            btnUpdateRcpInfo.Size = new Size(160, 23);
            btnUpdateRcpInfo.TabIndex = 1;
            btnUpdateRcpInfo.Text = "Update Receptionist Info";
            btnUpdateRcpInfo.UseVisualStyleBackColor = true;
            btnUpdateRcpInfo.Click += btnUpdateRcpInfo_Click;
            // 
            // btnUpdateStudentInfo
            // 
            btnUpdateStudentInfo.Location = new Point(173, 289);
            btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            btnUpdateStudentInfo.Size = new Size(160, 23);
            btnUpdateStudentInfo.TabIndex = 2;
            btnUpdateStudentInfo.Text = "Update Student Info";
            btnUpdateStudentInfo.UseVisualStyleBackColor = true;
            btnUpdateStudentInfo.Click += btnUpdateStudentInfo_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(443, 289);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(160, 23);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblWlcRcp
            // 
            lblWlcRcp.AutoSize = true;
            lblWlcRcp.Location = new Point(80, 86);
            lblWlcRcp.Name = "lblWlcRcp";
            lblWlcRcp.Size = new Size(156, 15);
            lblWlcRcp.TabIndex = 4;
            lblWlcRcp.Text = "Welcome back, [your name]";
            // 
            // picLogout
            // 
            picLogout.Image = Properties.Resources.logout;
            picLogout.Location = new Point(728, 12);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(60, 46);
            picLogout.SizeMode = PictureBoxSizeMode.Zoom;
            picLogout.TabIndex = 10;
            picLogout.TabStop = false;
            picLogout.Click += picLogout_Click;
            // 
            // frmMainReceptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picLogout);
            Controls.Add(lblWlcRcp);
            Controls.Add(btnPayment);
            Controls.Add(btnUpdateStudentInfo);
            Controls.Add(btnUpdateRcpInfo);
            Controls.Add(btnRegNewStu);
            Name = "frmMainReceptionist";
            Text = "Receptionist";
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegNewStu;
        private Button btnUpdateRcpInfo;
        private Button btnUpdateStudentInfo;
        private Button btnPayment;
        private Label lblWlcRcp;
        private PictureBox picLogout;
    }
}