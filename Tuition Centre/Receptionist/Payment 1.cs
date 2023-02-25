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
        private string searchName;

        public frmPayment1()
        {
            InitializeComponent();
        }

        public frmPayment1(string un)
        {
            InitializeComponent();
            this.un = un;
            dgvStuInfo.RowHeaderMouseDoubleClick += dgvStuInfo_RowHeaderMouseDoubleClick;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchName = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Create a new Receptionist object
            Recep rcp = new Recep();

            // Call the SearchStu method of the Receptionist object and pass in the search term
            DataTable dt = rcp.searchStu(searchName);

            if (dt == null)
            {
                MessageBox.Show("No students found.");
            }
            else
            {
                // Create a new DataTable with only the desired columns
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("ID");
                filteredTable.Columns.Add("Name");
                filteredTable.Columns.Add("Enrollment Date");
                filteredTable.Columns.Add("Study Course");

                // Add the rows from the dt to the filteredTable
                foreach (DataRow row in dt.Rows)
                {
                    filteredTable.Rows.Add(row["studentId"], row["studentName"], row["studentEnrollmentDate"], row["studyCourse"]);
                }

                // Set the DataSource property of the dgvStuInfo to the filteredTable containing only the desired columns
                dgvStuInfo.DataSource = filteredTable;
                dgvStuInfo.ReadOnly = true;
            }
        }

        private void dgvStuInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = dgvStuInfo.Rows[e.RowIndex];

            // Get the student ID from the row
            string studentId = row.Cells["ID"].Value.ToString();

            // Get the student name from the row
            string studentName = row.Cells["Name"].Value.ToString();

            // Create a new instance of the next form and pass in the student ID and name
            frmPayment2 nextForm = new frmPayment2(un, studentId, studentName);

            // Show the next form
            nextForm.Show();
            this.Hide();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }
    }
}
