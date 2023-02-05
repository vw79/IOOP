using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Student
{
    public partial class frmMain_Student : Form

    {
        public frmMain_Student(string un)
        {
            InitializeComponent();
            Name = un;
        }

        public frmMain_Student()
        {
        }

        private void Main_Student_Load(object sender, EventArgs e) 
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where studentName = @a", con);
            cmd.Parameters.AddWithValue("@a", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblStudentNum.Text = rd.GetString(6);
                lblStudentCourse.Text = rd.GetString(7);
            }
            con.Close();

        }

        private void cmbChangeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChangeSubject.Text == "Request to change the subject")
            {
                RequestSubject obj1 = new RequestSubject();
                this.Hide();
                obj1.ShowDialog();
            }

            if (cmbChangeSubject.Text == "View the process")
            {
                Process obj1 = new Process();
                this.Hide();
                obj1.ShowDialog();
            }
        }

        private void grpChangeSubject_Enter(object sender, EventArgs e)
        {

        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            EditProfile obj1 = new EditProfile();
            this.Hide();
            obj1.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule obj1 = new Schedule();
            this.Hide();
            obj1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main obj1 = new Main();
            this.Hide();
            obj1.ShowDialog();
        }

        private void frmMainStudent_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Name;
        }
    }
}
