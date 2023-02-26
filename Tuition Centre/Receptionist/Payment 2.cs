using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Tuition_Centre.Class;
using System.Configuration;
using System.Data.SqlClient;

namespace Tuition_Centre.Receptionist
{
    public partial class frmPayment2 : Form
    {
        private string un;
        private string stuUsername;
        private string studentId;
        private string studentName;
        private string studentLevel;
        private string subjectId1;
        private string subjectId2;
        private string subjectId3;

        // This is the default constructor for the frmPayment2 class. It initializes the form components.
        public frmPayment2()
        {
            InitializeComponent();
        }

        // This constructor is used to pass the current user's username and the student's information from the previous form to this form.
        public frmPayment2(string un, string studentId, string studentName, string studentLevel, string subjectId1, string subjectId2, string subjectId3)
        {
            // Initializes the form components.
            InitializeComponent();

            // Store the passed in values in their respective variables.
            this.un = un;
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentLevel = studentLevel;
            this.subjectId1 = subjectId1;
            this.subjectId2 = subjectId2;
            this.subjectId3 = subjectId3;

            // Set the text of the lblStuNameS and lblStuIDS labels to the student's name and ID, respectively.
            lblStuNameS.Text = studentName;
            lblStuIDS.Text = studentId;
        }

        // Connect to the database.
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // This method is called when the btnReceipt button is clicked.
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            // Validate the amount field to ensure it only contains numbers.
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount. Please enter a numeric value.");
                return; // Stop the method from continuing.
            }

            // Proceed with generating the receipt and updating the database.
            string acceptStatus = "Accepted";
            string payAmount = txtAmount.Text;
            string paymentMethod = cmbPay.Text;
            DateTime date = dtpDate.Value;

            con.Open();

            // Create a new SqlCommand object to retrieve the student's username from the studentInfo table.
            SqlCommand cmd = new SqlCommand("SELECT username FROM studentInfo WHERE studentName = @stuName", con);

            // Add a parameter to the SqlCommand object for the student's name.
            cmd.Parameters.AddWithValue("@stuName", studentName);

            // Execute the SqlCommand object and retrieve the student's username from the SqlDataReader object.
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            stuUsername = reader["username"].ToString();

            // Close the database connection and dispose of the SqlCommand and SqlDataReader objects.
            con.Close();

            // Create a new Recep object and call the GenerateReceipt method to generate the receipt and update the database.
            Recep rcp = new Recep(payAmount, paymentMethod, date, acceptStatus, stuUsername);
            rcp.GenerateReceipt();

            // Create a new instance of the frmPayment3 form and pass in the necessary information.
            frmPayment3 receipt = new frmPayment3(un, studentName, studentId, subjectId1, subjectId2, subjectId3, paymentMethod, payAmount);

            // Show the frmPayment3 form and close this form.
            receipt.Show();
            this.Close();
        }

        // This method is called when the pictureHome picture box is clicked.
        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmPayment1 back = new frmPayment1(un);
            back.Show();
            this.Hide();
        }
    }
}
