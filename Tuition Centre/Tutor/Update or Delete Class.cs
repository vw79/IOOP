using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Tutor
{
    public partial class frmTutor_ClassUpdate : Form
    {
        public frmTutor_ClassUpdate()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = "Are you Sure About that? -_-";
            MessageBox.Show(text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text = "Oops, You confirmed!";
            MessageBox.Show(text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor();
            this.Hide();
            obj.ShowDialog();

        }
    }
}
