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
        //Property
        private string username;

        public FrmMainAdmin(string un)
        {
            InitializeComponent();
            //Assign username un 
            username = un;
            //Calls this function
            TutorOrReceptionistClicked(false, true);
            //Create a new object and call in two functions that changes the labels
            AdminClass loader = new AdminClass();
            string name = loader.NameDisplay(un);
            string identity = loader.IdentityDisplay(un);
            lblName.Text = "Name: " + name;
            lblIdentity.Text = "ID: " + identity;
            //Create new object with data from AdminClass and proceeds to display the data in a data grid view
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
            //Calls this function
            TutorOrReceptionistClicked(false, true);
            //Clears the data grid view
            dgvContent.Columns.Clear();
            //Create new object with data from AdminClass and proceeds to display the data in a data grid view
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
            //Calls this function
            TutorOrReceptionistClicked(true, false);
            //Clears the data grid view
            dgvContent.Columns.Clear();
            //Create new object with data from AdminClass and proceeds to display the data in a data grid view
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
            //Opens a new form
            FrmAdminRegisterReceptionist obj1 = new FrmAdminRegisterReceptionist();
            obj1.ShowDialog();
        }

        private void TutorOrReceptionistClicked(bool a, bool b)
        {
            //This method is used to disable and enable some buttons
            btnTutorList.Enabled = a;
            btnRegisterTutor.Visible = b;
            btnDeleteTutor.Visible = b;
            btnReceptionist.Enabled = b;
            btnRegisterReceptionist.Visible = a;
            btnDeleteReceptionist.Visible = a;
        }

        private void DeleteAndConfirmation(string table, string idType)
        {
            //If there is a selected row in the data grid view
            if (dgvContent.SelectedRows.Count > 0)
            {
                //Opens a new form to
                FrmConfirm confrmobj = new FrmConfirm();
                confrmobj.ShowDialog();
                //Receive a boolean value from the form
                bool confirmation = confrmobj.confirmation;
                //If the value is true proceed to remove the selected row from the data grid view and call a method to delete
                //it from a database
                if (confirmation)
                {
                    //Reads the userId so the program knows which user to delete
                    DataGridViewRow selectedRow = dgvContent.SelectedRows[0];
                    string identity = dgvContent.SelectedRows[0].Cells[0].Value.ToString();
                    dgvContent.Rows.Remove(dgvContent.SelectedRows[0]);
                    AdminClass delete = new AdminClass();
                    //Pass the userID, desired table and which user to be deleted
                    delete.DeleteUser(identity, table, idType);
                }
            }
        }

        private void btnRegisterTutor_Click(object sender, EventArgs e)
        {
            //Opens a new form
            FrmAdminRegisterTutor adminTutorFrm = new FrmAdminRegisterTutor();
            adminTutorFrm.ShowDialog();
        }

        private void btnDeleteReceptionist_Click(object sender, EventArgs e)
        {
            //Declares these values and pass it into the method
            string table = "receptionist";
            string idType = "recepId";
            DeleteAndConfirmation(table, idType);
        }

        private void btnDeleteTutor_Click(object sender, EventArgs e)
        {
            //Declares these values and pass it into the method
            string table = "tutor";
            string idType = "tutorId";
            DeleteAndConfirmation(table, idType);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Open a new form
            FrmAdminUpdateProfile adminFrm = new FrmAdminUpdateProfile(username);
            adminFrm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Open a new form while closing this one
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            //Open a new form
            FrmAdminFinance finance = new FrmAdminFinance();
            finance.ShowDialog();
        }
    }
}