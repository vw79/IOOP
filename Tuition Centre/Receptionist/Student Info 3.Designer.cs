namespace Tuition_Centre.Receptionist
{
    partial class frmUpdateStu3
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
            this.lblStuStatus = new System.Windows.Forms.Label();
            this.lblStuStatusS = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuStatus
            // 
            this.lblStuStatus.AutoSize = true;
            this.lblStuStatus.Location = new System.Drawing.Point(182, 88);
            this.lblStuStatus.Name = "lblStuStatus";
            this.lblStuStatus.Size = new System.Drawing.Size(78, 15);
            this.lblStuStatus.TabIndex = 0;
            this.lblStuStatus.Text = "Study Status: ";
            // 
            // lblStuStatusS
            // 
            this.lblStuStatusS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuStatusS.Location = new System.Drawing.Point(276, 88);
            this.lblStuStatusS.Name = "lblStuStatusS";
            this.lblStuStatusS.Size = new System.Drawing.Size(100, 15);
            this.lblStuStatusS.TabIndex = 1;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(177, 147);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(209, 15);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Click the button to delete this student.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(206, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpdateStu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 276);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblStuStatusS);
            this.Controls.Add(this.lblStuStatus);
            this.Name = "frmUpdateStu3";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStuStatus;
        private Label lblStuStatusS;
        private Label lblDelete;
        private Button btnDelete;
    }
}