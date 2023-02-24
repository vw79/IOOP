using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Admin
{
    public partial class FrmAdminRegisterReceptionist : Form
    {
        public FrmAdminRegisterReceptionist()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name     = txtbName.Text;
            string icP      = txtbIcP.Text;
            string phone    = txtbPhone.Text;
            string email    = txtbEmail.Text;
            string Address  = txtbAddress.Text;

        }
    }
}
