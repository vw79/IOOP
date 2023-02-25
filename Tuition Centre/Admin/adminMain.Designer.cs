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
            lblName = new Label();
            grpbIdentity = new GroupBox();
            lblIdentity = new Label();
            splitContainer1 = new SplitContainer();
            btnLogOut = new Button();
            btnUpdate = new Button();
            btnFinance = new Button();
            btnReceptionist = new Button();
            btnTutorList = new Button();
            dgvContent = new DataGridView();
            btnDeleteReceptionist = new Button();
            btnRegisterReceptionist = new Button();
            btnDeleteTutor = new Button();
            btnRegisterTutor = new Button();
            grpbIdentity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContent).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Name :";
            // 
            // grpbIdentity
            // 
            grpbIdentity.Controls.Add(lblIdentity);
            grpbIdentity.Controls.Add(lblName);
            grpbIdentity.Location = new Point(12, 12);
            grpbIdentity.Name = "grpbIdentity";
            grpbIdentity.Size = new Size(776, 69);
            grpbIdentity.TabIndex = 5;
            grpbIdentity.TabStop = false;
            // 
            // lblIdentity
            // 
            lblIdentity.AutoSize = true;
            lblIdentity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentity.Location = new Point(6, 40);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(32, 21);
            lblIdentity.TabIndex = 4;
            lblIdentity.Text = "ID :";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 87);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnLogOut);
            splitContainer1.Panel1.Controls.Add(btnUpdate);
            splitContainer1.Panel1.Controls.Add(btnFinance);
            splitContainer1.Panel1.Controls.Add(btnReceptionist);
            splitContainer1.Panel1.Controls.Add(btnTutorList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvContent);
            splitContainer1.Panel2.Controls.Add(btnDeleteReceptionist);
            splitContainer1.Panel2.Controls.Add(btnRegisterReceptionist);
            splitContainer1.Panel2.Controls.Add(btnDeleteTutor);
            splitContainer1.Panel2.Controls.Add(btnRegisterTutor);
            splitContainer1.Size = new Size(776, 351);
            splitContainer1.SplitterDistance = 139;
            splitContainer1.TabIndex = 6;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(2, 308);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(134, 40);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(3, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFinance
            // 
            btnFinance.Location = new Point(3, 95);
            btnFinance.Name = "btnFinance";
            btnFinance.Size = new Size(134, 40);
            btnFinance.TabIndex = 2;
            btnFinance.Text = "Financial Report";
            btnFinance.UseVisualStyleBackColor = true;
            btnFinance.Click += btnFinance_Click;
            // 
            // btnReceptionist
            // 
            btnReceptionist.Location = new Point(3, 49);
            btnReceptionist.Name = "btnReceptionist";
            btnReceptionist.Size = new Size(134, 40);
            btnReceptionist.TabIndex = 1;
            btnReceptionist.Text = "Receptionist List";
            btnReceptionist.UseVisualStyleBackColor = true;
            btnReceptionist.Click += btnReceptionist_Click;
            // 
            // btnTutorList
            // 
            btnTutorList.Location = new Point(3, 3);
            btnTutorList.Name = "btnTutorList";
            btnTutorList.Size = new Size(134, 40);
            btnTutorList.TabIndex = 0;
            btnTutorList.Text = "Tutor List";
            btnTutorList.UseVisualStyleBackColor = true;
            btnTutorList.Click += btnTutor_Click;
            // 
            // dgvContent
            // 
            dgvContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContent.Location = new Point(3, 3);
            dgvContent.Name = "dgvContent";
            dgvContent.RowHeadersWidth = 51;
            dgvContent.RowTemplate.Height = 25;
            dgvContent.Size = new Size(626, 289);
            dgvContent.TabIndex = 5;
            // 
            // btnDeleteReceptionist
            // 
            btnDeleteReceptionist.Location = new Point(529, 298);
            btnDeleteReceptionist.Name = "btnDeleteReceptionist";
            btnDeleteReceptionist.Size = new Size(100, 50);
            btnDeleteReceptionist.TabIndex = 4;
            btnDeleteReceptionist.Text = "Delete";
            btnDeleteReceptionist.UseVisualStyleBackColor = true;
            btnDeleteReceptionist.Click += btnDeleteReceptionist_Click;
            // 
            // btnRegisterReceptionist
            // 
            btnRegisterReceptionist.Location = new Point(3, 298);
            btnRegisterReceptionist.Name = "btnRegisterReceptionist";
            btnRegisterReceptionist.Size = new Size(100, 50);
            btnRegisterReceptionist.TabIndex = 3;
            btnRegisterReceptionist.Text = "Register";
            btnRegisterReceptionist.UseVisualStyleBackColor = true;
            btnRegisterReceptionist.Click += btnRegisterReceptionist_Click;
            // 
            // btnDeleteTutor
            // 
            btnDeleteTutor.Location = new Point(529, 298);
            btnDeleteTutor.Name = "btnDeleteTutor";
            btnDeleteTutor.Size = new Size(100, 50);
            btnDeleteTutor.TabIndex = 2;
            btnDeleteTutor.Text = "Delete";
            btnDeleteTutor.UseVisualStyleBackColor = true;
            btnDeleteTutor.Click += btnDeleteTutor_Click;
            // 
            // btnRegisterTutor
            // 
            btnRegisterTutor.Location = new Point(3, 298);
            btnRegisterTutor.Name = "btnRegisterTutor";
            btnRegisterTutor.Size = new Size(100, 50);
            btnRegisterTutor.TabIndex = 1;
            btnRegisterTutor.Text = "Register";
            btnRegisterTutor.UseVisualStyleBackColor = true;
            btnRegisterTutor.Click += btnRegisterTutor_Click;
            // 
            // FrmMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(grpbIdentity);
            Name = "FrmMainAdmin";
            Text = "Admin";
            Load += frmMainAdmin_Load;
            grpbIdentity.ResumeLayout(false);
            grpbIdentity.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContent).EndInit();
            ResumeLayout(false);
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
        private Button btnRegisterReceptionist;
        private Button btnDeleteReceptionist;
        private DataGridView dgvContent;
        private Button btnLogOut;
    }
}