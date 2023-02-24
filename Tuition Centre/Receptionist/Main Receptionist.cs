using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmMainReceptionist : Form
    {
        private string un;

        public frmMainReceptionist()
        {
        }

        public frmMainReceptionist(string un)
        {
            InitializeComponent();
            this.un = un;
            Recep rcp = new Recep();
            string[] recepData = rcp.getRecepData(un); // call the method and store the returned value in a variable

            lblWlcRcp.Text = "Welcome Back, " + recepData[1].ToString(); // set the label text using the returned value
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment1 paymentPage1 = new frmPayment1(un);
            paymentPage1.Show();
            this.Hide();
        }

        private void btnRegNewStu_Click(object sender, EventArgs e)
        {
            frmRegister1 register1 = new frmRegister1(un);
            register1.Show();
            this.Hide();
        }

        private void btnUpdateRcpInfo_Click(object sender, EventArgs e)
        {
            frmUpdateRcp updateRcp = new frmUpdateRcp(un);
            updateRcp.Show();
            this.Hide();
        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            frmUpdateStu studentInfoPage1 = new frmUpdateStu(un);
            studentInfoPage1.Show();
            this.Hide();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            Main logOut = new Main();
            logOut.Show();
            this.Hide();
            MessageBox.Show("Logout");
        }

        private void frmMainReceptionist_Load(object sender, EventArgs e)
        {

        }
    }
}
