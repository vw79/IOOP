namespace Tuition_Centre.Admin
{
    partial class FrmAdminTutorList
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
            this.lstbTutorList = new System.Windows.Forms.ListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbTutorList
            // 
            this.lstbTutorList.FormattingEnabled = true;
            this.lstbTutorList.ItemHeight = 15;
            this.lstbTutorList.Location = new System.Drawing.Point(12, 12);
            this.lstbTutorList.Name = "lstbTutorList";
            this.lstbTutorList.Size = new System.Drawing.Size(776, 364);
            this.lstbTutorList.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 388);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 50);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register Tutor";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Tutor";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 388);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FrmAdminTutorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lstbTutorList);
            this.Name = "FrmAdminTutorList";
            this.Text = "Tutor List";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstbTutorList;
        private Button btnRegister;
        private Button btnDelete;
        private Button btnBack;
    }
}