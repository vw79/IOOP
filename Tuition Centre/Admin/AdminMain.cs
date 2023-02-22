using System;
using System.Collections;
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
    public partial class FrmMainAdmin : Form
    {
        public FrmMainAdmin(string un)
        {
            InitializeComponent();
            TutorOrReceptionistClicked(false, true);
            AdminClass loader = new AdminClass();
            string name = loader.NameDisplay(un);
            string identity = loader.IdentityDisplay(un);
            lblName.Text = "Name: " + name;
            lblIdentity.Text = "ID: " + identity;
            ArrayList tutorinfo = new ArrayList();
            tutorinfo = loader.ViewTutorList();
            foreach (var item in tutorinfo)
            {
                int count = 0;
                //if count 
                MessageBox.Show(item.ToString());
            }
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            TutorOrReceptionistClicked(false, true); 
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            TutorOrReceptionistClicked(true, false);
        }

        private void btnRegisterReceptionist_Click(object sender, EventArgs e)
        {

        }
        private void TutorOrReceptionistClicked(bool a, bool b)
        {
            btnTutorList.Enabled = a;
            btnRegisterTutor.Visible = b;
            btnDeleteTutor.Visible = b;
            btnReceptionist.Enabled = b;
            btnRegisterReceptionist.Visible = a;
            btnDeleteReceptionist.Visible = a;
        }

        private void ListLoader()
        {
            ArrayList name = new ArrayList();

        }

        private void btnRegisterTutor_Click(object sender, EventArgs e)
        {
            FrmAdminRegisterTutor adminTutorFrm = new FrmAdminRegisterTutor();
            adminTutorFrm.ShowDialog();
        }
    }
}
