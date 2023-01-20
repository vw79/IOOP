namespace Tuition_Centre
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(238, 120);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Location = new System.Drawing.Point(468, 120);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(90, 23);
            this.btnReceptionist.TabIndex = 1;
            this.btnReceptionist.Text = "Receptionist";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(238, 240);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 23);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Location = new System.Drawing.Point(468, 240);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(75, 23);
            this.btnTutor.TabIndex = 3;
            this.btnTutor.Text = "Tutor";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnReceptionist);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Main";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdmin;
        private Button btnReceptionist;
        private Button btnStudent;
        private Button btnTutor;
    }
}