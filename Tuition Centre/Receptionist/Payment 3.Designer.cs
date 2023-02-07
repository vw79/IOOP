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
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStuNameS = new System.Windows.Forms.Label();
            this.lblStuIDS = new System.Windows.Forms.Label();
            this.lblSubjectS = new System.Windows.Forms.Label();
            this.lblPayS = new System.Windows.Forms.Label();
            this.lblAmountS = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(98, 79);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(45, 15);
            this.lblStuName.TabIndex = 0;
            this.lblStuName.Text = "Name :";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(98, 118);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(68, 15);
            this.lblStuID.TabIndex = 1;
            this.lblStuID.Text = "Student ID :";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(98, 158);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(52, 15);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Subject :";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(98, 195);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(60, 15);
            this.lblPay.TabIndex = 3;
            this.lblPay.Text = "Payment :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(98, 233);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 15);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount :";
            // 
            // lblStuNameS
            // 
            this.lblStuNameS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuNameS.Location = new System.Drawing.Point(224, 79);
            this.lblStuNameS.Name = "lblStuNameS";
            this.lblStuNameS.Size = new System.Drawing.Size(200, 23);
            this.lblStuNameS.TabIndex = 5;
            // 
            // lblStuIDS
            // 
            this.lblStuIDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuIDS.Location = new System.Drawing.Point(224, 118);
            this.lblStuIDS.Name = "lblStuIDS";
            this.lblStuIDS.Size = new System.Drawing.Size(200, 23);
            this.lblStuIDS.TabIndex = 6;
            // 
            // lblSubjectS
            // 
            this.lblSubjectS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubjectS.Location = new System.Drawing.Point(224, 158);
            this.lblSubjectS.Name = "lblSubjectS";
            this.lblSubjectS.Size = new System.Drawing.Size(200, 23);
            this.lblSubjectS.TabIndex = 7;
            // 
            // lblPayS
            // 
            this.lblPayS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayS.Location = new System.Drawing.Point(224, 195);
            this.lblPayS.Name = "lblPayS";
            this.lblPayS.Size = new System.Drawing.Size(200, 23);
            this.lblPayS.TabIndex = 8;
            // 
            // lblAmountS
            // 
            this.lblAmountS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountS.Location = new System.Drawing.Point(224, 233);
            this.lblAmountS.Name = "lblAmountS";
            this.lblAmountS.Size = new System.Drawing.Size(200, 23);
            this.lblAmountS.TabIndex = 9;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(588, 360);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 23);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmPayment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblAmountS);
            this.Controls.Add(this.lblPayS);
            this.Controls.Add(this.lblSubjectS);
            this.Controls.Add(this.lblStuIDS);
            this.Controls.Add(this.lblStuNameS);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblStuID);
            this.Controls.Add(this.lblStuName);
            this.Name = "frmPayment3";
            this.Text = "Rececipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStuName;
        private Label lblStuID;
        private Label lblSub;
        private Label lblPay;
        private Label lblAmount;
        private Label lblStuNameS;
        private Label lblStuIDS;
        private Label lblSubjectS;
        private Label lblPayS;
        private Label lblAmountS;
        private Button btnMainMenu;
    }
}