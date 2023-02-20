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
            this.lblName = new System.Windows.Forms.Label();
            this.grpbIdentity = new System.Windows.Forms.GroupBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnTutorList = new System.Windows.Forms.Button();
            this.btnDeleteReceptionist = new System.Windows.Forms.Button();
            this.btnRegisterReceptionist = new System.Windows.Forms.Button();
            this.btnDeleteTutor = new System.Windows.Forms.Button();
            this.btnRegisterTutor = new System.Windows.Forms.Button();
            this.lstbContent = new System.Windows.Forms.ListBox();
            this.grpbIdentity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // grpbIdentity
            // 
            this.grpbIdentity.Controls.Add(this.lblIdentity);
            this.grpbIdentity.Controls.Add(this.lblName);
            this.grpbIdentity.Location = new System.Drawing.Point(12, 12);
            this.grpbIdentity.Name = "grpbIdentity";
            this.grpbIdentity.Size = new System.Drawing.Size(776, 69);
            this.grpbIdentity.TabIndex = 5;
            this.grpbIdentity.TabStop = false;
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentity.Location = new System.Drawing.Point(6, 40);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(32, 21);
            this.lblIdentity.TabIndex = 4;
            this.lblIdentity.Text = "ID :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 87);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnFinance);
            this.splitContainer1.Panel1.Controls.Add(this.btnReceptionist);
            this.splitContainer1.Panel1.Controls.Add(this.btnTutorList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteReceptionist);
            this.splitContainer1.Panel2.Controls.Add(this.btnRegisterReceptionist);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteTutor);
            this.splitContainer1.Panel2.Controls.Add(this.btnRegisterTutor);
            this.splitContainer1.Panel2.Controls.Add(this.lstbContent);
            this.splitContainer1.Size = new System.Drawing.Size(776, 351);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFinance
            // 
            this.btnFinance.Location = new System.Drawing.Point(3, 95);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(134, 40);
            this.btnFinance.TabIndex = 2;
            this.btnFinance.Text = "Financial Report";
            this.btnFinance.UseVisualStyleBackColor = true;
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Location = new System.Drawing.Point(3, 49);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(134, 40);
            this.btnReceptionist.TabIndex = 1;
            this.btnReceptionist.Text = "Receptionist List";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnTutorList
            // 
            this.btnTutorList.Location = new System.Drawing.Point(3, 3);
            this.btnTutorList.Name = "btnTutorList";
            this.btnTutorList.Size = new System.Drawing.Size(134, 40);
            this.btnTutorList.TabIndex = 0;
            this.btnTutorList.Text = "Tutor List";
            this.btnTutorList.UseVisualStyleBackColor = true;
            this.btnTutorList.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnDeleteReceptionist
            // 
            this.btnDeleteReceptionist.Location = new System.Drawing.Point(529, 298);
            this.btnDeleteReceptionist.Name = "btnDeleteReceptionist";
            this.btnDeleteReceptionist.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteReceptionist.TabIndex = 4;
            this.btnDeleteReceptionist.Text = "Delete";
            this.btnDeleteReceptionist.UseVisualStyleBackColor = true;
            // 
            // btnRegisterReceptionist
            // 
            this.btnRegisterReceptionist.Location = new System.Drawing.Point(3, 298);
            this.btnRegisterReceptionist.Name = "btnRegisterReceptionist";
            this.btnRegisterReceptionist.Size = new System.Drawing.Size(100, 50);
            this.btnRegisterReceptionist.TabIndex = 3;
            this.btnRegisterReceptionist.Text = "Register";
            this.btnRegisterReceptionist.UseVisualStyleBackColor = true;
            this.btnRegisterReceptionist.Click += new System.EventHandler(this.btnRegisterReceptionist_Click);
            // 
            // btnDeleteTutor
            // 
            this.btnDeleteTutor.Location = new System.Drawing.Point(529, 298);
            this.btnDeleteTutor.Name = "btnDeleteTutor";
            this.btnDeleteTutor.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteTutor.TabIndex = 2;
            this.btnDeleteTutor.Text = "Delete";
            this.btnDeleteTutor.UseVisualStyleBackColor = true;
            // 
            // btnRegisterTutor
            // 
            this.btnRegisterTutor.Location = new System.Drawing.Point(3, 298);
            this.btnRegisterTutor.Name = "btnRegisterTutor";
            this.btnRegisterTutor.Size = new System.Drawing.Size(100, 50);
            this.btnRegisterTutor.TabIndex = 1;
            this.btnRegisterTutor.Text = "Register";
            this.btnRegisterTutor.UseVisualStyleBackColor = true;
            this.btnRegisterTutor.Click += new System.EventHandler(this.btnRegisterTutor_Click);
            // 
            // lstbContent
            // 
            this.lstbContent.FormattingEnabled = true;
            this.lstbContent.ItemHeight = 15;
            this.lstbContent.Location = new System.Drawing.Point(3, 3);
            this.lstbContent.Name = "lstbContent";
            this.lstbContent.Size = new System.Drawing.Size(626, 289);
            this.lstbContent.TabIndex = 0;
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpbIdentity);
            this.Name = "FrmMainAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmMainAdmin_Load);
            this.grpbIdentity.ResumeLayout(false);
            this.grpbIdentity.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
        }

        #endregion
        private Label lblName;
        private GroupBox grpbIdentity;
        private Label lblIdentity;
        private SplitContainer splitContainer1;
        private Button btnTutorList;
        private Button btnReceptionist;
        private Button btnUpdate;
        private Button btnFinance;
        private Button btnDeleteTutor;
        private Button btnRegisterTutor;
        private ListBox lstbContent;
        private Button btnRegisterReceptionist;
        private Button btnDeleteReceptionist;
    }
}