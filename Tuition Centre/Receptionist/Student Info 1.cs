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

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateStu1 : Form
    {
       
        public frmUpdateStu1()
        {
            InitializeComponent();
        }
        public frmUpdateStu1(string date, string studentName, string oldSubject, string newSubject, string reason, string status)
        {
            InitializeComponent();
        }
        
    }
}
