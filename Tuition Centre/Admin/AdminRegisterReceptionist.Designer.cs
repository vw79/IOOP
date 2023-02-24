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
            lblName = new Label();
            txtbName = new TextBox();
            txtbIcP = new TextBox();
            txtbEmail = new TextBox();
            lblPhone = new Label();
            txtbPhone = new TextBox();
            lblAddress = new Label();
            txtbAddress = new TextBox();
            lbIcP = new Label();
            lblEmail = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(89, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtbName
            // 
            txtbName.Location = new Point(89, 74);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(172, 23);
            txtbName.TabIndex = 2;
            // 
            // txtbIcP
            // 
            txtbIcP.Location = new Point(331, 74);
            txtbIcP.Name = "txtbIcP";
            txtbIcP.Size = new Size(172, 23);
            txtbIcP.TabIndex = 4;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(89, 124);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(172, 23);
            txtbEmail.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(331, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(125, 21);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Contact Number";
            // 
            // txtbPhone
            // 
            txtbPhone.Location = new Point(331, 124);
            txtbPhone.Name = "txtbPhone";
            txtbPhone.Size = new Size(172, 23);
            txtbPhone.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(89, 150);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 21);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // txtbAddress
            // 
            txtbAddress.Location = new Point(89, 174);
            txtbAddress.Name = "txtbAddress";
            txtbAddress.Size = new Size(172, 23);
            txtbAddress.TabIndex = 10;
            // 
            // lbIcP
            // 
            lbIcP.AutoSize = true;
            lbIcP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbIcP.Location = new Point(331, 50);
            lbIcP.Name = "lbIcP";
            lbIcP.Size = new Size(89, 21);
            lbIcP.TabIndex = 11;
            lbIcP.Text = "IC/Passport";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(89, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(403, 242);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 50);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmAdminRegisterReceptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 372);
            Controls.Add(btnRegister);
            Controls.Add(lblEmail);
            Controls.Add(lbIcP);
            Controls.Add(txtbAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtbPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtbEmail);
            Controls.Add(txtbIcP);
            Controls.Add(txtbName);
            Controls.Add(lblName);
            Name = "FrmAdminRegisterReceptionist";
            Text = "Register Receptionist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private TextBox txtbName;
        private TextBox txtbIcP;
        private TextBox txtbEmail;
        private Label lblPhone;
        private TextBox txtbPhone;
        private Label lblAddress;
        private TextBox txtbAddress;
        private Label lbIcP;
        private Label lblEmail;
        private Button btnRegister;
    }
}