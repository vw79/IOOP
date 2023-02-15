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

namespace Tuition_Centre.Admin
{
    public partial class FrmMainAdmin : Form
    {
        public static string name;
        public static string identity;

        public FrmMainAdmin(string id)
        {
            InitializeComponent();
            TutorOrReceptionistClicked(false, true);
            //name = n;
            //identity = id;
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
