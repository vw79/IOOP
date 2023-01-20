using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Student
{
    public partial class frmMainStudent : Form
    {
        public frmMainStudent()
        {
            InitializeComponent();
        }

        private void cmbChangeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChangeSubject.Text == "Request to change the subject")
            {
                RequestSubject obj1 = new RequestSubject();
                this.Close();
                obj1.ShowDialog();
            }
        }
    }
}
