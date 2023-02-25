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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from txtSearch
            searchName = txtSearch.Text;

            Recep rcp = new Recep();

            // Call the SearchStudent method to retrieve the search results
            DataTable dt = rcp.searchStu();

            // Check if the search results are null
            if (dt == null)
            {
                MessageBox.Show("Student does not exist.");
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

        
        /*
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
        */
        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }
    }
}
