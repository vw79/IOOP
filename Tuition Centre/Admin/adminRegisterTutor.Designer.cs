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
            txtbUsername = new TextBox();
            lblUsername = new Label();
            lblSubject = new Label();
            lblPhone = new Label();
            txtbPhone = new TextBox();
            lblAddress = new Label();
            txtbAddress = new TextBox();
            lblLevel = new Label();
            cmbLevel = new ComboBox();
            btnRegister = new Button();
            lblEmail = new Label();
            txtbEmail = new TextBox();
            lblFullName = new Label();
            txtbFullName = new TextBox();
            lblIcP = new Label();
            txtbIcP = new TextBox();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            txtbSubject = new TextBox();
            lblPassword = new Label();
            txtbPassword = new TextBox();
            SuspendLayout();
            // 
            // txtbUsername
            // 
            txtbUsername.Location = new Point(268, 213);
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(200, 23);
            txtbUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(268, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(268, 32);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(61, 21);
            lblSubject.TabIndex = 4;
            lblSubject.Text = "Subject";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(48, 89);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(125, 21);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Contact Number";
            // 
            // txtbPhone
            // 
            txtbPhone.Location = new Point(48, 113);
            txtbPhone.Name = "txtbPhone";
            txtbPhone.Size = new Size(172, 23);
            txtbPhone.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(48, 189);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 21);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // txtbAddress
            // 
            txtbAddress.Location = new Point(48, 213);
            txtbAddress.Name = "txtbAddress";
            txtbAddress.Size = new Size(172, 23);
            txtbAddress.TabIndex = 9;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLevel.Location = new Point(268, 82);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(46, 21);
            lblLevel.TabIndex = 13;
            lblLevel.Text = "Level";
            // 
            // cmbLevel
            // 
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "level 1", "level 2", "level 3", "level 4", "level 5" });
            cmbLevel.Location = new Point(268, 106);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(200, 23);
            cmbLevel.TabIndex = 14;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(368, 324);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 50);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(48, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(48, 263);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(172, 23);
            txtbEmail.TabIndex = 18;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.Location = new Point(48, 32);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(81, 21);
            lblFullName.TabIndex = 19;
            lblFullName.Text = "Full Name";
            // 
            // txtbFullName
            // 
            txtbFullName.Location = new Point(48, 56);
            txtbFullName.Name = "txtbFullName";
            txtbFullName.Size = new Size(172, 23);
            txtbFullName.TabIndex = 20;
            // 
            // lblIcP
            // 
            lblIcP.AutoSize = true;
            lblIcP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIcP.Location = new Point(48, 139);
            lblIcP.Name = "lblIcP";
            lblIcP.Size = new Size(89, 21);
            lblIcP.TabIndex = 21;
            lblIcP.Text = "IC/Passport";
            // 
            // txtbIcP
            // 
            txtbIcP.Location = new Point(48, 163);
            txtbIcP.Name = "txtbIcP";
            txtbIcP.Size = new Size(172, 23);
            txtbIcP.TabIndex = 22;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(268, 163);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 23;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOB.Location = new Point(268, 139);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(97, 21);
            lblDOB.TabIndex = 24;
            lblDOB.Text = "Date of Birth";
            // 
            // txtbSubject
            // 
            txtbSubject.Location = new Point(268, 56);
            txtbSubject.Name = "txtbSubject";
            txtbSubject.Size = new Size(200, 23);
            txtbSubject.TabIndex = 25;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(268, 239);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 26;
            lblPassword.Text = "Password";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(268, 263);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(200, 23);
            txtbPassword.TabIndex = 27;
            // 
            // FrmAdminRegisterTutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 412);
            Controls.Add(txtbPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtbSubject);
            Controls.Add(lblDOB);
            Controls.Add(dtpDOB);
            Controls.Add(txtbIcP);
            Controls.Add(lblIcP);
            Controls.Add(txtbFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtbEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnRegister);
            Controls.Add(cmbLevel);
            Controls.Add(lblLevel);
            Controls.Add(txtbAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtbPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblSubject);
            Controls.Add(lblUsername);
            Controls.Add(txtbUsername);
            Name = "FrmAdminRegisterTutor";
            Text = "Register Tutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbUsername;
        private Label lblUsername;
        private Label lblSubject;
        private Label lblPhone;
        private TextBox txtbPhone;
        private Label lblAddress;
        private TextBox txtbAddress;
        private Label lblLevel;
        private ComboBox cmbLevel;
        private Button btnRegister;
        private Label lblEmail;
        private TextBox txtbEmail;
        private Label lblFullName;
        private TextBox txtbFullName;
        private Label lblIcP;
        private TextBox txtbIcP;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private TextBox txtbSubject;
        private Label lblPassword;
        private TextBox txtbPassword;
    }
}