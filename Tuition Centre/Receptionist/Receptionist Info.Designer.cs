namespace Tuition_Centre.Receptionist
{
    partial class frmUpdateRcp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateRcp));
            panel2 = new Panel();
            pictureHome = new PictureBox();
            lblRcpICS = new Label();
            lblRcpNameS = new Label();
            lblRcpIDS = new Label();
            lblRcpIC = new Label();
            lblRcpName = new Label();
            lblRcpID = new Label();
            panel3 = new Panel();
            txtAdress = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            btnUpdate = new Button();
            lblAdress = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureHome);
            panel2.Controls.Add(lblRcpICS);
            panel2.Controls.Add(lblRcpNameS);
            panel2.Controls.Add(lblRcpIDS);
            panel2.Controls.Add(lblRcpIC);
            panel2.Controls.Add(lblRcpName);
            panel2.Controls.Add(lblRcpID);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 113);
            panel2.TabIndex = 4;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(725, 0);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 47;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // lblRcpICS
            // 
            lblRcpICS.BorderStyle = BorderStyle.Fixed3D;
            lblRcpICS.Location = new Point(146, 71);
            lblRcpICS.Name = "lblRcpICS";
            lblRcpICS.Size = new Size(200, 20);
            lblRcpICS.TabIndex = 6;
            // 
            // lblRcpNameS
            // 
            lblRcpNameS.BorderStyle = BorderStyle.Fixed3D;
            lblRcpNameS.Location = new Point(146, 45);
            lblRcpNameS.Name = "lblRcpNameS";
            lblRcpNameS.Size = new Size(200, 20);
            lblRcpNameS.TabIndex = 5;
            // 
            // lblRcpIDS
            // 
            lblRcpIDS.BorderStyle = BorderStyle.Fixed3D;
            lblRcpIDS.Location = new Point(146, 21);
            lblRcpIDS.Name = "lblRcpIDS";
            lblRcpIDS.Size = new Size(200, 20);
            lblRcpIDS.TabIndex = 4;
            // 
            // lblRcpIC
            // 
            lblRcpIC.AutoSize = true;
            lblRcpIC.Location = new Point(18, 72);
            lblRcpIC.Name = "lblRcpIC";
            lblRcpIC.Size = new Size(77, 15);
            lblRcpIC.TabIndex = 3;
            lblRcpIC.Text = "IC/ Passport :";
            // 
            // lblRcpName
            // 
            lblRcpName.AutoSize = true;
            lblRcpName.Location = new Point(18, 46);
            lblRcpName.Name = "lblRcpName";
            lblRcpName.Size = new Size(45, 15);
            lblRcpName.TabIndex = 2;
            lblRcpName.Text = "Name :";
            // 
            // lblRcpID
            // 
            lblRcpID.AutoSize = true;
            lblRcpID.Location = new Point(18, 22);
            lblRcpID.Name = "lblRcpID";
            lblRcpID.Size = new Size(24, 15);
            lblRcpID.TabIndex = 1;
            lblRcpID.Text = "ID :";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtAdress);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(lblAdress);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblContact);
            panel3.Location = new Point(12, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 307);
            panel3.TabIndex = 5;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(426, 113);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(200, 23);
            txtAdress.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(123, 113);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(491, 194);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(426, 95);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(49, 15);
            lblAdress.TabIndex = 2;
            lblAdress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(123, 176);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(123, 95);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(96, 15);
            lblContact.TabIndex = 0;
            lblContact.Text = "Contact Number";
            // 
            // frmUpdateRcp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmUpdateRcp";
            Text = "Form6";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblRcpName;
        private Label lblRcpID;
        private Label lblRcpICS;
        private Label lblRcpNameS;
        private Label lblRcpIDS;
        private Label lblRcpIC;
        private Panel panel3;
        private TextBox txtAdress;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnUpdate;
        private Label lblAdress;
        private Label lblEmail;
        private Label lblContact;
        private PictureBox pictureHome;
    }
}