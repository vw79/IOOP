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

        private void frmMainStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentinfo where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblWelcome.Text = "Welcome, " + rd.GetString(5);
                lblStudentName.Text= rd.GetString(5);
                lblStudentNum.Text = rd.GetString(4);
                lblStudentCourse.Text = rd.GetString(12);
            }
            con.Close();

        }

        private void cmbChangeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChangeSubject.Text == "Request to change the subject")
            {
                RequestSubject obj1 = new RequestSubject(Name);
                this.Hide();
                obj1.ShowDialog();
            }

            if (cmbChangeSubject.Text == "View the process")
            {
                Process obj1 = new Process(Name);
                this.Hide(); 
                obj1.ShowDialog();
            }
        }

        private void grpChangeSubject_Enter(object sender, EventArgs e)
        {

        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            EditProfile obj1 = new EditProfile(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule obj1 = new Schedule(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main obj1 = new Main();
            this.Hide();
            obj1.ShowDialog();
        }

        private void lblStudentCourse_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }
    }
}
