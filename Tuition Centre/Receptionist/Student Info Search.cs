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
    public partial class frmStuSearch : Form
    {
        private string un;
        private string stuName;
        public frmStuSearch()
        {
            InitializeComponent();
        }

        public frmStuSearch(string un)
        {
            InitializeComponent();
            this.un = un;
          /*  SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();

            SqlCommand rdChangeSub = new SqlCommand("SELECT s.studentId, c.date, s.studentName, c.oldSubject, c.newSubject, c.reasons, c.acceptanceStatus " +
                                                    "FROM changeSubject c " +
                                                    "INNER JOIN studentInfo s ON s.studentDatabaseld = c.studentDatabaseId ", con);

            SqlDataReader rd = rdChangeSub.ExecuteReader();


            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Student Name");
            filteredTable.Columns.Add("Old Subject");
            filteredTable.Columns.Add("New Subject");
            filteredTable.Columns.Add("Reason");
            filteredTable.Columns.Add("Status");

            // Add the rows from the dt to the filteredTable
            while (rd.Read())
            {
                filteredTable.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5));
            }

            rd.Close();
            con.Close();

            // Set the DataSource property of the dgvStuInfo to the filteredTable containing only the desired columns
            dgvChangeSub.DataSource = filteredTable;
            dgvChangeSub.ReadOnly = true;
        }

        /*
        private void dgvChangeSubject_SelectionChanged(object sender, EventArgs e)
        {
            // Get the currently selected row in the DataGridView
            DataGridViewRow selectedRow = dgvChangeSubject.CurrentRow;

            // Extract the data for each column from the selected row
            string id = selectedRow.Cells
            string date = selectedRow.Cells["Date"].Value.ToString();
            string studentName = selectedRow.Cells["Student Name"].Value.ToString();
            string oldSubject = selectedRow.Cells["Old Subject"].Value.ToString();
            string newSubject = selectedRow.Cells["New Subject"].Value.ToString();
            string reason = selectedRow.Cells["Reason"].Value.ToString();
            string status = selectedRow.Cells["Status"].Value.ToString();

            lblStuName.Text = studentName;

            // Create a new instance of the frmUpdateSubject form and pass in the extracted data as parameters
            frmUpdateStu1 updateStuSub = new frmUpdateStu1(date, studentName, oldSubject, newSubject, reason, status);

            // Add the frmUpdateSubject form to the panel3 control
            panel3.Controls.Clear();
            panel3.Controls.Add(updateStuSub);
            updateStuSub.Dock = DockStyle.Fill;
            updateStuSub.BringToFront();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }
        */
    }
}
