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
        // Declare a private field to store the username of the currently logged in user.
        private string un;

        // Default constructor.
        public frmSearchDelete()
        {
            InitializeComponent();
        }

        // Constructor that sets the username of the currently logged in user.
        public frmSearchDelete(string un)
        {
            InitializeComponent();
            this.un = un;
        }

        // Event handler for the btnSearch button click event.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the txtSearch TextBox control.
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

        // Event handler for the btnDelete button click event.
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
            // Create a new instance of the frmUpdateStu form and pass in the current user's username.
            frmUpdateStu back = new frmUpdateStu(un);

            // Show the frmUpdateStu form and hide this form.
            back.Show();
            this.Hide();
        }
    }
}
