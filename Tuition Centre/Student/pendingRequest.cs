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
    public partial class pendingRequest : Form
    {
        public pendingRequest(string un)
        {
            InitializeComponent();
            Name= un;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMain_Student obj1 = new frmMain_Student(Name);
            this.Close();
            obj1.ShowDialog();
        }

        private void pictureBackward_Click(object sender, EventArgs e)
        {
            
        }
    }
}
