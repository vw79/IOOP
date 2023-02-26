namespace Tuition_Centre.Receptionist
{
    partial class frmUpStuSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpStuSub));
            lblStuIdS = new Label();
            lblPreSub = new Label();
            cmbSubject1 = new ComboBox();
            cmbSubject2 = new ComboBox();
            cmbSubject3 = new ComboBox();
            lsbPreSub = new ListBox();
            lblNameS = new Label();
            grpStuInfo = new GroupBox();
            pictureHome = new PictureBox();
            lblStuId = new Label();
            lblName = new Label();
            lblSubUpdate = new Label();
            btnUpdate = new Button();
            grpStuInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            SuspendLayout();
            // 
            // lblStuIdS
            // 
            lblStuIdS.BorderStyle = BorderStyle.Fixed3D;
            lblStuIdS.Location = new Point(109, 56);
            lblStuIdS.Name = "lblStuIdS";
            lblStuIdS.Size = new Size(200, 25);
            lblStuIdS.TabIndex = 0;
            // 
            // lblPreSub
            // 
            lblPreSub.AutoSize = true;
            lblPreSub.Location = new Point(204, 161);
            lblPreSub.Name = "lblPreSub";
            lblPreSub.Size = new Size(89, 15);
            lblPreSub.TabIndex = 2;
            lblPreSub.Text = "Current Subject";
            // 
            // cmbSubject1
            // 
            cmbSubject1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject1.FormattingEnabled = true;
            cmbSubject1.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubject1.Location = new Point(343, 295);
            cmbSubject1.Name = "cmbSubject1";
            cmbSubject1.Size = new Size(201, 23);
            cmbSubject1.TabIndex = 3;
            // 
            // cmbSubject2
            // 
            cmbSubject2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject2.FormattingEnabled = true;
            cmbSubject2.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubject2.Location = new Point(343, 341);
            cmbSubject2.Name = "cmbSubject2";
            cmbSubject2.Size = new Size(201, 23);
            cmbSubject2.TabIndex = 4;
            // 
            // cmbSubject3
            // 
            cmbSubject3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject3.FormattingEnabled = true;
            cmbSubject3.Items.AddRange(new object[] { "", "Mathematics", "Science", "History", "English ", "Bahasa Melayu", "Geography" });
            cmbSubject3.Location = new Point(343, 387);
            cmbSubject3.Name = "cmbSubject3";
            cmbSubject3.Size = new Size(201, 23);
            cmbSubject3.TabIndex = 5;
            // 
            // lsbPreSub
            // 
            lsbPreSub.FormattingEnabled = true;
            lsbPreSub.ItemHeight = 15;
            lsbPreSub.Location = new Point(343, 161);
            lsbPreSub.Name = "lsbPreSub";
            lsbPreSub.Size = new Size(201, 94);
            lsbPreSub.TabIndex = 6;
            // 
            // lblNameS
            // 
            lblNameS.BorderStyle = BorderStyle.Fixed3D;
            lblNameS.Location = new Point(109, 19);
            lblNameS.Name = "lblNameS";
            lblNameS.Size = new Size(200, 25);
            lblNameS.TabIndex = 7;
            // 
            // grpStuInfo
            // 
            grpStuInfo.Controls.Add(pictureHome);
            grpStuInfo.Controls.Add(lblStuId);
            grpStuInfo.Controls.Add(lblNameS);
            grpStuInfo.Controls.Add(lblName);
            grpStuInfo.Controls.Add(lblStuIdS);
            grpStuInfo.Location = new Point(12, 12);
            grpStuInfo.Name = "grpStuInfo";
            grpStuInfo.Size = new Size(776, 100);
            grpStuInfo.TabIndex = 8;
            grpStuInfo.TabStop = false;
            // 
            // pictureHome
            // 
            pictureHome.Image = (Image)resources.GetObject("pictureHome.Image");
            pictureHome.Location = new Point(725, 10);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(51, 43);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 49;
            pictureHome.TabStop = false;
            pictureHome.Click += pictureHome_Click;
            // 
            // lblStuId
            // 
            lblStuId.AutoSize = true;
            lblStuId.Location = new Point(6, 56);
            lblStuId.Name = "lblStuId";
            lblStuId.Size = new Size(67, 15);
            lblStuId.TabIndex = 10;
            lblStuId.Text = "Student Id :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Name :";
            // 
            // lblSubUpdate
            // 
            lblSubUpdate.AutoSize = true;
            lblSubUpdate.Location = new Point(204, 295);
            lblSubUpdate.Name = "lblSubUpdate";
            lblSubUpdate.Size = new Size(116, 15);
            lblSubUpdate.TabIndex = 9;
            lblSubUpdate.Text = "Subject After Update";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(668, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUpStuSub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(lblSubUpdate);
            Controls.Add(grpStuInfo);
            Controls.Add(lsbPreSub);
            Controls.Add(cmbSubject3);
            Controls.Add(cmbSubject2);
            Controls.Add(cmbSubject1);
            Controls.Add(lblPreSub);
            Name = "frmUpStuSub";
            Text = "Update Student Subject";
            grpStuInfo.ResumeLayout(false);
            grpStuInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStuIdS;
        private Label lblPreSub;
        private ComboBox cmbSubject1;
        private ComboBox cmbSubject2;
        private ComboBox cmbSubject3;
        private ListBox lsbPreSub;
        private Label lblNameS;
        private GroupBox grpStuInfo;
        private Label lblStuId;
        private Label lblName;
        private Label lblSubUpdate;
        private Button btnUpdate;
        private PictureBox pictureHome;
    }
}