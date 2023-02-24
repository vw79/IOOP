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
            listBox1 = new ListBox();
            lblTittle = new Label();
            lblCurrentMonth = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 379);
            listBox1.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTittle.Location = new Point(12, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(154, 21);
            lblTittle.TabIndex = 1;
            lblTittle.Text = "This Month's Income";
            // 
            // lblCurrentMonth
            // 
            lblCurrentMonth.AutoSize = true;
            lblCurrentMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentMonth.Location = new Point(227, 9);
            lblCurrentMonth.Name = "lblCurrentMonth";
            lblCurrentMonth.Size = new Size(99, 21);
            lblCurrentMonth.TabIndex = 2;
            lblCurrentMonth.Text = "Current Date";
            // 
            // FrmAdminFinance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(lblCurrentMonth);
            Controls.Add(lblTittle);
            Controls.Add(listBox1);
            Name = "FrmAdminFinance";
            Text = "Income Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblTittle;
        private Label lblCurrentMonth;
    }
}