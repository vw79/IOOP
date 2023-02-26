namespace Tuition_Centre.Student
{
    partial class EditProfile
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
            picEdit = new PictureBox();
            picProfile = new PictureBox();
            groupBox1 = new GroupBox();
            grpStudentNumber = new GroupBox();
            lblStudentNumber = new Label();
            grpmemo = new GroupBox();
            txtmemo = new TextBox();
            grpEmail = new GroupBox();
            txtEmail = new TextBox();
            grpPhoneNumber = new GroupBox();
            txtPhoneNumber = new TextBox();
            grpBirthday = new GroupBox();
            birthday = new DateTimePicker();
            grpPassport = new GroupBox();
            txtPassport = new TextBox();
            label1 = new Label();
            grpStudyCourse = new GroupBox();
            lblStudyCourse = new Label();
            grpName = new GroupBox();
            lblName = new Label();
            lblStudentName = new Label();
            groupBox2 = new GroupBox();
            lblStudentNum = new Label();
            lblStudentCourse = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            pictureHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            groupBox1.SuspendLayout();
            grpStudentNumber.SuspendLayout();
            grpmemo.SuspendLayout();
            grpEmail.SuspendLayout();
            grpPhoneNumber.SuspendLayout();
            grpBirthday.SuspendLayout();
            grpPassport.SuspendLayout();
            grpStudyCourse.SuspendLayout();
            grpName.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // picEdit
            // 
            picEdit.Image = Properties.Resources.edit;
            picEdit.Location = new Point(261, 260);
            picEdit.Margin = new Padding(3, 4, 3, 4);
            picEdit.Name = "picEdit";
            picEdit.Size = new Size(69, 67);
            picEdit.SizeMode = PictureBoxSizeMode.Zoom;
            picEdit.TabIndex = 3;
            picEdit.TabStop = false;
            // 
            // picProfile
            // 
            picProfile.BorderStyle = BorderStyle.Fixed3D;
            picProfile.Image = Properties.Resources.catt;
            picProfile.Location = new Point(81, 73);
            picProfile.Margin = new Padding(3, 4, 3, 4);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(221, 252);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 2;
            picProfile.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(grpStudentNumber);
            groupBox1.Controls.Add(grpmemo);
            groupBox1.Controls.Add(grpEmail);
            groupBox1.Controls.Add(grpPhoneNumber);
            groupBox1.Controls.Add(grpBirthday);
            groupBox1.Controls.Add(grpPassport);
            groupBox1.Controls.Add(grpStudyCourse);
            groupBox1.Controls.Add(grpName);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(375, 56);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(479, 476);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // grpStudentNumber
            // 
            grpStudentNumber.BackColor = SystemColors.ControlLight;
            grpStudentNumber.Controls.Add(lblStudentNumber);
            grpStudentNumber.Location = new Point(27, 253);
            grpStudentNumber.Margin = new Padding(3, 4, 3, 4);
            grpStudentNumber.Name = "grpStudentNumber";
            grpStudentNumber.Padding = new Padding(3, 4, 3, 4);
            grpStudentNumber.Size = new Size(205, 71);
            grpStudentNumber.TabIndex = 15;
            grpStudentNumber.TabStop = false;
            grpStudentNumber.Text = "Student Number";
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.BackColor = SystemColors.InactiveCaption;
            lblStudentNumber.BorderStyle = BorderStyle.FixedSingle;
            lblStudentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentNumber.Location = new Point(15, 25);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new Size(189, 30);
            lblStudentNumber.TabIndex = 7;
            lblStudentNumber.Text = "   Student Number   ";
            // 
            // grpmemo
            // 
            grpmemo.BackColor = SystemColors.ControlLight;
            grpmemo.Controls.Add(txtmemo);
            grpmemo.Location = new Point(27, 332);
            grpmemo.Margin = new Padding(3, 4, 3, 4);
            grpmemo.Name = "grpmemo";
            grpmemo.Padding = new Padding(3, 4, 3, 4);
            grpmemo.Size = new Size(430, 131);
            grpmemo.TabIndex = 14;
            grpmemo.TabStop = false;
            grpmemo.Text = "Write about yourself";
            // 
            // txtmemo
            // 
            txtmemo.BackColor = SystemColors.ControlLightLight;
            txtmemo.Location = new Point(15, 29);
            txtmemo.Margin = new Padding(3, 4, 3, 4);
            txtmemo.Multiline = true;
            txtmemo.Name = "txtmemo";
            txtmemo.PlaceholderText = "Type something here....";
            txtmemo.Size = new Size(405, 92);
            txtmemo.TabIndex = 0;
            // 
            // grpEmail
            // 
            grpEmail.BackColor = SystemColors.ControlLight;
            grpEmail.Controls.Add(txtEmail);
            grpEmail.Location = new Point(253, 180);
            grpEmail.Margin = new Padding(3, 4, 3, 4);
            grpEmail.Name = "grpEmail";
            grpEmail.Padding = new Padding(3, 4, 3, 4);
            grpEmail.Size = new Size(205, 65);
            grpEmail.TabIndex = 13;
            grpEmail.TabStop = false;
            grpEmail.Text = "Email                                ";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Location = new Point(13, 27);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(182, 27);
            txtEmail.TabIndex = 2;
            // 
            // grpPhoneNumber
            // 
            grpPhoneNumber.BackColor = SystemColors.ControlLight;
            grpPhoneNumber.Controls.Add(txtPhoneNumber);
            grpPhoneNumber.Location = new Point(27, 180);
            grpPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            grpPhoneNumber.Name = "grpPhoneNumber";
            grpPhoneNumber.Padding = new Padding(3, 4, 3, 4);
            grpPhoneNumber.Size = new Size(205, 65);
            grpPhoneNumber.TabIndex = 12;
            grpPhoneNumber.TabStop = false;
            grpPhoneNumber.Text = "Phone Number                                  ";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Location = new Point(15, 27);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(182, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // grpBirthday
            // 
            grpBirthday.BackColor = SystemColors.ControlLight;
            grpBirthday.Controls.Add(birthday);
            grpBirthday.Location = new Point(253, 107);
            grpBirthday.Margin = new Padding(3, 4, 3, 4);
            grpBirthday.Name = "grpBirthday";
            grpBirthday.Padding = new Padding(3, 4, 3, 4);
            grpBirthday.Size = new Size(205, 65);
            grpBirthday.TabIndex = 1;
            grpBirthday.TabStop = false;
            grpBirthday.Text = "Birthday                                 ";
            // 
            // birthday
            // 
            birthday.Format = DateTimePickerFormat.Custom;
            birthday.Location = new Point(13, 25);
            birthday.Margin = new Padding(3, 4, 3, 4);
            birthday.Name = "birthday";
            birthday.Size = new Size(183, 27);
            birthday.TabIndex = 0;
            // 
            // grpPassport
            // 
            grpPassport.BackColor = SystemColors.ControlLight;
            grpPassport.Controls.Add(txtPassport);
            grpPassport.Controls.Add(label1);
            grpPassport.Location = new Point(27, 107);
            grpPassport.Margin = new Padding(3, 4, 3, 4);
            grpPassport.Name = "grpPassport";
            grpPassport.Padding = new Padding(3, 4, 3, 4);
            grpPassport.Size = new Size(205, 65);
            grpPassport.TabIndex = 11;
            grpPassport.TabStop = false;
            grpPassport.Text = "Passport Number / Mykad                                  ";
            // 
            // txtPassport
            // 
            txtPassport.BackColor = SystemColors.ControlLightLight;
            txtPassport.Location = new Point(15, 25);
            txtPassport.Margin = new Padding(3, 4, 3, 4);
            txtPassport.Name = "txtPassport";
            txtPassport.PlaceholderText = "Passport Number / Mykad";
            txtPassport.Size = new Size(182, 27);
            txtPassport.TabIndex = 1;
            txtPassport.TextChanged += txtPassport_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(2, 30);
            label1.TabIndex = 0;
            // 
            // grpStudyCourse
            // 
            grpStudyCourse.BackColor = SystemColors.ControlLight;
            grpStudyCourse.Controls.Add(lblStudyCourse);
            grpStudyCourse.Location = new Point(253, 253);
            grpStudyCourse.Margin = new Padding(3, 4, 3, 4);
            grpStudyCourse.Name = "grpStudyCourse";
            grpStudyCourse.Padding = new Padding(3, 4, 3, 4);
            grpStudyCourse.Size = new Size(205, 71);
            grpStudyCourse.TabIndex = 10;
            grpStudyCourse.TabStop = false;
            grpStudyCourse.Text = "Study Course";
            // 
            // lblStudyCourse
            // 
            lblStudyCourse.AutoSize = true;
            lblStudyCourse.BackColor = SystemColors.InactiveCaption;
            lblStudyCourse.BorderStyle = BorderStyle.FixedSingle;
            lblStudyCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudyCourse.Location = new Point(15, 28);
            lblStudyCourse.Name = "lblStudyCourse";
            lblStudyCourse.Size = new Size(199, 30);
            lblStudyCourse.TabIndex = 8;
            lblStudyCourse.Text = "       Study Course       ";
            // 
            // grpName
            // 
            grpName.BackColor = SystemColors.ControlLight;
            grpName.Controls.Add(lblName);
            grpName.Location = new Point(27, 29);
            grpName.Margin = new Padding(3, 4, 3, 4);
            grpName.Name = "grpName";
            grpName.Padding = new Padding(3, 4, 3, 4);
            grpName.Size = new Size(430, 65);
            grpName.TabIndex = 0;
            grpName.TabStop = false;
            grpName.Text = "Name                                  ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ControlLightLight;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(15, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(441, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name                                                                           ";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = SystemColors.InactiveCaption;
            lblStudentName.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblStudentName.Location = new Point(96, 349);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(214, 41);
            lblStudentName.TabIndex = 6;
            lblStudentName.Text = "Student  Name";
            lblStudentName.Click += lblStudentName_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(lblStudentNum);
            groupBox2.Controls.Add(lblStudentCourse);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(74, 379);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 93);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // lblStudentNum
            // 
            lblStudentNum.AutoSize = true;
            lblStudentNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentNum.Location = new Point(47, 25);
            lblStudentNum.Name = "lblStudentNum";
            lblStudentNum.Size = new Size(162, 28);
            lblStudentNum.TabIndex = 4;
            lblStudentNum.Text = "Student  Number";
            lblStudentNum.Click += lblStudentNum_Click;
            // 
            // lblStudentCourse
            // 
            lblStudentCourse.AutoSize = true;
            lblStudentCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentCourse.Location = new Point(61, 60);
            lblStudentCourse.Name = "lblStudentCourse";
            lblStudentCourse.Size = new Size(127, 28);
            lblStudentCourse.TabIndex = 2;
            lblStudentCourse.Text = "Study Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 40);
            label2.Name = "label2";
            label2.Size = new Size(207, 20);
            label2.TabIndex = 1;
            label2.Text = "_________________________________";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnUpdate.Location = new Point(375, 540);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 44);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureHome
            // 
            pictureHome.Image = Properties.Resources.home;
            pictureHome.Location = new Point(842, 36);
            pictureHome.Margin = new Padding(3, 4, 3, 4);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(58, 57);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 16;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureHome);
            Controls.Add(btnUpdate);
            Controls.Add(lblStudentName);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(picEdit);
            Controls.Add(picProfile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)picEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            groupBox1.ResumeLayout(false);
            grpStudentNumber.ResumeLayout(false);
            grpStudentNumber.PerformLayout();
            grpmemo.ResumeLayout(false);
            grpmemo.PerformLayout();
            grpEmail.ResumeLayout(false);
            grpEmail.PerformLayout();
            grpPhoneNumber.ResumeLayout(false);
            grpPhoneNumber.PerformLayout();
            grpBirthday.ResumeLayout(false);
            grpPassport.ResumeLayout(false);
            grpPassport.PerformLayout();
            grpStudyCourse.ResumeLayout(false);
            grpStudyCourse.PerformLayout();
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private PictureBox picEdit;
        private PictureBox picProfile;
        private GroupBox groupBox1;
        private GroupBox grpmemo;
        private TextBox txtmemo;
        private GroupBox grpEmail;
        private TextBox txtEmail;
        private GroupBox grpPhoneNumber;
        private TextBox txtPhoneNumber;
        private GroupBox grpBirthday;
        private GroupBox grpPassport;
        private TextBox txtPassport;
        private Label label1;
        private GroupBox grpStudyCourse;
        private Label lblStudyCourse;
        private Label lblStudentNumber;
        private GroupBox grpName;
        private Label lblName;
        private Label lblStudentName;
        private GroupBox groupBox2;
        private Label lblStudentNum;
        private Label lblStudentCourse;
        private Label label2;
        private Button btnUpdate;
        private GroupBox grpStudentNumber;
        private PictureBox pictureHome;
        private DateTimePicker birthday;
    }
}