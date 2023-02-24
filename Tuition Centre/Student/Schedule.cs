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

namespace Tuition_Centre.Student
{
    public partial class Schedule : Form
    {
        

        public Schedule(string un)
        {
            InitializeComponent();
            Name = un;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string un;
            frmMain_Student obj1 = new frmMain_Student(Name);
            obj1.ShowDialog();
            Hide();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentinfo where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblStudentInfo.Text = rd.GetString(4) + " |  " + rd.GetString(3) + " |  " +  rd.GetString(11);
            }

            con.Close();

            SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from studentSubject where username = @username", con2);
            cmd2.Parameters.AddWithValue("@username", Name);
            SqlDataReader read = cmd2.ExecuteReader();
            while (read.Read())
            {
                code1.Text = read.GetString(2);
                code2.Text = read.GetString(3);
                code3.Text = read.GetString(4);


            }
          
            con2.Close();

            //subject1 detail
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("select * from class where subjectid = @name", con3);
            cmd3.Parameters.AddWithValue("@name", code1.Text);
            SqlDataReader r = cmd3.ExecuteReader();
            while (r.Read())
            {
                lblsubject1.Text = r.GetString(1);
                location1.Text = r.GetString(5);
                date1.Text = r.GetString(3);
                time1.Text = r.GetString(2) + " - " + r.GetString(4);
                teacher1.Text= r.GetString(6);
            }
            con3.Close();

            //subject2 detail
            SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con4.Open();
            SqlCommand cmd4 = new SqlCommand("select * from class where subjectid = @name", con4);
            cmd4.Parameters.AddWithValue("@name", code2.Text);
            SqlDataReader r2 = cmd4.ExecuteReader();
            while (r2.Read())
            {
                lblsubject2.Text= r2.GetString(1);
                location2.Text = r2.GetString(5);
                date2.Text = r2.GetString(3);
                time2.Text = r2.GetString(2) + " - " + r2.GetString(4);
                teacher2.Text = r2.GetString(6);
            }
            con4.Close();

            //subject3 detail
            SqlConnection con5 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con5.Open();
            SqlCommand cmd5 = new SqlCommand("select * from class where subjectid = @name", con5);
            cmd5.Parameters.AddWithValue("@name", code3.Text);
            SqlDataReader r3 = cmd5.ExecuteReader();
            while (r3.Read())
            {
                lblsubject3.Text = r3.GetString(1);
                location3.Text = r3.GetString(5);
                date3.Text = r3.GetString(3);
                time3.Text = r3.GetString(2) + " - " + r3.GetString(4);
                teacher3.Text = r3.GetString(6);
            }
            con5.Close();



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void subject1_Click(object sender, EventArgs e)
        {

        }

        private void lblsubject3_Click(object sender, EventArgs e)
        {

        }

        private void lblsubject2_Click(object sender, EventArgs e)
        {

        }

        private void date1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
