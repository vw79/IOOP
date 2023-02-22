namespace Tuition_Centre.Receptionist
{
    partial class frmRegister2
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
            grpSubject = new GroupBox();
            lblSubject1 = new Label();
            grpPayMethod = new GroupBox();
            cmbPayMethod = new ComboBox();
            lblPayMethod = new Label();
            grpEnrollDate = new GroupBox();
            dtpEnrollDate = new DateTimePicker();
            lblEnrollDate = new Label();
            grpLevel = new GroupBox();
            lblLevel = new Label();
            cmbLevel = new ComboBox();
            grpSubject.SuspendLayout();
            grpPayMethod.SuspendLayout();
            grpEnrollDate.SuspendLayout();
            grpLevel.SuspendLayout();
            SuspendLayout();
            // 
            // grpSubject
            // 
            grpSubject.Controls.Add(lblSubject1);
            grpSubject.FlatStyle = FlatStyle.Flat;
            grpSubject.Location = new Point(34, 113);
            grpSubject.Name = "grpSubject";
            grpSubject.Size = new Size(221, 231);
            grpSubject.TabIndex = 0;
            grpSubject.TabStop = false;
            // 
            // lblSubject1
            // 
            lblSubject1.AutoSize = true;
            lblSubject1.Location = new Point(6, 16);
            lblSubject1.Name = "lblSubject1";
            lblSubject1.Size = new Size(55, 15);
            lblSubject1.TabIndex = 7;
            lblSubject1.Text = "Subject 1";
            // 
            // grpPayMethod
            // 
            grpPayMethod.Controls.Add(cmbPayMethod);
            grpPayMethod.Controls.Add(lblPayMethod);
            grpPayMethod.Location = new Point(545, 113);
            grpPayMethod.Name = "grpPayMethod";
            grpPayMethod.Size = new Size(221, 74);
            grpPayMethod.TabIndex = 2;
            grpPayMethod.TabStop = false;
            // 
            // cmbPayMethod
            // 
            cmbPayMethod.FormattingEnabled = true;
            cmbPayMethod.Location = new Point(6, 34);
            cmbPayMethod.Name = "cmbPayMethod";
            cmbPayMethod.Size = new Size(200, 23);
            cmbPayMethod.TabIndex = 6;
            // 
            // lblPayMethod
            // 
            lblPayMethod.AutoSize = true;
            lblPayMethod.Location = new Point(6, 16);
            lblPayMethod.Name = "lblPayMethod";
            lblPayMethod.Size = new Size(99, 15);
            lblPayMethod.TabIndex = 6;
            lblPayMethod.Text = "Payment Method";
            // 
            // grpEnrollDate
            // 
            grpEnrollDate.Controls.Add(dtpEnrollDate);
            grpEnrollDate.Controls.Add(lblEnrollDate);
            grpEnrollDate.Location = new Point(290, 113);
            grpEnrollDate.Name = "grpEnrollDate";
            grpEnrollDate.Size = new Size(221, 74);
            grpEnrollDate.TabIndex = 4;
            grpEnrollDate.TabStop = false;
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.Format = DateTimePickerFormat.Custom;
            dtpEnrollDate.Location = new Point(6, 34);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(200, 23);
            dtpEnrollDate.TabIndex = 8;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Location = new Point(6, 16);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(92, 15);
            lblEnrollDate.TabIndex = 0;
            lblEnrollDate.Text = "Enrollment Date";
            // 
            // grpLevel
            // 
            grpLevel.Controls.Add(lblLevel);
            grpLevel.Controls.Add(cmbLevel);
            grpLevel.Location = new Point(290, 193);
            grpLevel.Name = "grpLevel";
            grpLevel.Size = new Size(221, 74);
            grpLevel.TabIndex = 5;
            grpLevel.TabStop = false;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(6, 16);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(34, 15);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "Level";
            // 
            // cmbLevel
            // 
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(6, 34);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(200, 23);
            cmbLevel.TabIndex = 8;
            // 
            // frmRegister2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpLevel);
            Controls.Add(grpEnrollDate);
            Controls.Add(grpPayMethod);
            Controls.Add(grpSubject);
            Name = "frmRegister2";
            Text = "Register2";
            grpSubject.ResumeLayout(false);
            grpSubject.PerformLayout();
            grpPayMethod.ResumeLayout(false);
            grpPayMethod.PerformLayout();
            grpEnrollDate.ResumeLayout(false);
            grpEnrollDate.PerformLayout();
            grpLevel.ResumeLayout(false);
            grpLevel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSubject;
        private GroupBox groupBox2;
        private GroupBox grpPayMethod;
        private GroupBox groupBox4;
        private GroupBox grpEnrollDate;
        private GroupBox grpLevel;
        private Label lblPayMethod;
        private ComboBox cmbLevel;
        private Label lblLevel;
        private DateTimePicker dtpEnrollDate;
        private Label lblEnrollDate;
        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label lblSubject1;
        private ComboBox cmbPayMethod;
    }
}