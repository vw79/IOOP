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
    public partial class frmTutor_ViewStudents : Form
    {
        public frmTutor_ViewStudents(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void View_Enrolled_Students_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection sqlconnn = new SqlConnection(mainconn);
            string sqlquery = "select fullname from studentSubject where subjectid1 = '" + txtClassCode.Text + "' or subjectid2 = '" + txtClassCode.Text + "' or subjectid3 = '" + txtClassCode.Text + "'";
            sqlconnn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconnn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgv1.DataSource = dt;
            dgv1.Columns["fullname"].Width = 200;
        }
    }
}
