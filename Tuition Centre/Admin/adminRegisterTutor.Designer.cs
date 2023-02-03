namespace Tuition_Centre.Admin
{
    partial class FrmAdminRegisterTutor
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
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.chlstbSubject = new System.Windows.Forms.CheckedListBox();
            this.picbPotrait = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbPotrait)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(12, 87);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 23);
            this.txtbName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 113);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(12, 131);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 23);
            this.txtbID.TabIndex = 3;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(12, 157);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(75, 15);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(12, 175);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 23);
            this.txtDOB.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 201);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Contact Number";
            // 
            // txtbPhone
            // 
            this.txtbPhone.Location = new System.Drawing.Point(12, 219);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(100, 23);
            this.txtbPhone.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 245);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 9;
            // 
            // chlstbSubject
            // 
            this.chlstbSubject.FormattingEnabled = true;
            this.chlstbSubject.Location = new System.Drawing.Point(12, 292);
            this.chlstbSubject.Name = "chlstbSubject";
            this.chlstbSubject.Size = new System.Drawing.Size(357, 148);
            this.chlstbSubject.TabIndex = 10;
            // 
            // picbPotrait
            // 
            this.picbPotrait.Location = new System.Drawing.Point(12, 6);
            this.picbPotrait.Name = "picbPotrait";
            this.picbPotrait.Size = new System.Drawing.Size(50, 60);
            this.picbPotrait.TabIndex = 11;
            this.picbPotrait.TabStop = false;
            // 
            // FrmAdminRegisterTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picbPotrait);
            this.Controls.Add(this.chlstbSubject);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbName);
            this.Name = "FrmAdminRegisterTutor";
            this.Text = "Register Tutor";
            ((System.ComponentModel.ISupportInitialize)(this.picbPotrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbName;
        private Label lblName;
        private Label lblID;
        private TextBox txtbID;
        private Label lblDOB;
        private TextBox txtDOB;
        private Label lblPhone;
        private TextBox txtbPhone;
        private Label lblAddress;
        private TextBox textBox5;
        private CheckedListBox chlstbSubject;
        private PictureBox picbPotrait;
    }
}