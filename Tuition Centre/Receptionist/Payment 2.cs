using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Tuition_Centre.Receptionist
{
    public partial class frmPayment2 : Form
    {
        public frmPayment2()
        {
            InitializeComponent();
        }

        public frmPayment2(string name, string id)
        {
            InitializeComponent();
            lblStuNameS.Text = name;
            lblStuIDS.Text = id;
        }


    }
}
