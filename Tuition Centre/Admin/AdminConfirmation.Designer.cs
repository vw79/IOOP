namespace Tuition_Centre.Admin
{
    partial class FrmConfirm
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
            lblConfirm = new Label();
            btnYes = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(122, 61);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(78, 15);
            lblConfirm.TabIndex = 0;
            lblConfirm.Text = "Are you sure?";
            // 
            // btnYes
            // 
            btnYes.Location = new Point(226, 129);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(100, 50);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(12, 129);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(100, 50);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // FrmConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 191);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblConfirm);
            Name = "FrmConfirm";
            Text = "Confirm?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirm;
        private Button btnYes;
        private Button btnNo;
    }
}