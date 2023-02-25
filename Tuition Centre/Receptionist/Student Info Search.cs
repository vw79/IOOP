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
        private string stuName
        public frmStuSearch()
        {
            InitializeComponent();
        }

        public frmStuSearch(string un, string stuName)
        {
            InitializeComponent();
            this.un = un;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

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
    }
}
