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


        // Update Profile Form
        private void button3_Click(object sender, EventArgs e)
        {
            frmTutor_UpdateProfile obj1 = new frmTutor_UpdateProfile(Name);
            this.Hide();
            obj1.ShowDialog();
        }


        // Tutor Logout
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


        // Tutor Add New Form
        private void button5_Click(object sender, EventArgs e)
        {
            frmTutor_ClassAdd obj1 = new frmTutor_ClassAdd(Name);
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


            // Take Class information with specific columns

            string mainconn = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection sqlconnn = new SqlConnection(mainconn);
            string sqlquery = "select classid, subjectid, subjectName, timestart, timeend, date, location from class where username like '" + Name + "%'";
            sqlconnn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconnn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgv1.DataSource = dt;


            // Delete Class 

            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            dgv1.Columns.Insert(7, buttoncolumn);
            buttoncolumn.HeaderText = "Delete Class";
            buttoncolumn.Text = "Delete";
            buttoncolumn.Width = 120;
            buttoncolumn.UseColumnTextForButtonValue = true;
            sqlconnn.Close();


            // View All Classes

            DataGridViewButtonColumn buttoncolumnView = new DataGridViewButtonColumn();
            dgv1.Columns.Insert(8, buttoncolumnView);
            buttoncolumnView.HeaderText = "View Students";
            buttoncolumnView.Text = "View";
            buttoncolumnView.Width = 135;
            buttoncolumnView.UseColumnTextForButtonValue = true;
            sqlconnn.Close();
        }

        // Class Delete and View Student  
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection sqlconnn = new SqlConnection(mainconn);
            // To Delete Class
            if (e.ColumnIndex == 7)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to Delete this Class?", row.Cells["classid"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(mainconn))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from class where classid = @classid", con1))
                        {
                            cmd.Parameters.AddWithValue("classid", row.Cells["classid"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                            frmMainTutor obj = new frmMainTutor(Name);
                            this.Hide();
                            obj.ShowDialog();
                        }
                    }
                }
            }
            // To View Students
            else if (e.ColumnIndex == 8)
            {
                frmTutor_ViewStudents obj1 = new frmTutor_ViewStudents(Name);
                obj1.ShowDialog();
            }
        }

    }

}
