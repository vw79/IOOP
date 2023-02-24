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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCharges = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEndTime = new System.Windows.Forms.TextBox();
            this.txbStartTime = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSubNameAdd = new System.Windows.Forms.ComboBox();
            this.cmbSubIDAdd = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.lblTutorID = new System.Windows.Forms.Label();
            this.lblTutorName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 91);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.confirm);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(696, 307);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(165, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Class Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1, 145);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(2, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Enrolled Students";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(281, 264);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(117, 31);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(473, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update or Delete Class";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 26);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txbCharges);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.txbEndTime);
            this.splitContainer2.Panel2.Controls.Add(this.txbStartTime);
            this.splitContainer2.Panel2.Controls.Add(this.cmbLocation);
            this.splitContainer2.Panel2.Controls.Add(this.dtpClassDate);
            this.splitContainer2.Panel2.Controls.Add(this.cmbSubNameAdd);
            this.splitContainer2.Panel2.Controls.Add(this.cmbSubIDAdd);
            this.splitContainer2.Size = new System.Drawing.Size(467, 222);
            this.splitContainer2.SplitterDistance = 151;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Charges :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Time:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Location :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject ID :";
            // 
            // txbCharges
            // 
            this.txbCharges.Location = new System.Drawing.Point(28, 185);
            this.txbCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCharges.Name = "txbCharges";
            this.txbCharges.PlaceholderText = "RM";
            this.txbCharges.Size = new System.Drawing.Size(114, 29);
            this.txbCharges.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "to";
            // 
            // txbEndTime
            // 
            this.txbEndTime.Location = new System.Drawing.Point(179, 148);
            this.txbEndTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEndTime.Name = "txbEndTime";
            this.txbEndTime.PlaceholderText = "00:00 AM/PM";
            this.txbEndTime.Size = new System.Drawing.Size(114, 29);
            this.txbEndTime.TabIndex = 10;
            // 
            // txbStartTime
            // 
            this.txbStartTime.Location = new System.Drawing.Point(28, 148);
            this.txbStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbStartTime.Name = "txbStartTime";
            this.txbStartTime.PlaceholderText = "00:00 AM/PM";
            this.txbStartTime.Size = new System.Drawing.Size(114, 29);
            this.txbStartTime.TabIndex = 9;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "A-1-1",
            "A-1-2",
            "A-1-3",
            "A-2-1",
            "A-2-2",
            "A-2-3",
            "A-3-1",
            "A-3-2",
            "A-3-3",
            "B-1-1",
            "B-1-2",
            "B-1-3",
            "B-2-1",
            "B-2-2",
            "B-2-3",
            "B-3-1",
            "B-3-2",
            "B-3-3",
            "C-1-1",
            "C-1-2",
            "C-1-3",
            "C-2-1",
            "C-2-2",
            "C-2-3",
            "C-3-1",
            "C-3-2",
            "C-3-3"});
            this.cmbLocation.Location = new System.Drawing.Point(28, 111);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(186, 29);
            this.cmbLocation.TabIndex = 6;
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpClassDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClassDate.Location = new System.Drawing.Point(28, 79);
            this.dtpClassDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(186, 27);
            this.dtpClassDate.TabIndex = 2;
            this.dtpClassDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbSubNameAdd
            // 
            this.cmbSubNameAdd.FormattingEnabled = true;
            this.cmbSubNameAdd.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "History",
            "English"});
            this.cmbSubNameAdd.Location = new System.Drawing.Point(28, 42);
            this.cmbSubNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubNameAdd.Name = "cmbSubNameAdd";
            this.cmbSubNameAdd.Size = new System.Drawing.Size(186, 29);
            this.cmbSubNameAdd.TabIndex = 1;
            // 
            // cmbSubIDAdd
            // 
            this.cmbSubIDAdd.FormattingEnabled = true;
            this.cmbSubIDAdd.Items.AddRange(new object[] {
            "math001",
            "math002",
            "math003",
            "sci001",
            "sci002",
            "sci003",
            "his001",
            "his002",
            "his003",
            "eng001",
            "eng002",
            "eng003"});
            this.cmbSubIDAdd.Location = new System.Drawing.Point(28, 8);
            this.cmbSubIDAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubIDAdd.Name = "cmbSubIDAdd";
            this.cmbSubIDAdd.Size = new System.Drawing.Size(186, 29);
            this.cmbSubIDAdd.TabIndex = 0;
            this.cmbSubIDAdd.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(105, 264);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 31);
            this.button7.TabIndex = 3;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblTutorID
            // 
            this.lblTutorID.AutoSize = true;
            this.lblTutorID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTutorID.Location = new System.Drawing.Point(6, 44);
            this.lblTutorID.Name = "lblTutorID";
            this.lblTutorID.Size = new System.Drawing.Size(69, 20);
            this.lblTutorID.TabIndex = 8;
            this.lblTutorID.Text = "Tutor ID: ";
            // 
            // lblTutorName
            // 
            this.lblTutorName.AutoSize = true;
            this.lblTutorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutorName.Location = new System.Drawing.Point(6, 11);
            this.lblTutorName.Name = "lblTutorName";
            this.lblTutorName.Size = new System.Drawing.Size(135, 33);
            this.lblTutorName.TabIndex = 7;
            this.lblTutorName.Text = "Tutor Name: ";
            this.lblTutorName.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTutorName);
            this.groupBox3.Controls.Add(this.lblTutorID);
            this.groupBox3.Location = new System.Drawing.Point(6, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 83);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // frmTutor_ClassAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTutor_ClassAdd";
            this.Text = "Update or Delete Class";
            this.Load += new System.EventHandler(this.frmTutor_ClassAdd_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
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
        private Button button2;
        private Button button3;
        private ComboBox cmbLocation;
        private Label label8;
        private Label label9;
        private TextBox txbStartTime;
        private TextBox txbCharges;
        private TextBox txbEndTime;
        private GroupBox groupBox3;
    }
}