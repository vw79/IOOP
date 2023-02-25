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
            dtpMonthYear = new DateTimePicker();
            lstbReport = new ListBox();
            SuspendLayout();
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
            // lstbReport
            // 
            lstbReport.FormattingEnabled = true;
            lstbReport.ItemHeight = 15;
            lstbReport.Location = new Point(12, 41);
            lstbReport.Name = "lstbReport";
            lstbReport.Size = new Size(776, 394);
            lstbReport.TabIndex = 4;
            // 
            // FrmAdminFinance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(lstbReport);
            Controls.Add(dtpMonthYear);
            Name = "FrmAdminFinance";
            Text = "Income Report";
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpMonthYear;
        private ListBox lstbReport;
    }
}