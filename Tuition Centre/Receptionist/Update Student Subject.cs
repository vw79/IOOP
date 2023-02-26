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

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpStuSub : Form
    {
        private string un;
        private string stuUsername;
        private string sub1;
        private string sub2;
        private string sub3;
        private string level;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmUpStuSub()
        {
            InitializeComponent();
        }
        public frmUpStuSub(string stuUsername, string level, string un, string studentId, string studentName, string oldSubject, string newSubject, string date, string acceptanceStatus, string reason, string sub1, string sub2, string sub3)
        {
            InitializeComponent();
            this.un = un;
            this.stuUsername = stuUsername;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input data
            if (string.IsNullOrEmpty(cmbSubject1.Text) && string.IsNullOrEmpty(cmbSubject2.Text) && string.IsNullOrEmpty(cmbSubject3.Text))
            {
                MessageBox.Show("Change at least one subject.");
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

            Recep rcp = new Recep(subjectId1, subjectId2, subjectId3, stuUsername);
            rcp.UpdateStuSubject();


            // Show a success message.
            MessageBox.Show("Student subject updated successfully.");
        }

        // This method is called when the pictureHome picture box is clicked.
        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmUpdateStu back = new frmUpdateStu(un);

            back.Show();
            this.Hide();
        }
    }
}
