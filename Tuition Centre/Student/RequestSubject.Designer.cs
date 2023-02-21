namespace Tuition_Centre.Student
{
    partial class RequestSubject
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpOldSubject = new System.Windows.Forms.GroupBox();
            this.cmbOldSubject = new System.Windows.Forms.ComboBox();
            this.grpNewSubject = new System.Windows.Forms.GroupBox();
            this.cmbNewSubject = new System.Windows.Forms.ComboBox();
            this.grpReason = new System.Windows.Forms.GroupBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.picChange = new System.Windows.Forms.PictureBox();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.grpCourse.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpOldSubject.SuspendLayout();
            this.grpNewSubject.SuspendLayout();
            this.grpReason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(103, 85);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(247, 46);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Change Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "_____________________________________________";
            // 
            // grpCourse
            // 
            this.grpCourse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpCourse.Controls.Add(this.txtCourse);
            this.grpCourse.Location = new System.Drawing.Point(113, 173);
            this.grpCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCourse.Size = new System.Drawing.Size(229, 81);
            this.grpCourse.TabIndex = 2;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Course Intake";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(17, 33);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PlaceholderText = "Course Intake";
            this.txtCourse.Size = new System.Drawing.Size(204, 27);
            this.txtCourse.TabIndex = 0;
            // 
            // grpDate
            // 
            this.grpDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpDate.Controls.Add(this.dateTimePicker1);
            this.grpDate.Location = new System.Drawing.Point(113, 263);
            this.grpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDate.Name = "grpDate";
            this.grpDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDate.Size = new System.Drawing.Size(229, 81);
            this.grpDate.TabIndex = 3;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // grpOldSubject
            // 
            this.grpOldSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOldSubject.Controls.Add(this.cmbOldSubject);
            this.grpOldSubject.Location = new System.Drawing.Point(113, 352);
            this.grpOldSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOldSubject.Name = "grpOldSubject";
            this.grpOldSubject.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOldSubject.Size = new System.Drawing.Size(229, 81);
            this.grpOldSubject.TabIndex = 4;
            this.grpOldSubject.TabStop = false;
            this.grpOldSubject.Text = "Old Subject";
            // 
            // cmbOldSubject
            // 
            this.cmbOldSubject.FormattingEnabled = true;
            this.cmbOldSubject.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "Physical",
            "History",
            "Bahasa",
            "English",
            "Geography"});
            this.cmbOldSubject.Location = new System.Drawing.Point(16, 29);
            this.cmbOldSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOldSubject.Name = "cmbOldSubject";
            this.cmbOldSubject.Size = new System.Drawing.Size(205, 28);
            this.cmbOldSubject.TabIndex = 8;
            this.cmbOldSubject.Text = "Old Subject";
            // 
            // grpNewSubject
            // 
            this.grpNewSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpNewSubject.Controls.Add(this.cmbNewSubject);
            this.grpNewSubject.Location = new System.Drawing.Point(515, 352);
            this.grpNewSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpNewSubject.Name = "grpNewSubject";
            this.grpNewSubject.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpNewSubject.Size = new System.Drawing.Size(229, 81);
            this.grpNewSubject.TabIndex = 5;
            this.grpNewSubject.TabStop = false;
            this.grpNewSubject.Text = "New Subject";
            // 
            // cmbNewSubject
            // 
            this.cmbNewSubject.FormattingEnabled = true;
            this.cmbNewSubject.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "Physical",
            "History",
            "Bahasa",
            "English",
            "Geography"});
            this.cmbNewSubject.Location = new System.Drawing.Point(17, 29);
            this.cmbNewSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNewSubject.Name = "cmbNewSubject";
            this.cmbNewSubject.Size = new System.Drawing.Size(205, 28);
            this.cmbNewSubject.TabIndex = 9;
            this.cmbNewSubject.Text = "New Subject";
            // 
            // grpReason
            // 
            this.grpReason.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpReason.Controls.Add(this.txtReason);
            this.grpReason.Location = new System.Drawing.Point(515, 173);
            this.grpReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpReason.Name = "grpReason";
            this.grpReason.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpReason.Size = new System.Drawing.Size(272, 171);
            this.grpReason.TabIndex = 3;
            this.grpReason.TabStop = false;
            this.grpReason.Text = "Reasons";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(17, 33);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PlaceholderText = "Type Somthing here......";
            this.txtReason.Size = new System.Drawing.Size(237, 119);
            this.txtReason.TabIndex = 0;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRequest.Location = new System.Drawing.Point(520, 475);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(123, 61);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // picChange
            // 
            this.picChange.Image = global::Tuition_Centre.Properties.Resources.change;
            this.picChange.Location = new System.Drawing.Point(370, 367);
            this.picChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picChange.Name = "picChange";
            this.picChange.Size = new System.Drawing.Size(114, 67);
            this.picChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChange.TabIndex = 7;
            this.picChange.TabStop = false;
            // 
            // pictureHome
            // 
            this.pictureHome.Image = global::Tuition_Centre.Properties.Resources.home;
            this.pictureHome.Location = new System.Drawing.Point(842, 16);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(58, 57);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 19;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // RequestSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureHome);
            this.Controls.Add(this.picChange);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.grpReason);
            this.Controls.Add(this.grpNewSubject);
            this.Controls.Add(this.grpOldSubject);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestSubject";
            this.Text = "RequestSubject";
            this.Load += new System.EventHandler(this.RequestSubject_Load);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpOldSubject.ResumeLayout(false);
            this.grpNewSubject.ResumeLayout(false);
            this.grpReason.ResumeLayout(false);
            this.grpReason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeading;
        private Label label2;
        private GroupBox grpCourse;
        private TextBox txtCourse;
        private GroupBox grpDate;
        private GroupBox grpOldSubject;
        private GroupBox grpNewSubject;
        private GroupBox grpReason;
        private TextBox txtReason;
        private Button btnRequest;
        private PictureBox picChange;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbOldSubject;
        private ComboBox cmbNewSubject;
        private PictureBox pictureHome;
    }
}