namespace Tuition_Centre.Student
{
    partial class RequestSubject
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.grpOldSubject = new System.Windows.Forms.GroupBox();
            this.txtOldSubject = new System.Windows.Forms.TextBox();
            this.grpNewSubject = new System.Windows.Forms.GroupBox();
            this.txtNewSubject = new System.Windows.Forms.TextBox();
            this.grpReason = new System.Windows.Forms.GroupBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.picChange = new System.Windows.Forms.PictureBox();
            this.grpCourse.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpOldSubject.SuspendLayout();
            this.grpNewSubject.SuspendLayout();
            this.grpReason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(90, 64);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(197, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Change Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "_____________________________________________";
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.txtCourse);
            this.grpCourse.Location = new System.Drawing.Point(99, 130);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(200, 61);
            this.grpCourse.TabIndex = 2;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Course Intake";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(15, 25);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PlaceholderText = "Course Intake";
            this.txtCourse.Size = new System.Drawing.Size(179, 23);
            this.txtCourse.TabIndex = 0;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.txtDate);
            this.grpDate.Location = new System.Drawing.Point(99, 197);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(200, 61);
            this.grpDate.TabIndex = 3;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(15, 25);
            this.txtDate.Name = "txtDate";
            this.txtDate.PlaceholderText = "Date";
            this.txtDate.Size = new System.Drawing.Size(179, 23);
            this.txtDate.TabIndex = 0;
            // 
            // grpOldSubject
            // 
            this.grpOldSubject.Controls.Add(this.txtOldSubject);
            this.grpOldSubject.Location = new System.Drawing.Point(99, 264);
            this.grpOldSubject.Name = "grpOldSubject";
            this.grpOldSubject.Size = new System.Drawing.Size(200, 61);
            this.grpOldSubject.TabIndex = 4;
            this.grpOldSubject.TabStop = false;
            this.grpOldSubject.Text = "Old Subject";
            // 
            // txtOldSubject
            // 
            this.txtOldSubject.Location = new System.Drawing.Point(15, 25);
            this.txtOldSubject.Name = "txtOldSubject";
            this.txtOldSubject.PlaceholderText = "Old Subject";
            this.txtOldSubject.Size = new System.Drawing.Size(179, 23);
            this.txtOldSubject.TabIndex = 0;
            // 
            // grpNewSubject
            // 
            this.grpNewSubject.Controls.Add(this.txtNewSubject);
            this.grpNewSubject.Location = new System.Drawing.Point(451, 264);
            this.grpNewSubject.Name = "grpNewSubject";
            this.grpNewSubject.Size = new System.Drawing.Size(200, 61);
            this.grpNewSubject.TabIndex = 5;
            this.grpNewSubject.TabStop = false;
            this.grpNewSubject.Text = "New Subject";
            // 
            // txtNewSubject
            // 
            this.txtNewSubject.Location = new System.Drawing.Point(15, 25);
            this.txtNewSubject.Name = "txtNewSubject";
            this.txtNewSubject.PlaceholderText = "New Subject";
            this.txtNewSubject.Size = new System.Drawing.Size(179, 23);
            this.txtNewSubject.TabIndex = 0;
            // 
            // grpReason
            // 
            this.grpReason.Controls.Add(this.txtReason);
            this.grpReason.Location = new System.Drawing.Point(451, 130);
            this.grpReason.Name = "grpReason";
            this.grpReason.Size = new System.Drawing.Size(238, 128);
            this.grpReason.TabIndex = 3;
            this.grpReason.TabStop = false;
            this.grpReason.Text = "Reasons";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(15, 25);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PlaceholderText = "Type Somthing here......";
            this.txtReason.Size = new System.Drawing.Size(208, 90);
            this.txtReason.TabIndex = 0;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRequest.Location = new System.Drawing.Point(455, 356);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(108, 46);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // picChange
            // 
            this.picChange.Image = global::Tuition_Centre.Properties.Resources.change;
            this.picChange.Location = new System.Drawing.Point(324, 275);
            this.picChange.Name = "picChange";
            this.picChange.Size = new System.Drawing.Size(100, 50);
            this.picChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChange.TabIndex = 7;
            this.picChange.TabStop = false;
            // 
            // RequestSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picChange);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.grpReason);
            this.Controls.Add(this.grpNewSubject);
            this.Controls.Add(this.grpOldSubject);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Name = "RequestSubject";
            this.Text = "RequestSubject";
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.grpOldSubject.ResumeLayout(false);
            this.grpOldSubject.PerformLayout();
            this.grpNewSubject.ResumeLayout(false);
            this.grpNewSubject.PerformLayout();
            this.grpReason.ResumeLayout(false);
            this.grpReason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeading;
        private Label label2;
        private GroupBox grpCourse;
        private TextBox txtCourse;
        private GroupBox grpDate;
        private TextBox txtDate;
        private GroupBox grpOldSubject;
        private TextBox txtOldSubject;
        private GroupBox grpNewSubject;
        private TextBox txtNewSubject;
        private GroupBox grpReason;
        private TextBox txtReason;
        private Button btnRequest;
        private PictureBox picChange;
    }
}