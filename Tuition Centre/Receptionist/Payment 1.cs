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
    
    public partial class frmPayment1 : Form
    {
        // Create a new Receptionist object
        private Recep rcp= new Recep();

        public frmPayment1()
        {
            InitializeComponent();
            // Attach the event handler to the DataGridView's SelectionChanged event
            dgvStuInfo.SelectionChanged += dgvStuInfo_SelectionChanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from txtSearch
            string searchName = txtSearch.Text;

            // Call the SearchStu method of the Receptionist object and pass in the search term
            DataTable dt = rcp.SearchStu(searchName);

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
        }

        private void dgvStuInfo_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is at least one row selected
            if (dgvStuInfo.SelectedRows.Count > 0)
            {
                // Get the selected student's data from the dgvStuInfo's SelectedRows collection
                string name = dgvStuInfo.SelectedRows[0].Cells["Name"].Value.ToString();
                string id = dgvStuInfo.SelectedRows[0].Cells["ID"].Value.ToString();

                // Open the new form and pass in the selected student's data
                frmPayment2 newForm = new frmPayment2(name, id);

                // Show the new form
                newForm.Show();

                // Hide the search form
                this.Hide();
            }
        }

    }
}
