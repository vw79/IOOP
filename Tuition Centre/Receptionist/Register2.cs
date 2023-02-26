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
using Tuition_Centre.Class;
using static System.Net.Mime.MediaTypeNames;

namespace Tuition_Centre.Receptionist
{
    public partial class frmRegister2 : Form
    {
        private int stuDbId;
        private string stuUsername;
        private string un;

        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmRegister2()
        {
            InitializeComponent();
        }

        // Constructor that takes in the username of the current user and the username of the new student
        public frmRegister2(string un, string stuUsername)
        {
            InitializeComponent();
            this.stuUsername = stuUsername;
            this.un = un;
            grpCardInfo.Visible = false;

            // Attach the cmbPayment_SelectedIndexChanged method to the SelectedIndexChanged event of the cmbPayment ComboBox
            cmbPayment.SelectedIndexChanged += cmbPayment_SelectedIndexChanged;

            // Set the default index of the cmbLevel ComboBox to 0
            cmbLevel.SelectedIndex = 0;
        }

        // Disable the payment method combobox input
        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedItem.ToString() == "Cash")
            {
                // If the user selects "credit card", hide the panel
                grpCardInfo.Visible = false;
            }
            else
            {
                // If the user selects any other payment method, show the panel
                grpCardInfo.Visible = true;
            }
        }

        // Get the subject ID based on the selected subject and level
        private string GetSubjectId(string subject, string level)
        {
            // An array of all available subjects
            string[] subjects = { "Mathematics", "Science", "History", "English", "Bahasa Melayu", "Geography" };

            // An array of the corresponding subject IDs
            string[] subjectIds = { "mth", "sci", "his", "eng", "bah", "geo" };

            // A string to hold the final subject ID
            string subjectId = "";

            // Loop through each subject to check if it has been selected and get its corresponding ID
            for (int i = 0; i < subjects.Length; i++)
            {
                // Check if the subject is selected in any of the subject comboboxes
                if (subject == subjects[i])
                {
                    // If the subject is selected, determine the corresponding subject ID based on the selected level
                    if (level == "Level 1")
                    {
                        subjectId = subjectIds[i] + "001";
                    }
                    else if (level == "Level 2")
                    {
                        subjectId = subjectIds[i] + "002";
                    }
                    else if (level == "Level 3")
                    {
                        subjectId = subjectIds[i] + "003";
                    }
                    else if (level == "Level 4")
                    {
                        subjectId = subjectIds[i] + "004";
                    }
                    else if (level == "Level 5")
                    {
                        subjectId = subjectIds[i] + "005";
                    }
                    return subjectId;
                }
            }
            // Return an empty string if the subject ID is not found
            return "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate input data
            if (string.IsNullOrEmpty(cmbSubject1.Text) && string.IsNullOrEmpty(cmbSubject2.Text) && string.IsNullOrEmpty(cmbSubject3.Text))
            {
                MessageBox.Show("Choose at least one subject.");
                return;
            }

            if (string.IsNullOrEmpty(cmbSubject1.Text) || string.IsNullOrEmpty(cmbLevel.Text) ||
                string.IsNullOrEmpty(dtpEnrollDate.Text) || string.IsNullOrEmpty(cmbPayment.Text))
            {
                MessageBox.Show("Data cannot be empty.");
                return;
            }

            if (cmbPayment.SelectedIndex == 0)
            {
                txtCardNum.Text = "-";
                txtCVV.Text = "-";
            }

            // Validate the contact field to ensure it only contains numbers.
            if (!decimal.TryParse(txtCardNum.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount. Please enter a numeric value.");
                return; // Stop the method from continuing.
            }

            if (!decimal.TryParse(txtCVV.Text, out decimal amount1))
            {
                MessageBox.Show("Invalid amount. Please enter a numeric value.");
                return; // Stop the method from continuing.
            }

            string subjectId1 = "";
            string subjectId2 = "";
            string subjectId3 = "";

            // Check if subject1 is selected
            if (!string.IsNullOrEmpty(cmbSubject1.Text))
            {
                subjectId1 = GetSubjectId(cmbSubject1.Text, cmbLevel.Text);
            }

            // Check if subject2 is selected
            if (!string.IsNullOrEmpty(cmbSubject2.Text))
            {
                subjectId2 = GetSubjectId(cmbSubject2.Text, cmbLevel.Text);
            }

            // Check if subject3 is selected
            if (!string.IsNullOrEmpty(cmbSubject3.Text))
            {
                subjectId3 = GetSubjectId(cmbSubject3.Text, cmbLevel.Text);
            }

            con.Open();
            // Retrieve the full name of the student based on their username
            SqlCommand cmdName = new SqlCommand("SELECT studentName FROM studentInfo WHERE username = @stuUsername", con);
            cmdName.Parameters.AddWithValue("@stuUsername", stuUsername);
            string fullName = cmdName.ExecuteScalar().ToString();

            // Retrieve the database ID of the student based on their username
            SqlCommand cmdDbId = new SqlCommand("SELECT studentDatabaseld FROM studentInfo WHERE username = @stuUsername", con);
            cmdDbId.Parameters.AddWithValue("@stuUsername", stuUsername);
            stuDbId = (int)cmdDbId.ExecuteScalar();

            con.Close();

            // Create a new Recep object and add the student's subject and payment information to the database
            Recep rcp = new Recep(stuUsername, subjectId1, subjectId2, subjectId3, cmbLevel.Text, dtpEnrollDate.Text, cmbPayment.Text, txtCardNum.Text, txtCVV.Text, fullName, stuDbId);
            rcp.addSubjectPay();

            // Show a message box to indicate that the registration is complete
            MessageBox.Show("Register Complete");

            // Create a new frmMainReceptionist object and show it while hiding this form
            frmMainReceptionist mainRcp = new frmMainReceptionist(un);
            mainRcp.Show();
            this.Hide();
        }
    }
}
