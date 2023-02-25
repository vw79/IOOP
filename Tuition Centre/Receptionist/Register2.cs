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
        private string stuUsername;
        private string un;
        private string subjectId;

        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmRegister2()
        {
            InitializeComponent();
        }

        public frmRegister2(string un, string stuUsername)
        {
            InitializeComponent();
            this.stuUsername = stuUsername;
            this.un = un;
            grpCardInfo.Visible = false;
            // Attach the cmbPayment_SelectedIndexChanged method to the SelectedIndexChanged event of the cmbPayment ComboBox
            cmbPayment.SelectedIndexChanged += cmbPayment_SelectedIndexChanged;
            cmbLevel.SelectedIndex = 0;
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedItem.ToString() == "Cash")
            {
                // If the user selects "credit card", show the panel
                grpCardInfo.Visible = false;
            }
            else
            {
                // If the user selects any other payment method, hide the panel
                grpCardInfo.Visible = true;
            }
        }
        private string GetSubjectId(string subject, string level)
        {
            // An array of all available subjects
            string[] subjects = { "Math", "Science", "History", "English", "Bahasa Melayu", "Geography" };

            // An array of the corresponding subject IDs
            string[] subjectIds = { "math", "sci", "his", "eng", "bm", "geo" };

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

            string paidBy = "-";
            string date = "-";
            string paymentAmount = "-";
            string acceptanceStatus = "-";
            decimal fee = 0;

            con.Open();
            SqlCommand cmdClass = new SqlCommand("SELECT c.subjectId, c.charges, s.subjectid1, s.subjectid2, s.subjectid3 " +
                                                 "FROM studentSubject s " +
                                                 "LEFT JOIN class c ON s.subjectid1 = c.subjectid OR s.subjectid2 = c.subjectid OR s.subjectid3 = c.subjectid " +
                                                 "WHERE s.username = @stuUsername", con);

            cmdClass.Parameters.AddWithValue("@stuUsername", stuUsername);
            SqlDataReader reader = cmdClass.ExecuteReader();

            while (reader.Read())
            {
                // Check if the subjectid1 column is not null
                if (!reader.IsDBNull(reader.GetOrdinal("subjectid1")))
                {
                    // Add the charges for subjectid1 to the fee
                    fee += decimal.Parse(reader["charges"].ToString());
                }

                // Check if the subjectid2 column is not null
                if (!reader.IsDBNull(reader.GetOrdinal("subjectid2")))
                {
                    // Add the charges for subjectid2 to the fee
                    fee += decimal.Parse(reader["charges"].ToString());
                }

                // Check if the subjectid3 column is not null
                if (!reader.IsDBNull(reader.GetOrdinal("subjectid3")))
                {
                    // Add the charges for subjectid3 to the fee
                    fee += decimal.Parse(reader["charges"].ToString());
                }
            }

            Recep rcp = new Recep(stuUsername, subjectId1, subjectId2, subjectId3, cmbLevel.Text, dtpEnrollDate.Text, cmbPayment.Text, txtCardNum.Text, txtCVV.Text, fee, paidBy, date, paymentAmount, acceptanceStatus);
            rcp.addSubjectPay();


            MessageBox.Show("Register Complete");
            frmMainReceptionist mainRcp = new frmMainReceptionist(un);
            mainRcp.Show();
            this.Hide();
        }
    }
}
