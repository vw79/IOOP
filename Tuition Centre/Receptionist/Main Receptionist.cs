using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Receptionist
{
    public partial class frmMainReceptionist : Form
    {
        public frmMainReceptionist()
        {
        }

        public frmMainReceptionist(string un)
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment1 paymentPage1= new frmPayment1();
            paymentPage1.Show();
            this.Hide();
        }

        private void btnRegNewStu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO WORLD");
        }

        private void btnUpdateRcpInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            frmUpdateStu studentInfoPage1= new frmUpdateStu();
            studentInfoPage1.Show();
            this.Hide();
        }
    }
}
