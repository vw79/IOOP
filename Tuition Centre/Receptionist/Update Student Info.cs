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
    public partial class frmUpdateStu : Form
    {
        private string searchName;
        private string stuId;
        private string stuName;

        private Button currentButton;
        private Form activeForm;

        public frmUpdateStu()
        {
            InitializeComponent();
        }

        public frmUpdateStu(string un)
        {
            InitializeComponent();

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("Name");
            filteredTable.Columns.Add("Enrollment Date");
            filteredTable.Columns.Add("Study Course");

            // Add the rows from the dt to the filteredTable
            foreach (DataRow row in filteredTable.Rows)
            {
                filteredTable.Rows.Add(row["studentId"], row["studentName"], row["studentEnrollmentDate"], row["studyCourse"]);
            }

            // Set the DataSource property of the dgvStuInfo to the filteredTable containing only the desired columns
            dgvChangeSubject.DataSource = filteredTable;

        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.Show();
        }

        private void btnUpSub_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu1(), btnUpSub);
            btnUpSub.Enabled = false;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = true;
        }

        private void btnUpPay_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu2(), btnUpPay);
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = false;
            btnDeleteStu.Enabled = true;
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu3(), btnDeleteStu);
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = false;
        }

      /*  private void btnSearch_Click(object sender, EventArgs e)
        {
            Recep rcp = new Recep();
            DataTable dt = rcp.SearchStu(searchName);
            searchName = txtSearch.Text;

            if (dt != null && dt.Rows.Count > 0)
            {
                lblStuID.Text = dt.Rows[0]["studentId"].ToString();
                lblStuName.Text = dt.Rows[0]["studentName"].ToString();

                if (btnUpSub.Enabled == false)
                {
                    currentButton = btnUpSub;
                }
                else if (btnUpPay.Enabled == false)
                {
                    currentButton = btnUpPay;
                }
                else if (btnDeleteStu.Enabled == false)
                {
                    currentButton = btnDeleteStu;
                }

                openChildForm(new frmUpdateStu1(), currentButton);
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

            lblSearch.Hide();
            txtSearch.Hide();
            this.Hide();
        }*/

    }
}
