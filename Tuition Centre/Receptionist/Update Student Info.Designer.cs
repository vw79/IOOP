namespace Tuition_Centre.Receptionist
{
    partial class frmUpdateStu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteStu = new System.Windows.Forms.Button();
            this.btnUpPay = new System.Windows.Forms.Button();
            this.btnUpSub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteStu);
            this.panel1.Controls.Add(this.btnUpPay);
            this.panel1.Controls.Add(this.btnUpSub);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 315);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteStu
            // 
            this.btnDeleteStu.Location = new System.Drawing.Point(18, 158);
            this.btnDeleteStu.Name = "btnDeleteStu";
            this.btnDeleteStu.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteStu.TabIndex = 2;
            this.btnDeleteStu.Text = "Delete Student";
            this.btnDeleteStu.UseVisualStyleBackColor = true;
            this.btnDeleteStu.Click += new System.EventHandler(this.btnDeleteStu_Click);
            // 
            // btnUpPay
            // 
            this.btnUpPay.Location = new System.Drawing.Point(18, 95);
            this.btnUpPay.Name = "btnUpPay";
            this.btnUpPay.Size = new System.Drawing.Size(120, 23);
            this.btnUpPay.TabIndex = 1;
            this.btnUpPay.Text = "Update Payment";
            this.btnUpPay.UseVisualStyleBackColor = true;
            this.btnUpPay.Click += new System.EventHandler(this.btnUpPay_Click);
            // 
            // btnUpSub
            // 
            this.btnUpSub.Location = new System.Drawing.Point(18, 31);
            this.btnUpSub.Name = "btnUpSub";
            this.btnUpSub.Size = new System.Drawing.Size(120, 23);
            this.btnUpSub.TabIndex = 0;
            this.btnUpSub.Text = "Update Subject";
            this.btnUpSub.UseVisualStyleBackColor = true;
            this.btnUpSub.Click += new System.EventHandler(this.btnUpSub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 105);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(197, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 315);
            this.panel3.TabIndex = 4;
            // 
            // frmUpdateStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateStu";
            this.Text = "Update Student Info";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnDeleteStu;
        private Button btnUpPay;
        private Button btnUpSub;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
    }
}