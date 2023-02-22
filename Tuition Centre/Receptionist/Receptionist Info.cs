using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateRcp : Form
    {
        private string un;
       
        public frmUpdateRcp()
        {
            InitializeComponent();
        }
       
        public frmUpdateRcp(string un)
        {

            InitializeComponent();
            this.un = un;
            Recep rcp = new Recep();
            string[] recepData = rcp.getRecepData(un); // call the method and store the returned value in a variable

            lblRcpIDS.Text = recepData[0].ToString();
            lblRcpNameS.Text = recepData[1].ToString();
            lblRcpICS.Text = recepData[2].ToString();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }
    }
}
