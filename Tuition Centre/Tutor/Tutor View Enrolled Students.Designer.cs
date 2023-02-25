namespace Tuition_Centre.Tutor
{
    partial class frmTutor_ViewStudents
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
            groupBox1 = new GroupBox();
            dgv1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            txtClassCode = new TextBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 87);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(259, 460);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "View Enrolled Students";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(6, 29);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(247, 424);
            dgv1.TabIndex = 0;
            dgv1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 22);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 11;
            label3.Text = "Insert Class Code";
            // 
            // txtClassCode
            // 
            txtClassCode.Location = new Point(140, 18);
            txtClassCode.Name = "txtClassCode";
            txtClassCode.Size = new Size(125, 27);
            txtClassCode.TabIndex = 12;
            txtClassCode.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(165, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmTutor_ViewStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 551);
            Controls.Add(btnSearch);
            Controls.Add(txtClassCode);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTutor_ViewStudents";
            Text = "Enrolled Students";
            Load += View_Enrolled_Students_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private GroupBox groupBox3;
        private DataGridView dgv1;
        private Label label3;
        private TextBox txtClassCode;
        private Button btnSearch;
    }
}