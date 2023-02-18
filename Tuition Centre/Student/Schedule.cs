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
                lblStudentInfo.Text = rd.GetString(5) + " |  " + rd.GetString(4) + " |  " +  rd.GetString(12);
            }

            con.Close();

            SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from studentSubject where username = @username", con2);
            cmd2.Parameters.AddWithValue("@username", Name);
            SqlDataReader read = cmd2.ExecuteReader();
            while (read.Read())
            {
                subject1.Text = read.GetString(4);
                subject2.Text = read.GetString(5);
                subject3.Text = read.GetString(6);


            }
          
            con2.Close();

            //subject1 detail
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("select * from subject where subjectName = @name", con3);
            cmd3.Parameters.AddWithValue("@name", subject1.Text);
            SqlDataReader r = cmd3.ExecuteReader();
            while (r.Read())
            {
                location1.Text = r.GetString(5);
                date1.Text = r.GetString(4);
                time1.Text = r.GetString(2) + " - " + r.GetString(3);
                teacher1.Text= r.GetString(6);
            }
            con3.Close();

            //subject2 detail
            SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con4.Open();
            SqlCommand cmd4 = new SqlCommand("select * from subject where subjectName = @name", con4);
            cmd4.Parameters.AddWithValue("@name", subject2.Text);
            SqlDataReader r2 = cmd4.ExecuteReader();
            while (r2.Read())
            {
                location2.Text = r2.GetString(5);
                date2.Text = r2.GetString(4);
                time2.Text = r2.GetString(2) + " - " + r2.GetString(3);
                teacher2.Text = r2.GetString(6);
            }
            con4.Close();

            //subject3 detail
            SqlConnection con5 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con5.Open();
            SqlCommand cmd5 = new SqlCommand("select * from subject where subjectName = @name", con5);
            cmd5.Parameters.AddWithValue("@name", subject3.Text);
            SqlDataReader r3 = cmd5.ExecuteReader();
            while (r3.Read())
            {
                location3.Text = r3.GetString(5);
                date3.Text = r3.GetString(4);
                time3.Text = r3.GetString(2) + " - " + r3.GetString(3);
                teacher3.Text = r3.GetString(6);
            }
            con5.Close();



        }
    }
}
