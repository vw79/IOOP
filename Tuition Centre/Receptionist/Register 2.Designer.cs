namespace Tuition_Centre.Receptionist
{
    partial class frmRegister2
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
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(459, 147);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(200, 23);
            this.txtCardNo.TabIndex = 0;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(459, 235);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(200, 23);
            this.txtCVV.TabIndex = 1;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(124, 147);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(200, 23);
            this.cmbPayment.TabIndex = 2;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(459, 129);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(79, 15);
            this.lblCardNo.TabIndex = 3;
            this.lblCardNo.Text = "Card Number";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(459, 217);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(29, 15);
            this.lblCVV.TabIndex = 4;
            this.lblCVV.Text = "CVV";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(522, 338);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // frmRegister2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtCardNo);
            this.Name = "frmRegister2";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCardNo;
        private TextBox txtCVV;
        private ComboBox cmbPayment;
        private Label lblCardNo;
        private Label lblCVV;
        private Button btnDone;
    }
}