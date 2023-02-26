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
    public partial class RequestSubject : Form
    {
        public RequestSubject(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void StudentMainPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into changeSubject (studentDatabaseId, acceptanceStatus, courseIntake, date, oldSubject, newSubject, reasons, username) values(@s,@a,@course,@date,@old,@new,@reasons,@username)", con);
            cmd.Parameters.AddWithValue("@course", txtCourse.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@old", cmbOldSubject.Text);
            cmd.Parameters.AddWithValue("@new", cmbNewSubject.Text);
            cmd.Parameters.AddWithValue("@reasons", txtReason.Text);
            cmd.Parameters.AddWithValue("@a", "Pending");
            cmd.Parameters.AddWithValue("@username",Name);
            cmd.Parameters.AddWithValue("@s", "");
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Request");
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            string un;
            frmMain_Student obj1 = new frmMain_Student(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void RequestSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
