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
    public partial class frmMainTutor : Form
    {
        public frmMainTutor(string un)
        {
            InitializeComponent();
        }

        public frmMainTutor()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainTutor obj1 = new frmMainTutor();
            this.Hide();
            obj1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTutor_UpdateProfile obj1 = new frmTutor_UpdateProfile();
            this.Hide();
            obj1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTutor_ViewStudents obj1 = new frmTutor_ViewStudents();
            this.Hide();
            obj1.ShowDialog();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTutor_ClassAdd obj1 = new frmTutor_ClassAdd();
            this.Hide();
            obj1.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Tutor_DelClass obj1 = new Tutor_DelClass();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
