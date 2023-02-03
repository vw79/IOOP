namespace Tuition_Centre
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(43, 415);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Location = new System.Drawing.Point(168, 415);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(90, 23);
            this.btnReceptionist.TabIndex = 1;
            this.btnReceptionist.Text = "Receptionist";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(325, 415);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 23);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Location = new System.Drawing.Point(454, 415);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(75, 23);
            this.btnTutor.TabIndex = 3;
            this.btnTutor.Text = "Tutor";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(517, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(480, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(202, 39);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(480, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(202, 39);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Image = global::Tuition_Centre.Properties.Resources.logo_;
            this.picLogo.Location = new System.Drawing.Point(26, 44);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(412, 251);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(43, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 346);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnReceptionist);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Main";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdmin;
        private Button btnReceptionist;
        private Button btnStudent;
        private Button btnTutor;
        private Button button1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox picLogo;
        private GroupBox groupBox1;
    }
}