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

namespace Tuition_Centre.Tutor
{
    public partial class frmTutor_UpdateProfile : Form
    {
        public frmTutor_UpdateProfile(string un)
        {
            InitializeComponent();
            Name = un; 
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainTutor obj1 = new frmMainTutor(Name);
            this.Hide();
            obj1.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor(Name);
            this.Hide();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tutor set tutorPhone=@phone, tutorAddress=@address, subject=@subject where tutorName=@username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            cmd.Parameters.AddWithValue("@phone", txbUpdatePh.Text);
            cmd.Parameters.AddWithValue("@address", txbUpdateAddress.Text);
            cmd.Parameters.AddWithValue("@subject", cmbUpdateSub.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully update");
        }

        private void frmTutor_UpdateProfile_Load(object sender, EventArgs e)
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
                lblUpdateName.Text = rd.GetString(6);
                lblUpdateID.Text = rd.GetString(1);
                lblUpdateDOB.Text = rd.GetString(10);
            }
            con.Close();

            
        }
    }
}
