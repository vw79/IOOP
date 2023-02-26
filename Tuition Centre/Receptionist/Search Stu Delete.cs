using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmSearchDelete : Form
    {
        private string un;
        public frmSearchDelete()
        {
            InitializeComponent();
        }
        public frmSearchDelete(string un)
        {
            InitializeComponent();
            this.un = un; // Constructor to set the username of the logged in user.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;

            // If the search term is null, whitespace, or empty, show an error message and return.
            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Create a new Receptionist object.
            Recep rcp = new Recep();

            // Call the SearchStu method of the Receptionist object and pass in the search term.
            DataTable dt = rcp.searchStu(searchName);

            // If no students are found, show a message box.
            if (dt == null)
            {
                MessageBox.Show("No students found.");
            }
            else
            {
                // Create a new DataTable with only the desired columns.
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("ID");
                filteredTable.Columns.Add("Name");
                filteredTable.Columns.Add("Level");
                filteredTable.Columns.Add("Subject 1");
                filteredTable.Columns.Add("Subject 2");
                filteredTable.Columns.Add("Subject 3");
                filteredTable.Columns.Add("Enrollment Date");
                filteredTable.Columns.Add("Study Course");

                // Add the rows from the dt to the filteredTable.
                foreach (DataRow row in dt.Rows)
                {
                    filteredTable.Rows.Add(row["studentId"], row["studentName"], row["level"], row["subjectid1"], row["subjectid2"], row["subjectid3"], row["studentEnrollmentDate"], row["studyCourse"]);
                }

                // Set the DataSource property of the dgvStuInfo DataGridView control to the filteredTable containing only the desired columns.
                dgvStuInfo.DataSource = filteredTable;
                dgvStuInfo.ReadOnly = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected row.
            if (dgvStuInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }
            DataGridViewRow row = dgvStuInfo.SelectedRows[0];

            // Get the student ID and name from the row.
            string studentId = row.Cells["ID"].Value.ToString();
            string studentName = row.Cells["Name"].Value.ToString();

            // Show a confirmation message box.
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {studentName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Create a new Receptionist object.
                Recep rcp = new Recep();

                // Call the deleteStudent method of the Receptionist object and pass in the student name.
                string status = rcp.deleteStudent(studentName);

                // Show a message box with the status message.
                MessageBox.Show(status);

                // Remove the selected row from the DataGridView control.
                dgvStuInfo.Rows.Remove(row);
            }
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmUpdateStu back = new frmUpdateStu(un);

            back.Show();
            this.Hide();
        }
    }
}
