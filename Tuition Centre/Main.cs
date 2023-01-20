using Tuition_Centre.Admin;
using Tuition_Centre.Receptionist;
using Tuition_Centre.Student;
using Tuition_Centre.Tutor;

namespace Tuition_Centre
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmMainAdmin adminForm = new frmMainAdmin();
            adminForm.Show();
            this.Hide();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            frmMainReceptionist receptionistForm = new frmMainReceptionist();
            receptionistForm.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmMainStudent studentForm = new frmMainStudent();
            studentForm.Show();
            this.Hide();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            frmMainTutor tutorForm = new frmMainTutor();
            tutorForm.Show();
            this.Hide();
        }
    }
}