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
            this.SuspendLayout();
            // 
            // btnRegNewStu
            // 
            this.btnRegNewStu.Location = new System.Drawing.Point(173, 186);
            this.btnRegNewStu.Name = "btnRegNewStu";
            this.btnRegNewStu.Size = new System.Drawing.Size(160, 23);
            this.btnRegNewStu.TabIndex = 0;
            this.btnRegNewStu.Text = "Register New Student";
            this.btnRegNewStu.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRcpInfo
            // 
            this.btnUpdateRcpInfo.Location = new System.Drawing.Point(443, 186);
            this.btnUpdateRcpInfo.Name = "btnUpdateRcpInfo";
            this.btnUpdateRcpInfo.Size = new System.Drawing.Size(160, 23);
            this.btnUpdateRcpInfo.TabIndex = 1;
            this.btnUpdateRcpInfo.Text = "Update Receptionist Info";
            this.btnUpdateRcpInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudentInfo
            // 
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(173, 289);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(160, 23);
            this.btnUpdateStudentInfo.TabIndex = 2;
            this.btnUpdateStudentInfo.Text = "Update Student Info";
            this.btnUpdateStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(443, 289);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(160, 23);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblWlcRcp
            // 
            this.lblWlcRcp.AutoSize = true;
            this.lblWlcRcp.Location = new System.Drawing.Point(80, 86);
            this.lblWlcRcp.Name = "lblWlcRcp";
            this.lblWlcRcp.Size = new System.Drawing.Size(156, 15);
            this.lblWlcRcp.TabIndex = 4;
            this.lblWlcRcp.Text = "Welcome back, [your name]";
            // 
            // frmMainReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWlcRcp);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnUpdateStudentInfo);
            this.Controls.Add(this.btnUpdateRcpInfo);
            this.Controls.Add(this.btnRegNewStu);
            this.Name = "frmMainReceptionist";
            this.Text = "Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegNewStu;
        private Button btnUpdateRcpInfo;
        private Button btnUpdateStudentInfo;
        private Button btnPayment;
        private Label lblWlcRcp;
    }
}