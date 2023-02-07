namespace Tuition_Centre.Receptionist
{
    partial class frmPayment2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStuID);
            this.panel2.Controls.Add(this.lblStuName);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 105);
            this.panel2.TabIndex = 4;
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(18, 55);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(68, 15);
            this.lblStuID.TabIndex = 2;
            this.lblStuID.Text = "Student ID: ";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(18, 22);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(45, 15);
            this.lblStuName.TabIndex = 1;
            this.lblStuName.Text = "Name: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReceipt);
            this.panel3.Controls.Add(this.cmbPay);
            this.panel3.Controls.Add(this.lblAmount);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Location = new System.Drawing.Point(12, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 315);
            this.panel3.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(124, 68);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(124, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "Enter Amount";
            this.txtAmount.Size = new System.Drawing.Size(200, 23);
            this.txtAmount.TabIndex = 0;
            // 
            // cmbPay
            // 
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(124, 163);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(200, 23);
            this.cmbPay.TabIndex = 2;
            this.cmbPay.Text = "Payment Method";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(513, 228);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(150, 23);
            this.btnReceipt.TabIndex = 3;
            this.btnReceipt.Text = "Generate Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            // 
            // frmPayment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmPayment2";
            this.Text = "Payment";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label lblStuID;
        private Label lblStuName;
        private Panel panel3;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnReceipt;
        private ComboBox cmbPay;
    }
}