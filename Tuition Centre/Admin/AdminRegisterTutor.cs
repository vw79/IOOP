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
            string fullName = txtbFullName.Text;
            string phone    = txtbPhone.Text;
            string icP      = txtbIcP.Text;
            string address  = txtbAddress.Text;
            string email    = txtbEmail.Text;
            string subject  = txtbSubject.Text;
            string level    = cmbLevel.Text;
            string dob      = dtpDOB.Text;
            string username = txtbUsername.Text;
            string password = txtbPassword.Text;
            AdminClass register = new AdminClass(fullName, username, password, phone, email, dob, address, subject, level, icP);
            register.RegisterTutor();
            this.Close();
        }
    }
}
