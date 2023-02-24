using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuition_Centre.Admin
{
    public partial class FrmMainAdmin : Form
    {
        private string username;

        public FrmMainAdmin(string un)
        {
            InitializeComponent();
            username = un;
            TutorOrReceptionistClicked(false, true);
            AdminClass loader = new AdminClass();
            string name = loader.NameDisplay(un);
            string identity = loader.IdentityDisplay(un);
            lblName.Text = "Name: " + name;
            lblIdentity.Text = "ID: " + identity;
            DataTable dataTable = loader.ViewTutorList();
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Name");
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("IC/Passport");
            filteredTable.Columns.Add("Email");
            filteredTable.Columns.Add("Phone Number");
            filteredTable.Columns.Add("Address");
            filteredTable.Columns.Add("Date of Birth");
            filteredTable.Columns.Add("Subject");
            filteredTable.Columns.Add("Level");

            foreach (DataRow row in dataTable.Rows)
            {
                filteredTable.Rows.Add(row["tutorFullName"], row["tutorId"], row["tutorICorPass"], row["tutorEmail"], row["tutorPhone"], row["tutorAddress"], row["tutorDOB"], row["subject"], row["level"]);
            }
            dgvContent.DataSource = filteredTable;
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            TutorOrReceptionistClicked(false, true);
            dgvContent.Columns.Clear();
            AdminClass loader = new AdminClass();
            DataTable dataTable = loader.ViewTutorList();
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("userId");
            filteredTable.Columns.Add("Name");
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("IC/Passport");
            filteredTable.Columns.Add("Email");
            filteredTable.Columns.Add("Phone Number");
            filteredTable.Columns.Add("Address");
            filteredTable.Columns.Add("Date of Birth");
            filteredTable.Columns.Add("Subject");
            filteredTable.Columns.Add("Level");
            foreach (DataRow row in dataTable.Rows)
            {
                filteredTable.Rows.Add(row["userId"], row["tutorFullName"], row["tutorId"], row["tutorICorPass"], row["tutorEmail"], row["tutorPhone"], row["tutorAddress"], row["tutorDOB"], row["subject"], row["level"]);
            }
            dgvContent.DataSource = filteredTable;

        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            TutorOrReceptionistClicked(true, false);
            dgvContent.Columns.Clear();
            AdminClass loader = new AdminClass();
            DataTable dataTable = loader.ViewReceptionistList();
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("usersId");
            filteredTable.Columns.Add("Name");
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("IC/Passport");
            filteredTable.Columns.Add("Email");
            filteredTable.Columns.Add("Phone Number");
            filteredTable.Columns.Add("Address");

            foreach (DataRow row in dataTable.Rows)
            {
                filteredTable.Rows.Add(row["usersId"], row["recepName"], row["recepId"], row["recepIcP"], row["recepEmail"], row["recepPhone"], row["recepAddress"]);
            }
            dgvContent.DataSource = filteredTable;
        }

        private void btnRegisterReceptionist_Click(object sender, EventArgs e)
        {
            FrmAdminRegisterReceptionist obj1 = new FrmAdminRegisterReceptionist();
            obj1.ShowDialog();
        }

        private void TutorOrReceptionistClicked(bool a, bool b)
        {
            btnTutorList.Enabled = a;
            btnRegisterTutor.Visible = b;
            btnDeleteTutor.Visible = b;
            btnReceptionist.Enabled = b;
            btnRegisterReceptionist.Visible = a;
            btnDeleteReceptionist.Visible = a;
        }

        private void DeleteAndConfirmation(string table, string idType)
        {
            if (dgvContent.SelectedRows.Count > 0)
            {
                FrmConfirm confrmobj = new FrmConfirm();
                confrmobj.ShowDialog();
                bool confirmation = confrmobj.confirmation;
                if (confirmation)
                {
                    DataGridViewRow selectedRow = dgvContent.SelectedRows[0];
                    string identity = dgvContent.SelectedRows[0].Cells[0].Value.ToString();
                    dgvContent.Rows.Remove(dgvContent.SelectedRows[0]);
                    AdminClass delete = new AdminClass();
                    delete.DeleteUser(identity, table, idType);
                }
            }
        }

        private void btnRegisterTutor_Click(object sender, EventArgs e)
        {
            FrmAdminRegisterTutor adminTutorFrm = new FrmAdminRegisterTutor();
            adminTutorFrm.ShowDialog();
        }

        private void btnDeleteReceptionist_Click(object sender, EventArgs e)
        {
            string table = "receptionist";
            string idType = "recepId";
            DeleteAndConfirmation(table, idType);
        }

        private void btnDeleteTutor_Click(object sender, EventArgs e)
        {
            string table = "tutor";
            string idType = "tutorId";
            DeleteAndConfirmation(table, idType);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAdminUpdateProfile adminFrm = new FrmAdminUpdateProfile(username);
            adminFrm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
