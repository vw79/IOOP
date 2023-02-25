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
    public partial class frmTutor_ClassAdd : Form
    {
        public frmTutor_ClassAdd(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // New Class Adding Button
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into class (subjectName, timestart, timeend, date, location, teacher, subjectid, charges, username) values(@name,@start,@end,@date,@loc,@teacher,@id,@char,@username)", con);
            cmd.Parameters.AddWithValue("@id", cmbSubIDAdd.Text);
            cmd.Parameters.AddWithValue("@name", cmbSubNameAdd.Text);
            cmd.Parameters.AddWithValue("@date", dtpClassDate.Text);
            cmd.Parameters.AddWithValue("@loc", cmbLocation.Text);
            cmd.Parameters.AddWithValue("@start", txbStartTime.Text);
            cmd.Parameters.AddWithValue("@end", txbEndTime.Text);
            cmd.Parameters.AddWithValue("@teacher", lblTutorName.Text);
            cmd.Parameters.AddWithValue("@char", txbCharges.Text);
            cmd.Parameters.AddWithValue("@username", Name);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Add New Class.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor(Name);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTutor_ClassAdd_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tutor where tutorName = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblTutorName.Text = rd.GetString(5);
                lblTutorID.Text = rd.GetString(1);
            }
            con.Close();

        }

    }
}
