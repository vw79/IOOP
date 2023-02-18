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
using Tuition_Centre.Class;

namespace Tuition_Centre.Student
{
    public partial class EditProfile : Form
    {

        public EditProfile(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            string un;
            frmMain_Student obj1 = new frmMain_Student(Name);
            obj1.ShowDialog();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Update studentinfo set studentPass=@studentPass, birthday=@birthday, studentPhone=@studentPhone, studentEmail=@studentEmail, memo=@memo", con);
            cmd.Parameters.AddWithValue("@studentPass", txtPassport.Text);
            cmd.Parameters.AddWithValue("@birthday", birthday.Text);
            cmd.Parameters.AddWithValue("@studentPhone", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@studentEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@memo", txtmemo.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully update");


        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentinfo where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblStudentName.Text = rd.GetString(5);
                lblStudentNum.Text = rd.GetString(6);
                lblStudentCourse.Text = rd.GetString(12);
                lblStudentNumber.Text = rd.GetString(6);
                lblStudyCourse.Text = rd.GetString(12);
                lblName.Text = rd.GetString(5);

                txtPassport.Text = rd.GetString(6);
                birthday.Text = rd.GetString(11);
                txtPhoneNumber.Text = rd.GetString(8);
                txtEmail.Text = rd.GetString(7);
                txtmemo.Text = rd.GetString(13);

            }
            con.Close();
        }
    }
}
