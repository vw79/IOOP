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


        // To Main Tutor Form
        private void button1_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor(Name);
            this.Hide();
            obj.ShowDialog();
        }

        // To Tutor Update Form
        private void button3_Click(object sender, EventArgs e)
        {
            frmTutor_UpdateProfile obj1 = new frmTutor_UpdateProfile(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        // Logout Form
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Main obj = new Main();
                this.Hide();
                obj.ShowDialog();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // New Class Adding Button
        {
            DialogResult dialog = MessageBox.Show("Confirm the Class Information?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
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
                
        }


        // Main User Info Show
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


        // Clear Form Button
        private void button7_Click(object sender, EventArgs e)
        {
            cmbSubIDAdd.Text = "";
            cmbSubNameAdd.Text = "";
            dtpClassDate.Text = "";
            cmbLocation.Text = "";
            txbStartTime.Text = "";
            txbEndTime.Text = "";
            txbCharges.Text = "";
        }

        // Cancel and Back to Main Tutor Form
        private void button2_Click(object sender, EventArgs e)
        {
            frmMainTutor obj = new frmMainTutor(Name);
            this.Hide();
            obj.ShowDialog();
        }
    }
}
