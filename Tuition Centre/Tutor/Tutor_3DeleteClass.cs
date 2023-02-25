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
    public partial class Tutor_DelClass : Form
    {
        public Tutor_DelClass()
        {
            InitializeComponent();
        }

        private void Tutor_DelClass_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor(Name);
            this.Hide();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor(Name);
            this.Hide();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTutor_ViewStudents obj1 = new frmTutor_ViewStudents(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTutor_UpdateProfile obj1 = new frmTutor_UpdateProfile(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
