﻿namespace Tuition_Centre.Student
{
    partial class Process
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picChange = new System.Windows.Forms.PictureBox();
            this.grpNewSubject = new System.Windows.Forms.GroupBox();
            this.cmbNewSubject = new System.Windows.Forms.ComboBox();
            this.grpOldSubject = new System.Windows.Forms.GroupBox();
            this.cmbOldSubject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).BeginInit();
            this.grpNewSubject.SuspendLayout();
            this.grpOldSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Request Process";
            // 
            // picChange
            // 
            this.picChange.Image = global::Tuition_Centre.Properties.Resources.change;
            this.picChange.Location = new System.Drawing.Point(346, 194);
            this.picChange.Name = "picChange";
            this.picChange.Size = new System.Drawing.Size(100, 50);
            this.picChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChange.TabIndex = 10;
            this.picChange.TabStop = false;
            // 
            // grpNewSubject
            // 
            this.grpNewSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpNewSubject.Controls.Add(this.cmbNewSubject);
            this.grpNewSubject.Location = new System.Drawing.Point(473, 183);
            this.grpNewSubject.Name = "grpNewSubject";
            this.grpNewSubject.Size = new System.Drawing.Size(200, 61);
            this.grpNewSubject.TabIndex = 9;
            this.grpNewSubject.TabStop = false;
            this.grpNewSubject.Text = "New Subject";
            // 
            // cmbNewSubject
            // 
            this.cmbNewSubject.FormattingEnabled = true;
            this.cmbNewSubject.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "Physical",
            "History",
            "Bahasa",
            "English",
            "Geography"});
            this.cmbNewSubject.Location = new System.Drawing.Point(15, 22);
            this.cmbNewSubject.Name = "cmbNewSubject";
            this.cmbNewSubject.Size = new System.Drawing.Size(180, 23);
            this.cmbNewSubject.TabIndex = 9;
            this.cmbNewSubject.Text = "New Subject";
            // 
            // grpOldSubject
            // 
            this.grpOldSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOldSubject.Controls.Add(this.cmbOldSubject);
            this.grpOldSubject.Location = new System.Drawing.Point(121, 183);
            this.grpOldSubject.Name = "grpOldSubject";
            this.grpOldSubject.Size = new System.Drawing.Size(200, 61);
            this.grpOldSubject.TabIndex = 8;
            this.grpOldSubject.TabStop = false;
            this.grpOldSubject.Text = "Old Subject";
            // 
            // cmbOldSubject
            // 
            this.cmbOldSubject.FormattingEnabled = true;
            this.cmbOldSubject.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "Physical",
            "History",
            "Bahasa",
            "English",
            "Geography"});
            this.cmbOldSubject.Location = new System.Drawing.Point(14, 22);
            this.cmbOldSubject.Name = "cmbOldSubject";
            this.cmbOldSubject.Size = new System.Drawing.Size(180, 23);
            this.cmbOldSubject.TabIndex = 8;
            this.cmbOldSubject.Text = "Old Subject";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(307, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "View Process";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(211, 334);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(407, 15);
            this.lblCondition.TabIndex = 12;
            this.lblCondition.Text = "Warning : You can cancel the request while the process is still pending only. ";
            // 
            // pictureHome
            // 
            this.pictureHome.Image = global::Tuition_Centre.Properties.Resources.home;
            this.pictureHome.Location = new System.Drawing.Point(737, 12);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(51, 43);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 18;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "test unpending";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(613, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "test pending";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureHome);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picChange);
            this.Controls.Add(this.grpNewSubject);
            this.Controls.Add(this.grpOldSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Process";
            this.Text = "RequestProcess";
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).EndInit();
            this.grpNewSubject.ResumeLayout(false);
            this.grpOldSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox picChange;
        private GroupBox grpNewSubject;
        private ComboBox cmbNewSubject;
        private GroupBox grpOldSubject;
        private ComboBox cmbOldSubject;
        private Button button1;
        private Label lblCondition;
        private PictureBox pictureHome;
        private Button button2;
        private Button button5;
    }
}