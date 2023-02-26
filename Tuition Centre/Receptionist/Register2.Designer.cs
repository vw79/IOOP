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
            lblSubject3 = new Label();
            lblSubject2 = new Label();
            cmbSubject3 = new ComboBox();
            cmbSubject2 = new ComboBox();
            cmbSubject1 = new ComboBox();
            lblSubject1 = new Label();
            grpPayMethod = new GroupBox();
            cmbPayment = new ComboBox();
            lblPayMethod = new Label();
            grpEnrollDate = new GroupBox();
            dtpEnrollDate = new DateTimePicker();
            lblEnrollDate = new Label();
            grpLevel = new GroupBox();
            lblLevel = new Label();
            cmbLevel = new ComboBox();
            grpCardInfo = new GroupBox();
            lblCVV = new Label();
            lblCardNum = new Label();
            txtCVV = new TextBox();
            txtCardNum = new TextBox();
            btnRegister = new Button();
            grpSubject.SuspendLayout();
            grpPayMethod.SuspendLayout();
            grpEnrollDate.SuspendLayout();
            grpLevel.SuspendLayout();
            grpCardInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grpSubject
            // 
            grpSubject.Controls.Add(lblSubject3);
            grpSubject.Controls.Add(lblSubject2);
            grpSubject.Controls.Add(cmbSubject3);
            grpSubject.Controls.Add(cmbSubject2);
            grpSubject.Controls.Add(cmbSubject1);
            grpSubject.Controls.Add(lblSubject1);
            grpSubject.FlatStyle = FlatStyle.Flat;
            grpSubject.Location = new Point(34, 113);
            grpSubject.Name = "grpSubject";
            grpSubject.Size = new Size(221, 231);
            grpSubject.TabIndex = 0;
            grpSubject.TabStop = false;
            // 
            // lblSubject3
            // 
            lblSubject3.AutoSize = true;
            lblSubject3.Location = new Point(6, 162);
            lblSubject3.Name = "lblSubject3";
            lblSubject3.Size = new Size(55, 15);
            lblSubject3.TabIndex = 12;
            lblSubject3.Text = "Subject 3";
            // 
            // lblSubject2
            // 
            lblSubject2.AutoSize = true;
            lblSubject2.Location = new Point(6, 90);
            lblSubject2.Name = "lblSubject2";
            lblSubject2.Size = new Size(55, 15);
            lblSubject2.TabIndex = 11;
            lblSubject2.Text = "Subject 2";
            // 
            // cmbSubject3
            // 
            cmbSubject3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject3.FormattingEnabled = true;
            cmbSubject3.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubject3.Location = new Point(6, 180);
            cmbSubject3.Name = "cmbSubject3";
            cmbSubject3.Size = new Size(200, 23);
            cmbSubject3.TabIndex = 10;
            // 
            // cmbSubject2
            // 
            cmbSubject2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject2.FormattingEnabled = true;
            cmbSubject2.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubject2.Location = new Point(6, 108);
            cmbSubject2.Name = "cmbSubject2";
            cmbSubject2.Size = new Size(200, 23);
            cmbSubject2.TabIndex = 9;
            // 
            // cmbSubject1
            // 
            cmbSubject1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject1.FormattingEnabled = true;
            cmbSubject1.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubject1.Location = new Point(6, 37);
            cmbSubject1.Name = "cmbSubject1";
            cmbSubject1.Size = new Size(200, 23);
            cmbSubject1.TabIndex = 8;
            // 
            // lblSubject1
            // 
            lblSubject1.AutoSize = true;
            lblSubject1.Location = new Point(6, 19);
            lblSubject1.Name = "lblSubject1";
            lblSubject1.Size = new Size(55, 15);
            lblSubject1.TabIndex = 7;
            lblSubject1.Text = "Subject 1";
            // 
            // grpPayMethod
            // 
            grpPayMethod.Controls.Add(cmbPayment);
            grpPayMethod.Controls.Add(lblPayMethod);
            grpPayMethod.Location = new Point(545, 113);
            grpPayMethod.Name = "grpPayMethod";
            grpPayMethod.Size = new Size(221, 74);
            grpPayMethod.TabIndex = 2;
            grpPayMethod.TabStop = false;
            // 
            // cmbPayment
            // 
            cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Items.AddRange(new object[] { "Cash", "Credit Card", "Online Payment" });
            cmbPayment.Location = new Point(6, 34);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(200, 23);
            cmbPayment.TabIndex = 6;
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
            cmbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Level 1", "Level 2", "Level 3" });
            cmbLevel.Location = new Point(6, 34);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(200, 23);
            cmbLevel.TabIndex = 8;
            // 
            // grpCardInfo
            // 
            grpCardInfo.Controls.Add(lblCVV);
            grpCardInfo.Controls.Add(lblCardNum);
            grpCardInfo.Controls.Add(txtCVV);
            grpCardInfo.Controls.Add(txtCardNum);
            grpCardInfo.Location = new Point(545, 209);
            grpCardInfo.Name = "grpCardInfo";
            grpCardInfo.Size = new Size(221, 124);
            grpCardInfo.TabIndex = 6;
            grpCardInfo.TabStop = false;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Location = new Point(6, 66);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(29, 15);
            lblCVV.TabIndex = 3;
            lblCVV.Text = "CVV";
            // 
            // lblCardNum
            // 
            lblCardNum.AutoSize = true;
            lblCardNum.Location = new Point(6, 18);
            lblCardNum.Name = "lblCardNum";
            lblCardNum.Size = new Size(79, 15);
            lblCardNum.TabIndex = 2;
            lblCardNum.Text = "Card Number";
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(6, 84);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(200, 23);
            txtCVV.TabIndex = 1;
            // 
            // txtCardNum
            // 
            txtCardNum.Location = new Point(6, 35);
            txtCardNum.Name = "txtCardNum";
            txtCardNum.Size = new Size(200, 23);
            txtCardNum.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(606, 362);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(97, 40);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegister2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(grpCardInfo);
            Controls.Add(grpLevel);
            Controls.Add(grpEnrollDate);
            Controls.Add(grpPayMethod);
            Controls.Add(grpSubject);
            Name = "frmRegister2";
            Text = "Register";
            grpSubject.ResumeLayout(false);
            grpSubject.PerformLayout();
            grpPayMethod.ResumeLayout(false);
            grpPayMethod.PerformLayout();
            grpEnrollDate.ResumeLayout(false);
            grpEnrollDate.PerformLayout();
            grpLevel.ResumeLayout(false);
            grpLevel.PerformLayout();
            grpCardInfo.ResumeLayout(false);
            grpCardInfo.PerformLayout();
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
        private ComboBox cmbPayment;
        private Label lblSubject3;
        private Label lblSubject2;
        private ComboBox cmbSubject3;
        private ComboBox cmbSubject2;
        private ComboBox cmbSubject1;
        private GroupBox grpCardInfo;
        private Label lblCVV;
        private Label lblCardNum;
        private TextBox txtCVV;
        private TextBox txtCardNum;
        private Button btnRegister;
    }
}