using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{

    public partial class frmPayment1 : Form
    {
        private string un;
        // This is the default constructor for the frmPayment1 class. It initializes the form components.
        public frmPayment1()
        {
            InitializeComponent();
        }

        // This constructor is used to pass the username of the current user from the previous form to this form.
        public frmPayment1(string un)
        {
            // Initializes the form components.
            InitializeComponent();

            // Store the passed in username in the un variable.
            this.un = un;

            // Add an event handler for the RowHeaderMouseDoubleClick event of the dgvStuInfo DataGridView control.
            dgvStuInfo.RowHeaderMouseDoubleClick += dgvStuInfo_RowHeaderMouseDoubleClick;
        }

        // This method is called when the btnSearch button is clicked.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the txtSearch textbox.
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

        // This method is called when a row header is double-clicked in the dgvStuInfo DataGridView control.
        private void dgvStuInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row.
            DataGridViewRow row = dgvStuInfo.Rows[e.RowIndex];

            // Get the student ID, name, level, and subject IDs from the row.
            string studentId = row.Cells["ID"].Value.ToString();
            string studentName = row.Cells["Name"].Value.ToString();
            string studentLevel = row.Cells["Level"].Value.ToString();
            string subjectId1 = row.Cells["Subject 1"].Value.ToString();
            string subjectId2 = row.Cells["Subject 2"].Value.ToString();
            string subjectId3 = row.Cells["Subject 3"].Value.ToString();

            // Create a new instance of the next form and pass in the student ID, name, level, and subject IDs
            frmPayment2 nextForm = new frmPayment2(un, studentId, studentName, studentLevel, subjectId1, subjectId2, subjectId3);

            // Show the next form
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
