namespace Tuition_Centre.Receptionist
{
    partial class frmUpdateStu
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
            panel1 = new Panel();
            btnDeleteStu = new Button();
            btnUpPay = new Button();
            btnUpSub = new Button();
            lblStuName = new Label();
            lblStuID = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvChangeSubject = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChangeSubject).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDeleteStu);
            panel1.Controls.Add(btnUpPay);
            panel1.Controls.Add(btnUpSub);
            panel1.Location = new Point(12, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 315);
            panel1.TabIndex = 0;
            // 
            // btnDeleteStu
            // 
            btnDeleteStu.Location = new Point(18, 158);
            btnDeleteStu.Name = "btnDeleteStu";
            btnDeleteStu.Size = new Size(120, 23);
            btnDeleteStu.TabIndex = 2;
            btnDeleteStu.Text = "Delete Student";
            btnDeleteStu.UseVisualStyleBackColor = true;
            //btnDeleteStu.Click += btnDeleteStu_Click;
            // 
            // btnUpPay
            // 
            btnUpPay.Location = new Point(18, 95);
            btnUpPay.Name = "btnUpPay";
            btnUpPay.Size = new Size(120, 23);
            btnUpPay.TabIndex = 1;
            btnUpPay.Text = "Update Payment";
            btnUpPay.UseVisualStyleBackColor = true;
//            btnUpPay.Click += btnUpPay_Click;
            // 
            // btnUpSub
            // 
            btnUpSub.Location = new Point(18, 31);
            btnUpSub.Name = "btnUpSub";
            btnUpSub.Size = new Size(120, 23);
            btnUpSub.TabIndex = 0;
            btnUpSub.Text = "Update Subject";
            btnUpSub.UseVisualStyleBackColor = true;
   //         btnUpSub.Click += btnUpSub_Click;
            // 
            // lblStuName
            // 
            lblStuName.AutoSize = true;
            lblStuName.Location = new Point(18, 22);
            lblStuName.Name = "lblStuName";
            lblStuName.Size = new Size(45, 15);
            lblStuName.TabIndex = 1;
            lblStuName.Text = "Name: ";
            // 
            // lblStuID
            // 
            lblStuID.AutoSize = true;
            lblStuID.Location = new Point(18, 55);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(68, 15);
            lblStuID.TabIndex = 2;
            lblStuID.Text = "Student ID: ";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblStuID);
            panel2.Controls.Add(lblStuName);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 105);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dgvChangeSubject);
            panel3.Location = new Point(197, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 315);
            panel3.TabIndex = 4;
            // 
            // dgvChangeSubject
            // 
            dgvChangeSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChangeSubject.Location = new Point(3, 3);
            dgvChangeSubject.Name = "dgvChangeSubject";
            dgvChangeSubject.RowTemplate.Height = 25;
            dgvChangeSubject.Size = new Size(581, 305);
            dgvChangeSubject.TabIndex = 0;
            // 
            // frmUpdateStu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUpdateStu";
            Text = "Update Student Info";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChangeSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeleteStu;
        private Button btnUpPay;
        private Button btnUpSub;
        private Label lblStuName;
        private Label lblStuID;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvChangeSubject;
    }
}