namespace Tuition_Centre.Admin
{
    partial class FrmAdminRegisterReceptionist
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
            this.picbPotrait = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtbDOB = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbPotrait)).BeginInit();
            this.SuspendLayout();
            // 
            // picbPotrait
            // 
            this.picbPotrait.Location = new System.Drawing.Point(12, 12);
            this.picbPotrait.Name = "picbPotrait";
            this.picbPotrait.Size = new System.Drawing.Size(50, 60);
            this.picbPotrait.TabIndex = 0;
            this.picbPotrait.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(12, 93);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 23);
            this.txtbName.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 119);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(12, 137);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 23);
            this.txtbID.TabIndex = 4;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(12, 163);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(75, 15);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // txtbDOB
            // 
            this.txtbDOB.Location = new System.Drawing.Point(12, 181);
            this.txtbDOB.Name = "txtbDOB";
            this.txtbDOB.Size = new System.Drawing.Size(100, 23);
            this.txtbDOB.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 207);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 15);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Contact Number";
            // 
            // txtbPhone
            // 
            this.txtbPhone.Location = new System.Drawing.Point(12, 225);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(100, 23);
            this.txtbPhone.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 251);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(12, 269);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(100, 23);
            this.txtbAddress.TabIndex = 10;
            // 
            // FrmAdminRegisterReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtbDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picbPotrait);
            this.Name = "FrmAdminRegisterReceptionist";
            this.Text = "Register Receptionist";
            ((System.ComponentModel.ISupportInitialize)(this.picbPotrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picbPotrait;
        private Label lblName;
        private TextBox txtbName;
        private Label lblID;
        private TextBox txtbID;
        private Label lblDOB;
        private TextBox txtbDOB;
        private Label lblPhone;
        private TextBox txtbPhone;
        private Label lblAddress;
        private TextBox txtbAddress;
    }
}