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
    public partial class frmSearchPay : Form
    {
        private string un;
        public frmSearchPay()
        {
            InitializeComponent();
        }

        public frmSearchPay(string un)
        {
            InitializeComponent();
            this.un = un;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmUpdateStu back = new frmUpdateStu(un);

            back.Show();
            this.Hide();
        }
    }
}
