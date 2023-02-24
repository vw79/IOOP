using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tuition_Centre.Receptionist
{
    public partial class frmRegister1 : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string un;
        private string newStuId;

        public frmRegister1()
        {
            InitializeComponent();
        }
        public frmRegister1(string un)
        {
            InitializeComponent();
            this.un = un;
            // Create a new SqlConnection object with the connection string and return the status as result
            con.Open();

            // Get the latest studentId from the studentInfo table and generate a new studentId for the new student
            SqlCommand cmdGetId = new SqlCommand("SELECT TOP 1 studentId FROM studentInfo ORDER BY studentId DESC", con);
            string latestStuId = (string)cmdGetId.ExecuteScalar();

            // Extract the integer from the studentId using a regular expression pattern
            int latestId = int.Parse(Regex.Match(latestStuId, @"\d+").Value);

            // New interger of latest +1, padleft 3 to make sure studentId is always 3 digit, '0' is the padding character
            string newStuId = "TC" + (latestId + 1).ToString().PadLeft(3, '0');

            cmdGetId.ExecuteNonQuery();

            lblNewStuId.Text = newStuId;
            this.newStuId = newStuId;
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            string stuLv = "lv";
            string role = "student";
            string stuEnrollDate = "today";
            string stuUsername = txtUsername.Text;

            Recep rcp = new Recep(stuLv, txtUsername.Text, txtPw.Text, role, newStuId, txtStuName.Text, txtStuIcP.Text, txtStuEmail.Text, txtStuPhone.Text, txtStuAddress.Text, stuEnrollDate, dtpBirthday.Text, txtCourse.Text, txtMemo.Text);
            rcp.addStudent();


            frmRegister2 regNext = new frmRegister2(un, stuUsername);
            regNext.Show();
            this.Hide();
        }
    }
}