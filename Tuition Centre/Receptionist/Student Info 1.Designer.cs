namespace Tuition_Centre.Receptionist
{
    partial class frmUpdateStu1
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
            this.lblCurrentSub = new System.Windows.Forms.Label();
            this.lblSubAfterUp = new System.Windows.Forms.Label();
            this.cmbSubAfterUp = new System.Windows.Forms.ComboBox();
            this.lblStuStatusS = new System.Windows.Forms.Label();
            this.lblCurrentSubS = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuStatus
            // 
            this.lblStuStatus.AutoSize = true;
            this.lblStuStatus.Location = new System.Drawing.Point(28, 32);
            this.lblStuStatus.Name = "lblStuStatus";
            this.lblStuStatus.Size = new System.Drawing.Size(78, 15);
            this.lblStuStatus.TabIndex = 0;
            this.lblStuStatus.Text = "Study Status: ";
            // 
            // lblCurrentSub
            // 
            this.lblCurrentSub.AutoSize = true;
            this.lblCurrentSub.Location = new System.Drawing.Point(28, 76);
            this.lblCurrentSub.Name = "lblCurrentSub";
            this.lblCurrentSub.Size = new System.Drawing.Size(100, 15);
            this.lblCurrentSub.TabIndex = 1;
            this.lblCurrentSub.Text = "Current Subjects: ";
            // 
            // lblSubAfterUp
            // 
            this.lblSubAfterUp.AutoSize = true;
            this.lblSubAfterUp.Location = new System.Drawing.Point(28, 126);
            this.lblSubAfterUp.Name = "lblSubAfterUp";
            this.lblSubAfterUp.Size = new System.Drawing.Size(124, 15);
            this.lblSubAfterUp.TabIndex = 2;
            this.lblSubAfterUp.Text = "Subjects after update: ";
            // 
            // cmbSubAfterUp
            // 
            this.cmbSubAfterUp.FormattingEnabled = true;
            this.cmbSubAfterUp.Location = new System.Drawing.Point(179, 126);
            this.cmbSubAfterUp.Name = "cmbSubAfterUp";
            this.cmbSubAfterUp.Size = new System.Drawing.Size(200, 23);
            this.cmbSubAfterUp.TabIndex = 3;
            // 
            // lblStuStatusS
            // 
            this.lblStuStatusS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuStatusS.Location = new System.Drawing.Point(179, 31);
            this.lblStuStatusS.Name = "lblStuStatusS";
            this.lblStuStatusS.Size = new System.Drawing.Size(200, 23);
            this.lblStuStatusS.TabIndex = 4;
            // 
            // lblCurrentSubS
            // 
            this.lblCurrentSubS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentSubS.Location = new System.Drawing.Point(179, 75);
            this.lblCurrentSubS.Name = "lblCurrentSubS";
            this.lblCurrentSubS.Size = new System.Drawing.Size(200, 23);
            this.lblCurrentSubS.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(441, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmUpdateStu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 276);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCurrentSubS);
            this.Controls.Add(this.lblStuStatusS);
            this.Controls.Add(this.cmbSubAfterUp);
            this.Controls.Add(this.lblSubAfterUp);
            this.Controls.Add(this.lblCurrentSub);
            this.Controls.Add(this.lblStuStatus);
            this.Name = "frmUpdateStu1";
            this.Text = "Student_Info_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStuStatus;
        private Label lblCurrentSub;
        private Label lblSubAfterUp;
        private ComboBox cmbSubAfterUp;
        private Label lblStuStatusS;
        private Label lblCurrentSubS;
        private Button btnUpdate;
    }
}