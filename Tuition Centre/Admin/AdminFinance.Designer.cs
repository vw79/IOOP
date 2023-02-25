namespace Tuition_Centre.Admin
{
    partial class FrmAdminFinance
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
            lblCurrentMonth = new Label();
            dtpMonthYear = new DateTimePicker();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblCurrentMonth
            // 
            lblCurrentMonth.AutoSize = true;
            lblCurrentMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentMonth.Location = new Point(227, 9);
            lblCurrentMonth.Name = "lblCurrentMonth";
            lblCurrentMonth.Size = new Size(0, 21);
            lblCurrentMonth.TabIndex = 2;
            // 
            // dtpMonthYear
            // 
            dtpMonthYear.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMonthYear.CustomFormat = "MMMM yyyy";
            dtpMonthYear.Format = DateTimePickerFormat.Custom;
            dtpMonthYear.Location = new Point(12, 12);
            dtpMonthYear.Name = "dtpMonthYear";
            dtpMonthYear.Size = new Size(138, 23);
            dtpMonthYear.TabIndex = 3;
            dtpMonthYear.ValueChanged += dtbMonthYear_ValueChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 394);
            listBox1.TabIndex = 4;
            // 
            // FrmAdminFinance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(listBox1);
            Controls.Add(dtpMonthYear);
            Controls.Add(lblCurrentMonth);
            Name = "FrmAdminFinance";
            Text = "Income Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCurrentMonth;
        private DateTimePicker dtpMonthYear;
        private ListBox listBox1;
    }
}