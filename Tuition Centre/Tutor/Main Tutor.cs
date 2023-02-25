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
                lblTutorName.Text = rd.GetString(5);
                lblTutorID.Text = rd.GetString(1);
            }
            con.Close();

            /*
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT subjectName, timestart, timeend, date, location, teacher FROM class where username like '" + Name + "%'", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Subject Name");
            filteredTable.Columns.Add("Time Start");
            filteredTable.Columns.Add("Time End");
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Location");
            filteredTable.Columns.Add("Tutor Full Name");
            foreach (DataRow row in dataTable.Rows)
            {
                filteredTable.Rows.Add(row["subjectName"], row["timestart"], row["timeend"], row["date"], row["location"], row["teacher"]);
            }
            dgv1.DataSource = filteredTable;
            con.Close();
            
            */

            string mainconn = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection sqlconnn = new SqlConnection(mainconn);
            string sqlquery = "select classid, subjectName, timestart, timeend, date, location, teacher from class where username like '" + Name + "%'";
            sqlconnn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconnn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgv1.DataSource = dt;
            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            dgv1.Columns.Insert(6, buttoncolumn);
            buttoncolumn.HeaderText = "Delete Row";
            buttoncolumn.Width = 110;
            buttoncolumn.Text = "Delete";
            buttoncolumn.UseColumnTextForButtonValue = true;
            sqlconnn.Close();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection sqlconnn = new SqlConnection(mainconn);
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to Delete Now?", row.Cells["classid"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(mainconn))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from class where classid = @classid", con1))
                        {
                            cmd.Parameters.AddWithValue("classid", row.Cells["classid"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }
                }
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }

}
