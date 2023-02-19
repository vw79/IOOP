namespace Tuition_Centre.Student
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
            this.lblNewSubject = new System.Windows.Forms.Label();
            this.grpOldSubject = new System.Windows.Forms.GroupBox();
            this.lblOldSubject = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.lblhistory = new System.Windows.Forms.Label();
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
            this.grpNewSubject.Controls.Add(this.lblNewSubject);
            this.grpNewSubject.Location = new System.Drawing.Point(473, 183);
            this.grpNewSubject.Name = "grpNewSubject";
            this.grpNewSubject.Size = new System.Drawing.Size(200, 61);
            this.grpNewSubject.TabIndex = 9;
            this.grpNewSubject.TabStop = false;
            this.grpNewSubject.Text = "New Subject";
            // 
            // lblNewSubject
            // 
            this.lblNewSubject.AutoSize = true;
            this.lblNewSubject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNewSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewSubject.Location = new System.Drawing.Point(17, 29);
            this.lblNewSubject.Name = "lblNewSubject";
            this.lblNewSubject.Size = new System.Drawing.Size(92, 20);
            this.lblNewSubject.TabIndex = 1;
            this.lblNewSubject.Text = "New Subject";
            // 
            // grpOldSubject
            // 
            this.grpOldSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOldSubject.Controls.Add(this.lblOldSubject);
            this.grpOldSubject.Location = new System.Drawing.Point(121, 183);
            this.grpOldSubject.Name = "grpOldSubject";
            this.grpOldSubject.Size = new System.Drawing.Size(200, 61);
            this.grpOldSubject.TabIndex = 8;
            this.grpOldSubject.TabStop = false;
            this.grpOldSubject.Text = "Old Subject";
            // 
            // lblOldSubject
            // 
            this.lblOldSubject.AutoSize = true;
            this.lblOldSubject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOldSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblOldSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOldSubject.Location = new System.Drawing.Point(13, 29);
            this.lblOldSubject.Name = "lblOldSubject";
            this.lblOldSubject.Size = new System.Drawing.Size(86, 20);
            this.lblOldSubject.TabIndex = 0;
            this.lblOldSubject.Text = "Old Subject";
            this.lblOldSubject.Click += new System.EventHandler(this.lblOldSubject_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.ForeColor = System.Drawing.Color.Firebrick;
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
            // lblhistory
            // 
            this.lblhistory.AutoSize = true;
            this.lblhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblhistory.ForeColor = System.Drawing.Color.Crimson;
            this.lblhistory.Location = new System.Drawing.Point(125, 152);
            this.lblhistory.Name = "lblhistory";
            this.lblhistory.Size = new System.Drawing.Size(95, 17);
            this.lblhistory.TabIndex = 24;
            this.lblhistory.Text = "History request :";
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblhistory);
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
            this.Load += new System.EventHandler(this.Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).EndInit();
            this.grpNewSubject.ResumeLayout(false);
            this.grpNewSubject.PerformLayout();
            this.grpOldSubject.ResumeLayout(false);
            this.grpOldSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox picChange;
        private GroupBox grpNewSubject;
        private GroupBox grpOldSubject;
        private Button button1;
        private Label lblCondition;
        private PictureBox pictureHome;
        private Label lblNewSubject;
        private Label lblOldSubject;
        private Label lblhistory;
    }
}