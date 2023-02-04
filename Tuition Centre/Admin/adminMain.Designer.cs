namespace Tuition_Centre.Admin
{
    partial class FrmMainAdmin
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
            this.btnTutorList = new System.Windows.Forms.Button();
            this.btnRecepList = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTutorList
            // 
            this.btnTutorList.Location = new System.Drawing.Point(338, 195);
            this.btnTutorList.Name = "btnTutorList";
            this.btnTutorList.Size = new System.Drawing.Size(131, 42);
            this.btnTutorList.TabIndex = 0;
            this.btnTutorList.Text = "Tutor List";
            this.btnTutorList.UseVisualStyleBackColor = true;
            // 
            // btnRecepList
            // 
            this.btnRecepList.Location = new System.Drawing.Point(338, 243);
            this.btnRecepList.Name = "btnRecepList";
            this.btnRecepList.Size = new System.Drawing.Size(131, 42);
            this.btnRecepList.TabIndex = 1;
            this.btnRecepList.Text = "Receptionist List";
            this.btnRecepList.UseVisualStyleBackColor = true;
            // 
            // btnFinance
            // 
            this.btnFinance.Location = new System.Drawing.Point(338, 291);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(131, 42);
            this.btnFinance.TabIndex = 2;
            this.btnFinance.Text = "Income Report";
            this.btnFinance.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome back, administrator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.btnRecepList);
            this.Controls.Add(this.btnTutorList);
            this.Name = "FrmMainAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmMainAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTutorList;
        private Button btnRecepList;
        private Button btnFinance;
        private Label label1;
        private Button button1;
    }
}