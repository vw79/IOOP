namespace Tuition_Centre.Tutor
{
    partial class frmTutor_ClassAdd
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
            groupBox2 = new GroupBox();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            confirm = new Button();
            groupBox1 = new GroupBox();
            splitContainer2 = new SplitContainer();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txbCharges = new TextBox();
            label8 = new Label();
            txbEndTime = new TextBox();
            txbStartTime = new TextBox();
            cmbLocation = new ComboBox();
            dtpClassDate = new DateTimePicker();
            cmbSubNameAdd = new ComboBox();
            cmbSubIDAdd = new ComboBox();
            button7 = new Button();
            lblTutorID = new Label();
            lblTutorName = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(205, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(494, 71);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(328, 29);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(160, 31);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(5, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 31);
            button1.TabIndex = 2;
            button1.Text = "Class Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(166, 29);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(160, 31);
            button3.TabIndex = 4;
            button3.Text = "Update Information";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // confirm
            // 
            confirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirm.Location = new Point(533, 262);
            confirm.Margin = new Padding(3, 4, 3, 4);
            confirm.Name = "confirm";
            confirm.Size = new Size(121, 31);
            confirm.TabIndex = 2;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainer2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 92);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(473, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update or Delete Class";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 26);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label9);
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txbCharges);
            splitContainer2.Panel2.Controls.Add(label8);
            splitContainer2.Panel2.Controls.Add(txbEndTime);
            splitContainer2.Panel2.Controls.Add(txbStartTime);
            splitContainer2.Panel2.Controls.Add(cmbLocation);
            splitContainer2.Panel2.Controls.Add(dtpClassDate);
            splitContainer2.Panel2.Controls.Add(cmbSubNameAdd);
            splitContainer2.Panel2.Controls.Add(cmbSubIDAdd);
            splitContainer2.Size = new Size(467, 222);
            splitContainer2.SplitterDistance = 151;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 185);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 6;
            label9.Text = "Charges :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 148);
            label7.Name = "label7";
            label7.Size = new Size(52, 23);
            label7.TabIndex = 4;
            label7.Text = "Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 112);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 3;
            label6.Text = "Location :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 81);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 2;
            label5.Text = "Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 45);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 1;
            label4.Text = "Subject Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 0;
            label3.Text = "Subject ID :";
            // 
            // txbCharges
            // 
            txbCharges.Location = new Point(28, 185);
            txbCharges.Margin = new Padding(3, 4, 3, 4);
            txbCharges.Name = "txbCharges";
            txbCharges.PlaceholderText = "RM";
            txbCharges.Size = new Size(114, 29);
            txbCharges.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(148, 151);
            label8.Name = "label8";
            label8.Size = new Size(25, 23);
            label8.TabIndex = 5;
            label8.Text = "to";
            // 
            // txbEndTime
            // 
            txbEndTime.Location = new Point(179, 148);
            txbEndTime.Margin = new Padding(3, 4, 3, 4);
            txbEndTime.Name = "txbEndTime";
            txbEndTime.PlaceholderText = "00:00 AM/PM";
            txbEndTime.Size = new Size(114, 29);
            txbEndTime.TabIndex = 10;
            // 
            // txbStartTime
            // 
            txbStartTime.Location = new Point(28, 148);
            txbStartTime.Margin = new Padding(3, 4, 3, 4);
            txbStartTime.Name = "txbStartTime";
            txbStartTime.PlaceholderText = "00:00 AM/PM";
            txbStartTime.Size = new Size(114, 29);
            txbStartTime.TabIndex = 9;
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Items.AddRange(new object[] { "A-1-1", "A-1-2", "A-1-3", "A-2-1", "A-2-2", "A-2-3", "A-3-1", "A-3-2", "A-3-3", "B-1-1", "B-1-2", "B-1-3", "B-2-1", "B-2-2", "B-2-3", "B-3-1", "B-3-2", "B-3-3", "C-1-1", "C-1-2", "C-1-3", "C-2-1", "C-2-2", "C-2-3", "C-3-1", "C-3-2", "C-3-3" });
            cmbLocation.Location = new Point(28, 111);
            cmbLocation.Margin = new Padding(3, 4, 3, 4);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(186, 29);
            cmbLocation.TabIndex = 6;
            // 
            // dtpClassDate
            // 
            dtpClassDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpClassDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpClassDate.Format = DateTimePickerFormat.Short;
            dtpClassDate.Location = new Point(28, 79);
            dtpClassDate.Margin = new Padding(3, 4, 3, 4);
            dtpClassDate.Name = "dtpClassDate";
            dtpClassDate.Size = new Size(186, 27);
            dtpClassDate.TabIndex = 2;
            dtpClassDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbSubNameAdd
            // 
            cmbSubNameAdd.FormattingEnabled = true;
            cmbSubNameAdd.Items.AddRange(new object[] { "Mathematics", "Science", "History", "English" });
            cmbSubNameAdd.Location = new Point(28, 42);
            cmbSubNameAdd.Margin = new Padding(3, 4, 3, 4);
            cmbSubNameAdd.Name = "cmbSubNameAdd";
            cmbSubNameAdd.Size = new Size(186, 29);
            cmbSubNameAdd.TabIndex = 1;
            // 
            // cmbSubIDAdd
            // 
            cmbSubIDAdd.FormattingEnabled = true;
            cmbSubIDAdd.Items.AddRange(new object[] { "math001", "math002", "math003", "sci001", "sci002", "sci003", "his001", "his002", "his003", "eng001", "eng002", "eng003" });
            cmbSubIDAdd.Location = new Point(28, 8);
            cmbSubIDAdd.Margin = new Padding(3, 4, 3, 4);
            cmbSubIDAdd.Name = "cmbSubIDAdd";
            cmbSubIDAdd.Size = new Size(186, 29);
            cmbSubIDAdd.TabIndex = 0;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(533, 213);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(121, 31);
            button7.TabIndex = 3;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // lblTutorID
            // 
            lblTutorID.AutoSize = true;
            lblTutorID.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTutorID.Location = new Point(6, 44);
            lblTutorID.Name = "lblTutorID";
            lblTutorID.Size = new Size(69, 20);
            lblTutorID.TabIndex = 8;
            lblTutorID.Text = "Tutor ID: ";
            // 
            // lblTutorName
            // 
            lblTutorName.AutoSize = true;
            lblTutorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutorName.Location = new Point(6, 11);
            lblTutorName.Name = "lblTutorName";
            lblTutorName.Size = new Size(135, 33);
            lblTutorName.TabIndex = 7;
            lblTutorName.Text = "Tutor Name: ";
            lblTutorName.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTutorName);
            groupBox3.Controls.Add(lblTutorID);
            groupBox3.Location = new Point(6, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 83);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(533, 163);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmTutor_ClassAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 361);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(confirm);
            Controls.Add(groupBox2);
            Controls.Add(button7);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTutor_ClassAdd";
            Text = "Update or Delete Class";
            Load += frmTutor_ClassAdd_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label lblTutorID;
        private Label lblTutorName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer splitContainer2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpClassDate;
        private ComboBox cmbSubNameAdd;
        private ComboBox cmbSubIDAdd;
        private Button button7;
        private Button confirm;
        private GroupBox groupBox2;
        private Button button1;
        private Button button4;
        private Button button3;
        private ComboBox cmbLocation;
        private Label label8;
        private Label label9;
        private TextBox txbStartTime;
        private TextBox txbCharges;
        private TextBox txbEndTime;
        private GroupBox groupBox3;
        private Button button2;
    }
}