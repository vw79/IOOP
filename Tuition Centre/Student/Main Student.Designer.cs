namespace Tuition_Centre.Student
{
    partial class frmMainStudent
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
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblStudentCourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.cmbChangeSubject = new System.Windows.Forms.ComboBox();
            this.grpChangeSubject = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpChangeSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProfile.Image = global::Tuition_Centre.Properties.Resources.catt;
            this.picProfile.Location = new System.Drawing.Point(137, 64);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(194, 190);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.Image = global::Tuition_Centre.Properties.Resources.edit;
            this.picEdit.Location = new System.Drawing.Point(294, 204);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(60, 50);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 1;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblStudentNum);
            this.groupBox1.Controls.Add(this.lblStudentCourse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(131, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNum.Location = new System.Drawing.Point(41, 19);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(129, 21);
            this.lblStudentNum.TabIndex = 4;
            this.lblStudentNum.Text = "Student  Number";
            // 
            // lblStudentCourse
            // 
            this.lblStudentCourse.AutoSize = true;
            this.lblStudentCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentCourse.Location = new System.Drawing.Point(53, 45);
            this.lblStudentCourse.Name = "lblStudentCourse";
            this.lblStudentCourse.Size = new System.Drawing.Size(102, 21);
            this.lblStudentCourse.TabIndex = 2;
            this.lblStudentCourse.Text = "Study Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(150, 269);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(171, 32);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Student  Name";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSchedule.Location = new System.Drawing.Point(457, 229);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(206, 72);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "My Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // cmbChangeSubject
            // 
            this.cmbChangeSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbChangeSubject.FormattingEnabled = true;
            this.cmbChangeSubject.Items.AddRange(new object[] {
            "Request to change the subject",
            "View the process"});
            this.cmbChangeSubject.Location = new System.Drawing.Point(16, 22);
            this.cmbChangeSubject.Name = "cmbChangeSubject";
            this.cmbChangeSubject.Size = new System.Drawing.Size(219, 29);
            this.cmbChangeSubject.TabIndex = 6;
            this.cmbChangeSubject.Text = "Request / Cancel Request";
            this.cmbChangeSubject.SelectedIndexChanged += new System.EventHandler(this.cmbChangeSubject_SelectedIndexChanged);
            // 
            // grpChangeSubject
            // 
            this.grpChangeSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpChangeSubject.Controls.Add(this.cmbChangeSubject);
            this.grpChangeSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpChangeSubject.Location = new System.Drawing.Point(543, 39);
            this.grpChangeSubject.Name = "grpChangeSubject";
            this.grpChangeSubject.Size = new System.Drawing.Size(245, 63);
            this.grpChangeSubject.TabIndex = 7;
            this.grpChangeSubject.TabStop = false;
            this.grpChangeSubject.Text = "Change the Subject";
            this.grpChangeSubject.Enter += new System.EventHandler(this.grpChangeSubject_Enter);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(457, 204);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(112, 17);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome, Student";
            // 
            // frmMainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.grpChangeSubject);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.picProfile);
            this.Name = "frmMainStudent";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpChangeSubject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picProfile;
        private PictureBox picEdit;
        private GroupBox groupBox1;
        private Label lblStudentCourse;
        private Label label2;
        private Label lblStudentNum;
        private Label lblStudentName;
        private Button btnSchedule;
        private ComboBox cmbChangeSubject;
        private GroupBox grpChangeSubject;
        private Label lblWelcome;
    }
}