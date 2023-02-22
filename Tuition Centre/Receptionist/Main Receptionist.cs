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
            Recep rcp = new Recep();
            string rcpName = rcp.welcomeRecep(un); // call the method and store the returned value in a variable
            lblWlcRcp.Text = "Welcome Back, " + rcpName; // set the label text using the returned value
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment1 paymentPage1= new frmPayment1();
            paymentPage1.Show();
            this.Hide();
        }

        private void btnRegNewStu_Click(object sender, EventArgs e)
        {
            frmRegister1 register1 = new frmRegister1();
            register1.Show();
            this.Hide();
        }

        private void btnUpdateRcpInfo_Click(object sender, EventArgs e)
        {
            frmUpdateRcp updateRcp = new frmUpdateRcp();
            updateRcp.Show();
            this.Hide();
        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            frmUpdateStu studentInfoPage1= new frmUpdateStu();
            studentInfoPage1.Show();
            this.Hide();
        }
    }
}
