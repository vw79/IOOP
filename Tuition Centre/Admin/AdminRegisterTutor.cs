using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Admin
{
    public partial class FrmAdminRegisterTutor : Form
    {
        public FrmAdminRegisterTutor()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbFullName.Text) || !string.IsNullOrEmpty(txtbPhone.Text) || !string.IsNullOrEmpty(txtbIcP.Text) || 
                !string.IsNullOrEmpty(txtbAddress.Text) || !string.IsNullOrEmpty(txtbEmail.Text) || !string.IsNullOrEmpty(txtbSubject.Text) ||
                !string.IsNullOrEmpty(cmbLevel.Text) || !string.IsNullOrEmpty(dtpDOB.Text) || !string.IsNullOrEmpty(txtbUsername.Text) ||
                !string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Please make sure all fields are filled");
            }
            else
            {
                string fullName = txtbFullName.Text;
                string phone = txtbPhone.Text;
                string icP = txtbIcP.Text;
                string address = txtbAddress.Text;
                string email = txtbEmail.Text;
                string subject = txtbSubject.Text;
                string level = cmbLevel.Text;
                string dob = dtpDOB.Text;
                string username = txtbUsername.Text;
                string password = txtbPassword.Text;
                AdminClass register = new AdminClass(fullName, username, password, phone, email, dob, address, subject, level, icP);
                register.RegisterTutor();
                this.Close();    
            }
        }
    }
}
