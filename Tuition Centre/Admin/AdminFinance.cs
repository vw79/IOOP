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
    public partial class FrmAdminFinance : Form
    {
        public static string name;


        public FrmAdminFinance()
        {
            InitializeComponent();

        }


        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dtbMonthYear_ValueChanged(object sender, EventArgs e)
        {
            dtpMonthYear.Value = new DateTime(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month, 1);
        }
    }
}
