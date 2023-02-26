using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpStuSub : Form
    {
        private string un;
        private string stuName;
        private string stuUsername;
        private string level;
        private string status;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmUpStuSub()
        {
            InitializeComponent();
        }
        public frmUpStuSub(string un, string stuUsername, string level, string studentId, string studentName, string oldSubject, string newSubject, string date, string acceptanceStatus, string reason, string sub1, string sub2, string sub3)
        {
            InitializeComponent();
            this.un = un;
            this.stuName = studentName;
            this.stuUsername = stuUsername;
            this.status = acceptanceStatus;
            this.level = level;

            lblNameS.Text = studentName;
            lblStuIdS.Text = studentId;

            // Add the subject IDs to the ListBox if they are not null or empty.
            if (!string.IsNullOrEmpty(sub1))
            {
                lsbPreSub.Items.Add(sub1);
            }

            if (!string.IsNullOrEmpty(sub2))
            {
                lsbPreSub.Items.Add(sub2);
            }

            if (!string.IsNullOrEmpty(sub3))
            {
                lsbPreSub.Items.Add(sub3);
            }
        }

        private string GetSubjectId(string subject, string level)
        {
            string formattedLevel = level.Replace("Level ", "");

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
                    subjectId = subjectIds[i] + formattedLevel.PadLeft(3, '0');
                    break;
                }
            }

            return subjectId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            // Validate input data
            if (string.IsNullOrEmpty(cmbSubject1.Text) && string.IsNullOrEmpty(cmbSubject2.Text) && string.IsNullOrEmpty(cmbSubject3.Text))
            {
                MessageBox.Show("Choose at least one subject.");
                return;
            }

            string subjectId1 = "";
            string subjectId2 = "";
            string subjectId3 = "";

            // Check if subject1 is selected
            if (!string.IsNullOrEmpty(cmbSubject1.Text))
            {
                subjectId1 = GetSubjectId(cmbSubject1.Text, level);
            }

            // Check if subject2 is selected
            if (!string.IsNullOrEmpty(cmbSubject2.Text))
            {
                subjectId2 = GetSubjectId(cmbSubject2.Text, level);
            }

            // Check if subject3 is selected
            if (!string.IsNullOrEmpty(cmbSubject3.Text))
            {
                subjectId3 = GetSubjectId(cmbSubject3.Text, level);
            }

            string acceptanceStatus = "Completed";

            // Create a new Recep object and update the student's subjects in the database
            Recep rcp = new Recep(stuName, stuUsername, subjectId1, subjectId2, subjectId3);
            rcp.UpdateStuSubject(acceptanceStatus);

            // Show a message box to indicate that the update is complete
            MessageBox.Show("Subject Update Complete");

        }
        

        // This method is called when the pictureHome picture box is clicked.
        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmChangeSub back = new frmChangeSub(un);

            back.Show();
            this.Hide();
        }
    }
}
