namespace Tuition_Centre.Admin
{
    partial class FrmAdminUpdateProfile
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
            lblEmail = new Label();
            txtbEmail = new TextBox();
            lblPhone = new Label();
            txtbPhone = new TextBox();
            lblAddress = new Label();
            txtbAddress = new TextBox();
            lblUsername = new Label();
            txtbUsername = new TextBox();
            lblPassword = new Label();
            txtbPassword = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(96, 109);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(96, 133);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(138, 23);
            txtbEmail.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(263, 9);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 21);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // txtbPhone
            // 
            txtbPhone.Location = new Point(263, 33);
            txtbPhone.Name = "txtbPhone";
            txtbPhone.Size = new Size(138, 23);
            txtbPhone.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(263, 59);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 21);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // txtbAddress
            // 
            txtbAddress.Location = new Point(263, 83);
            txtbAddress.Name = "txtbAddress";
            txtbAddress.Size = new Size(138, 23);
            txtbAddress.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(96, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // txtbUsername
            // 
            txtbUsername.Location = new Point(96, 33);
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(138, 23);
            txtbUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(96, 59);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(96, 83);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(138, 23);
            txtbPassword.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(301, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 50);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmAdminUpdateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 289);
            Controls.Add(btnUpdate);
            Controls.Add(txtbPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtbUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtbAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtbPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtbEmail);
            Controls.Add(lblEmail);
            Name = "FrmAdminUpdateProfile";
            Text = "Update Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtbEmail;
        private Label lblPhone;
        private TextBox txtbPhone;
        private Label lblAddress;
        private TextBox txtbAddress;
        private Label lblUsername;
        private TextBox txtbUsername;
        private Label lblPassword;
        private TextBox txtbPassword;
        private Button btnUpdate;
    }
}