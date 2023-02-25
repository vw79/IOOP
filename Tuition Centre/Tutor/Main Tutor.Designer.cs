namespace Tuition_Centre.Tutor
{
    partial class frmMainTutor
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
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            dgv1 = new DataGridView();
            btnDel = new Button();
            button5 = new Button();
            lblTutorName = new Label();
            lblTutorID = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(243, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(674, 72);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            groupBox2.Enter += groupBox2_Enter_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(7, 28);
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
            button4.Location = new Point(504, 29);
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
            button2.Location = new Point(174, 28);
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
            button3.Location = new Point(338, 29);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(160, 31);
            button3.TabIndex = 4;
            button3.Text = "Update Information";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv1);
            groupBox1.Controls.Add(btnDel);
            groupBox1.Controls.Add(button5);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 93);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(906, 423);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Class Information";
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(7, 79);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(889, 332);
            dgv1.TabIndex = 2;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(161, 32);
            btnDel.Margin = new Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(151, 40);
            btnDel.TabIndex = 1;
            btnDel.Text = "Delete Class";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += button6_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(7, 32);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(147, 40);
            button5.TabIndex = 0;
            button5.Text = "Add New Class";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lblTutorName
            // 
            lblTutorName.AutoSize = true;
            lblTutorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutorName.Location = new Point(7, 15);
            lblTutorName.Name = "lblTutorName";
            lblTutorName.Size = new Size(124, 33);
            lblTutorName.TabIndex = 2;
            lblTutorName.Text = "Tutor Name";
            lblTutorName.UseCompatibleTextRendering = true;
            lblTutorName.Click += label1_Click;
            // 
            // lblTutorID
            // 
            lblTutorID.AutoSize = true;
            lblTutorID.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTutorID.Location = new Point(7, 51);
            lblTutorID.Name = "lblTutorID";
            lblTutorID.Size = new Size(62, 20);
            lblTutorID.TabIndex = 3;
            lblTutorID.Text = "Tutor ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTutorName);
            groupBox3.Controls.Add(lblTutorID);
            groupBox3.Location = new Point(11, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(225, 83);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // frmMainTutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 614);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainTutor";
            Text = "Tutor Main Page";
            Load += frmMainTutor_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label lblTutorName;
        private Label lblTutorID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDel;
        private Button button5;
        private GroupBox groupBox3;
        private DataGridView dgv1;
    }
}