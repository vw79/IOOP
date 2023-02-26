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
            lblCurrentSub = new Label();
            lblSubAfterUp = new Label();
            cmbSubAfterUp = new ComboBox();
            btnUpdate = new Button();
            lstSubject = new ListBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // lblCurrentSub
            // 
            lblCurrentSub.AutoSize = true;
            lblCurrentSub.Location = new Point(28, 42);
            lblCurrentSub.Name = "lblCurrentSub";
            lblCurrentSub.Size = new Size(100, 15);
            lblCurrentSub.TabIndex = 1;
            lblCurrentSub.Text = "Current Subjects: ";
            // 
            // lblSubAfterUp
            // 
            lblSubAfterUp.AutoSize = true;
            lblSubAfterUp.Location = new Point(28, 126);
            lblSubAfterUp.Name = "lblSubAfterUp";
            lblSubAfterUp.Size = new Size(124, 15);
            lblSubAfterUp.TabIndex = 2;
            lblSubAfterUp.Text = "Subjects after update: ";
            // 
            // cmbSubAfterUp
            // 
            cmbSubAfterUp.FormattingEnabled = true;
            cmbSubAfterUp.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubAfterUp.Location = new Point(179, 126);
            cmbSubAfterUp.Name = "cmbSubAfterUp";
            cmbSubAfterUp.Size = new Size(200, 23);
            cmbSubAfterUp.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(441, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lstSubject
            // 
            lstSubject.FormattingEnabled = true;
            lstSubject.ItemHeight = 15;
            lstSubject.Location = new Point(179, 42);
            lstSubject.Name = "lstSubject";
            lstSubject.Size = new Size(200, 64);
            lstSubject.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            comboBox1.Location = new Point(179, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            comboBox2.Location = new Point(179, 184);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 9;
            // 
            // frmUpdateStu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 276);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lstSubject);
            Controls.Add(btnUpdate);
            Controls.Add(cmbSubAfterUp);
            Controls.Add(lblSubAfterUp);
            Controls.Add(lblCurrentSub);
            Name = "frmUpdateStu1";
            Text = "Student_Info_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCurrentSub;
        private Label lblSubAfterUp;
        private ComboBox cmbSubAfterUp;
        private Button btnUpdate;
        private ListBox lstSubject;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}