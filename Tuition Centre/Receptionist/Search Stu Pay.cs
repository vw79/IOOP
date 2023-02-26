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
    public partial class frmSearchPay : Form
    {
        private string un;
        public frmSearchPay()
        {
            InitializeComponent();
        }

        public frmSearchPay(string un)
        {
            InitializeComponent();
            this.un = un;
            dgvStuInfo.RowHeaderMouseDoubleClick += dgvStuInfo_RowHeaderMouseDoubleClick;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT i.studentName, i.studentId, p.paymentMethod, p.cardNumber, p.CVV " +
                                            "FROM studentInfo i " +
                                            "JOIN paymentInfo p " +
                                            "ON i.studentDatabaselD = p.studentDatabaseID " +
                                            "WHERE i.studentName LIKE '%' + @searchName + '%'", con);

            // Set the parameter for the query
            cmd.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

            // Create a new SqlDataAdapter to fill a DataTable with the data returned by the query.
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            // Set the DataSource of the DataGridView to the DataTable.
            dgvStuInfo.DataSource = dt;
        }

        private void dgvStuInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row.
            DataGridViewRow row = dgvStuInfo.Rows[e.RowIndex];

            // Get the student ID, name, payment method, card number, and CVV from the row.
            string stuName = row.Cells["studentName"].Value.ToString();
            string studentId = row.Cells["studentId"].Value.ToString();
            string paymentMethod = row.Cells["paymentMethod"].Value.ToString();
            string cardNumber = row.Cells["cardNumber"].Value.ToString();
            string CVV = row.Cells["CVV"].Value.ToString();

            // Create a new instance of the Update_Payment form and pass in the data.
            Update_Payment nextForm = new Update_Payment(un, stuName, studentId, paymentMethod, cardNumber, CVV);
            nextForm.Show();
            this.Hide();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmUpdateStu back = new frmUpdateStu(un);

            back.Show();
            this.Hide();
        }
    }
}
