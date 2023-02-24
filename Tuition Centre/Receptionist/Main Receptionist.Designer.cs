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
            this.btnRegNewStu = new System.Windows.Forms.Button();
            this.btnUpdateRcpInfo = new System.Windows.Forms.Button();
            this.btnUpdateStudentInfo = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblWlcRcp = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegNewStu
            // 
            this.btnRegNewStu.Location = new System.Drawing.Point(183, 237);
            this.btnRegNewStu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegNewStu.Name = "btnRegNewStu";
            this.btnRegNewStu.Size = new System.Drawing.Size(201, 65);
            this.btnRegNewStu.TabIndex = 0;
            this.btnRegNewStu.Text = "Register New Student";
            this.btnRegNewStu.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRcpInfo
            // 
            this.btnUpdateRcpInfo.Location = new System.Drawing.Point(491, 237);
            this.btnUpdateRcpInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateRcpInfo.Name = "btnUpdateRcpInfo";
            this.btnUpdateRcpInfo.Size = new System.Drawing.Size(201, 65);
            this.btnUpdateRcpInfo.TabIndex = 1;
            this.btnUpdateRcpInfo.Text = "Update Receptionist Info";
            this.btnUpdateRcpInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudentInfo
            // 
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(183, 375);
            this.btnUpdateStudentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(201, 65);
            this.btnUpdateStudentInfo.TabIndex = 2;
            this.btnUpdateStudentInfo.Text = "Update Student Info";
            this.btnUpdateStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(491, 375);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(201, 65);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // lblWlcRcp
            // 
            this.lblWlcRcp.AutoSize = true;
            this.lblWlcRcp.Location = new System.Drawing.Point(91, 115);
            this.lblWlcRcp.Name = "lblWlcRcp";
            this.lblWlcRcp.Size = new System.Drawing.Size(193, 20);
            this.lblWlcRcp.TabIndex = 4;
            this.lblWlcRcp.Text = "Welcome back, [your name]";
            // 
            // picLogout
            // 
            this.picLogout.Image = global::Tuition_Centre.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(832, 16);
            this.picLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(69, 61);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 10;
            this.picLogout.TabStop = false;
            // 
            // frmMainReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.lblWlcRcp);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnUpdateStudentInfo);
            this.Controls.Add(this.btnUpdateRcpInfo);
            this.Controls.Add(this.btnRegNewStu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainReceptionist";
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.frmMainReceptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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