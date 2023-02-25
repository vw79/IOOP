namespace Tuition_Centre.Tutor
{
    partial class frmTutor_UpdateProfile
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
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            txbUpdateAddress = new TextBox();
            cmbUpdateSub = new ComboBox();
            lblUpdateDOB = new Label();
            lblUpdateID = new Label();
            lblUpdateName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txbUpdatePh = new TextBox();
            lblTutorID = new Label();
            lblTutorName = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 31);
            button1.TabIndex = 2;
            button1.Text = "Class Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1, 145);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(160, 31);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(2, 68);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(158, 31);
            button2.TabIndex = 3;
            button2.Text = "View Enrolled Students";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1, 107);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(160, 31);
            button3.TabIndex = 4;
            button3.Text = "Update Information";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(314, 305);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 0;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(162, 305);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 0;
            button5.Text = "Confirm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbUpdateAddress);
            groupBox1.Controls.Add(cmbUpdateSub);
            groupBox1.Controls.Add(lblUpdateDOB);
            groupBox1.Controls.Add(lblUpdateID);
            groupBox1.Controls.Add(lblUpdateName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbUpdatePh);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(535, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Profile";
            // 
            // txbUpdateAddress
            // 
            txbUpdateAddress.Location = new Point(159, 231);
            txbUpdateAddress.Name = "txbUpdateAddress";
            txbUpdateAddress.Size = new Size(331, 29);
            txbUpdateAddress.TabIndex = 13;
            // 
            // cmbUpdateSub
            // 
            cmbUpdateSub.FormattingEnabled = true;
            cmbUpdateSub.Items.AddRange(new object[] { "Mathematics", "Science", "History", "English" });
            cmbUpdateSub.Location = new Point(159, 184);
            cmbUpdateSub.Name = "cmbUpdateSub";
            cmbUpdateSub.Size = new Size(151, 29);
            cmbUpdateSub.TabIndex = 12;
            // 
            // lblUpdateDOB
            // 
            lblUpdateDOB.AutoSize = true;
            lblUpdateDOB.Location = new Point(159, 111);
            lblUpdateDOB.Name = "lblUpdateDOB";
            lblUpdateDOB.Size = new Size(134, 23);
            lblUpdateDOB.TabIndex = 11;
            lblUpdateDOB.Text = "01 January 1980";
            // 
            // lblUpdateID
            // 
            lblUpdateID.AutoSize = true;
            lblUpdateID.Location = new Point(159, 77);
            lblUpdateID.Name = "lblUpdateID";
            lblUpdateID.Size = new Size(89, 23);
            lblUpdateID.TabIndex = 10;
            lblUpdateID.Text = "TP1234567";
            lblUpdateID.Click += label10_Click;
            // 
            // lblUpdateName
            // 
            lblUpdateName.AutoSize = true;
            lblUpdateName.Location = new Point(159, 44);
            lblUpdateName.Name = "lblUpdateName";
            lblUpdateName.Size = new Size(102, 23);
            lblUpdateName.TabIndex = 9;
            lblUpdateName.Text = "Tutor Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 231);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 8;
            label8.Text = "Address         :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 187);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 7;
            label7.Text = "Subjects        :";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 149);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 6;
            label6.Text = "Phone           :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 113);
            label5.Name = "label5";
            label5.Size = new Size(123, 23);
            label5.TabIndex = 5;
            label5.Text = "Date of Birth : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 77);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 4;
            label4.Text = "ID                 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 44);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 3;
            label3.Text = "Name            :";
            // 
            // txbUpdatePh
            // 
            txbUpdatePh.Location = new Point(159, 141);
            txbUpdatePh.Margin = new Padding(3, 4, 3, 4);
            txbUpdatePh.Name = "txbUpdatePh";
            txbUpdatePh.Size = new Size(238, 29);
            txbUpdatePh.TabIndex = 0;
            // 
            // lblTutorID
            // 
            lblTutorID.AutoSize = true;
            lblTutorID.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTutorID.Location = new Point(6, 45);
            lblTutorID.Name = "lblTutorID";
            lblTutorID.Size = new Size(69, 20);
            lblTutorID.TabIndex = 8;
            lblTutorID.Text = "Tutor ID: ";
            // 
            // lblTutorName
            // 
            lblTutorName.AutoSize = true;
            lblTutorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutorName.Location = new Point(6, 12);
            lblTutorName.Name = "lblTutorName";
            lblTutorName.Size = new Size(135, 33);
            lblTutorName.TabIndex = 7;
            lblTutorName.Text = "Tutor Name: ";
            lblTutorName.UseCompatibleTextRendering = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(10, 90);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(724, 354);
            splitContainer1.SplitterDistance = 175;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(165, 189);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTutorName);
            groupBox3.Controls.Add(lblTutorID);
            groupBox3.Location = new Point(10, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(724, 83);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // frmTutor_UpdateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 456);
            Controls.Add(groupBox3);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTutor_UpdateProfile";
            Text = "Tutor Update Profile";
            Load += frmTutor_UpdateProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTutorID;
        private Label lblTutorName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private GroupBox groupBox1;
        private Label lblUpdateDOB;
        private Label lblUpdateID;
        private Label lblUpdateName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txbUpdatePh;
        private ComboBox cmbUpdateSub;
        private TextBox txbUpdateAddress;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}