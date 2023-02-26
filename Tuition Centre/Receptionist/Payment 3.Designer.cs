namespace Tuition_Centre.Receptionist
{
    partial class frmPayment3
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
            lblStuName = new Label();
            lblStuID = new Label();
            lblSub = new Label();
            lblPay = new Label();
            lblAmount = new Label();
            lblStuNameS = new Label();
            lblStuIDS = new Label();
            lblPayS = new Label();
            lblAmountS = new Label();
            btnMainMenu = new Button();
            lstSubject = new ListBox();
            SuspendLayout();
            // 
            // lblStuName
            // 
            lblStuName.AutoSize = true;
            lblStuName.Location = new Point(98, 79);
            lblStuName.Name = "lblStuName";
            lblStuName.Size = new Size(45, 15);
            lblStuName.TabIndex = 0;
            lblStuName.Text = "Name :";
            // 
            // lblStuID
            // 
            lblStuID.AutoSize = true;
            lblStuID.Location = new Point(98, 119);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(68, 15);
            lblStuID.TabIndex = 1;
            lblStuID.Text = "Student ID :";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Location = new Point(98, 158);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(52, 15);
            lblSub.TabIndex = 2;
            lblSub.Text = "Subject :";
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Location = new Point(98, 249);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(60, 15);
            lblPay.TabIndex = 3;
            lblPay.Text = "Payment :";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(98, 287);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(57, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount :";
            // 
            // lblStuNameS
            // 
            lblStuNameS.BorderStyle = BorderStyle.Fixed3D;
            lblStuNameS.Location = new Point(224, 78);
            lblStuNameS.Name = "lblStuNameS";
            lblStuNameS.Size = new Size(200, 23);
            lblStuNameS.TabIndex = 5;
            // 
            // lblStuIDS
            // 
            lblStuIDS.BorderStyle = BorderStyle.Fixed3D;
            lblStuIDS.Location = new Point(224, 118);
            lblStuIDS.Name = "lblStuIDS";
            lblStuIDS.Size = new Size(200, 23);
            lblStuIDS.TabIndex = 6;
            // 
            // lblPayS
            // 
            lblPayS.BorderStyle = BorderStyle.Fixed3D;
            lblPayS.Location = new Point(224, 248);
            lblPayS.Name = "lblPayS";
            lblPayS.Size = new Size(200, 23);
            lblPayS.TabIndex = 8;
            // 
            // lblAmountS
            // 
            lblAmountS.BorderStyle = BorderStyle.Fixed3D;
            lblAmountS.Location = new Point(224, 286);
            lblAmountS.Name = "lblAmountS";
            lblAmountS.Size = new Size(200, 23);
            lblAmountS.TabIndex = 9;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(588, 360);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(100, 23);
            btnMainMenu.TabIndex = 10;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // lstSubject
            // 
            lstSubject.FormattingEnabled = true;
            lstSubject.ItemHeight = 15;
            lstSubject.Location = new Point(224, 158);
            lstSubject.Name = "lstSubject";
            lstSubject.Size = new Size(200, 79);
            lstSubject.TabIndex = 11;
            // 
            // frmPayment3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSubject);
            Controls.Add(btnMainMenu);
            Controls.Add(lblAmountS);
            Controls.Add(lblPayS);
            Controls.Add(lblStuIDS);
            Controls.Add(lblStuNameS);
            Controls.Add(lblAmount);
            Controls.Add(lblPay);
            Controls.Add(lblSub);
            Controls.Add(lblStuID);
            Controls.Add(lblStuName);
            Name = "frmPayment3";
            Text = "Rececipt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStuName;
        private Label lblStuID;
        private Label lblSub;
        private Label lblPay;
        private Label lblAmount;
        private Label lblStuNameS;
        private Label lblStuIDS;
        private Label lblPayS;
        private Label lblAmountS;
        private Button btnMainMenu;
        private ListBox lstSubject;
    }
}