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

namespace Tuition_Centre.Receptionist
{
    public partial class frmChangeSub : Form
    {
        private string un;
        public frmChangeSub()
        {
            InitializeComponent();
        }

        public frmChangeSub(string un)
        {
            InitializeComponent();
            this.un = un;
            LoadData();
            dgvChangeSub.RowHeaderMouseDoubleClick += dgvChangeSub_RowHeaderMouseDoubleClick;
        }

        private void LoadData()
        {
            // Create a new SqlConnection and SqlCommand to execute the query
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT i.username, i.level, i.studentName, i.studentId, c.oldSubject, c.newSubject, c.acceptanceStatus, c.date, c.reasons, s.subjectid1, s.subjectid2, s.subjectid3 " +
                                            "FROM studentInfo i " +
                                            "JOIN changeSubject c " +
                                            "ON i.studentDatabaselD = c.studentDatabaseID JOIN studentSubject s ON i.studentDatabaselD = s.studentDatabaseID", con);

            // Create a new SqlDataAdapter to fill a DataTable with the data returned by the query.
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            // Set the DataSource of the DataGridView to the DataTable.
            dgvChangeSub.DataSource = dt;
        }

        private void dgvChangeSub_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row.
            DataGridViewRow row = dgvChangeSub.Rows[e.RowIndex];

            // Get the student ID, name, old subject, new subject, acceptance status, date, and reason from the row.
            string stuUsername = row.Cells["username"].Value.ToString();
            string level = row.Cells["level"].Value.ToString();
            string studentId = row.Cells["studentId"].Value.ToString();
            string studentName = row.Cells["studentName"].Value.ToString();
            string oldSubject = row.Cells["oldSubject"].Value.ToString();
            string newSubject = row.Cells["newSubject"].Value.ToString();
            string acceptanceStatus = row.Cells["acceptanceStatus"].Value.ToString();
            string date = row.Cells["date"].Value.ToString();
            string reason = row.Cells["reasons"].Value.ToString();
            string sub1 = row.Cells["subjectid1"].Value.ToString();
            string sub2 = row.Cells["subjectid2"].Value.ToString();
            string sub3 = row.Cells["subjectid3"].Value.ToString();

            // Create a new instance of the Payment2 form and pass in the data.
            frmUpStuSub nextForm = new frmUpStuSub(un, stuUsername, level, studentId, studentName, oldSubject, newSubject, date, acceptanceStatus, reason, sub1, sub2, sub3);
            nextForm.Show();
            this.Hide();
        }

        // This method is called when the pictureHome picture box is clicked.
        private void pictureHome_Click(object sender, EventArgs e)
        {
            // Create a new instance of the frmMainReceptionist form and pass in the current user's username.
            frmMainReceptionist back = new frmMainReceptionist(un);

            // Show the frmMainReceptionist form and hide this form.
            back.Show();
            this.Hide();
        }
    }
}
