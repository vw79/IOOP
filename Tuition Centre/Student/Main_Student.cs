using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Student
{
    public partial class frmMainStudent : Form
    {
        public frmMainStudent(string un)
        {
            InitializeComponent();
        }

        public frmMainStudent()
        {
        }

        private void cmbChangeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChangeSubject.Text == "Request to change the subject")
            {
                RequestSubject obj1 = new RequestSubject();
                this.Hide();
                obj1.ShowDialog();
            }

            if (cmbChangeSubject.Text == "View the process")
            {
                Process obj1 = new Process();
                this.Hide();
                obj1.ShowDialog();
            }
        }

        private void grpChangeSubject_Enter(object sender, EventArgs e)
        {

        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            EditProfile obj1 = new EditProfile();
            this.Hide();
            obj1.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule obj1 = new Schedule();
            this.Hide();
            obj1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main obj1 = new Main();
            this.Hide();
            obj1.ShowDialog();
        }

        private void frmMainStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
