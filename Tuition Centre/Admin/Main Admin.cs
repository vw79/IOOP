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
    public partial class frmMainAdmin : Form
    {
        public static string name;

        public frmMainAdmin()
        {
        }

        public frmMainAdmin(string n)
        {
            InitializeComponent();
            name = n;
        }


        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
