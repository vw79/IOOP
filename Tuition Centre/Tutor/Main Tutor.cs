using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tuition_Centre.Tutor
{
    public partial class frmMainTutor : Form
    {
        public frmMainTutor(string un)
        {
            InitializeComponent();
            Name = un;
        }

        public frmMainTutor()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTutor_UpdateProfile obj1 = new frmTutor_UpdateProfile(Name);
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
            frmTutor_ViewStudents obj1 = new frmTutor_ViewStudents(Name);
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
            frmTutor_ClassAdd obj1 = new frmTutor_ClassAdd(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Tutor_DelClass obj1 = new Tutor_DelClass();
            this.Hide();
            obj1.ShowDialog();
        }



        private void frmMainTutor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tutor where tutorName = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblTutorName.Text = rd.GetString(6);
                lblTutorID.Text = rd.GetString(1);
            }
            con.Close();


            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from class where teacher = @tutorFullName", con1);
            cmd1.Parameters.AddWithValue("@tutorFullName", lblTutorName.Text);
            SqlDataReader r1 = cmd1.ExecuteReader();
            while (r1.Read())
            {
                lblTutorClassInfo.Text = r1.GetString(1) + "\n" + r1.GetString(6);

            }

            con.Close();



        }


        

        
    }
}
