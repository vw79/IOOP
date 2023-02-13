using System;
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
        public FrmMainAdmin()
        {
            InitializeComponent();
            btnTutorList.Enabled = false;
            btnRegisterReceptionist.Visible= false;
            btnDeleteReceptionist.Visible = false;
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            btnTutorList.Enabled = false;
            btnReceptionist.Enabled = true;
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            btnReceptionist.Enabled = false;
            btnTutorList.Enabled = true;
        }
    }
}
