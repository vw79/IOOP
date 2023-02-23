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
    public partial class FrmConfirm : Form
    {

        public bool confirmation{ get; set; }

        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            confirmation = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            confirmation = false;
            this.Close();
        }
    }
}
