using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Student
{
    public partial class Process : Form
    {
        public Process()
        {
            InitializeComponent();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMain_Student obj1 = new frmMain_Student();
            this.Hide();
            obj1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UnpendingRequest obj1 = new UnpendingRequest();
            this.Close();
            obj1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pendingRequest obj1 = new pendingRequest();
            this.Close();
            obj1.ShowDialog();
        }
    }
}
