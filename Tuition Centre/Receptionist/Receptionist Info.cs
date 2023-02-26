using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateRcp : Form
    {
        private string un;

        public frmUpdateRcp()
        {
            InitializeComponent();
        }

        // This constructor is used to pass the necessary information from the previous form to this form and display it.
        public frmUpdateRcp(string un)
        {
            // Initializes the form components.
            InitializeComponent();

            // Store the passed in username in the un variable.
            this.un = un;

            // Create a new instance of the Recep class and call the getRecepData method to retrieve the current receptionist's information.
            Recep rcp = new Recep();
            string[] recepData = rcp.getRecepData(un);

            // Set the text of the lblRcpIDS, lblRcpNameS, and lblRcpICS labels to the receptionist's ID, name, and IC number, respectively.
            lblRcpIDS.Text = recepData[0].ToString();
            lblRcpNameS.Text = recepData[1].ToString();
            lblRcpICS.Text = recepData[2].ToString();
        }

        // This method is called when the pictureHome picture box is clicked. It returns the user to the main receptionist menu.
        private void pictureHome_Click(object sender, EventArgs e)
        {
            // Create a new instance of the frmMainReceptionist form and pass in the current user's username.
            frmMainReceptionist back = new frmMainReceptionist(un);

            // Show the frmMainReceptionist form and hide this form.
            back.Show();
            this.Hide();
        }

        // This method is called when the btnUpdate button is clicked. It updates the receptionist's information in the database.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Initialize variables to store the current phone, address, email, and receptionist ID.
            int recepId = 0;
            string currentPhone = "";
            string currentAddress = "";
            string currentEmail = "";

            // Validate the contact field to ensure it only contains numbers.
            if (!decimal.TryParse(txtContact.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount. Please enter a numeric value.");
                return; // Stop the method from continuing.
            }

            // Connect to the database.
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            // Validate that at least one textbox is filled with data.
            if (string.IsNullOrEmpty(txtContact.Text.Trim()) &&
                string.IsNullOrEmpty(txtAdress.Text.Trim()) &&
                string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please at least update one info");
                return;
            }

            // Retrieve the current receptionist information from the database based on the logged in user.
            SqlCommand cmd = new SqlCommand("SELECT r.recepPhone, r.recepAddress, r.recepEmail, u.usersId " +
                                            "FROM receptionist r INNER JOIN users u ON r.usersId = u.usersId " +
                                            "WHERE u.username = @un", con);
            cmd.Parameters.AddWithValue("@un", un);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Store the current phone, address, and email in variables.
                if (!reader.IsDBNull(0))
                {
                    currentPhone = reader.GetString(0);
                }
                if (!reader.IsDBNull(1))
                {
                    currentAddress = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    currentEmail = reader.GetString(2);
                }
                recepId = reader.GetInt32(3);
            }
            reader.Close();
            con.Close();

            // Use current values for address and email if no new values are entered
            string newPhone = !string.IsNullOrEmpty(txtContact.Text.Trim()) ? txtContact.Text.Trim() : currentPhone;
            string newAddress = !string.IsNullOrEmpty(txtAdress.Text.Trim()) ? txtAdress.Text.Trim() : currentAddress;
            string newEmail = !string.IsNullOrEmpty(txtEmail.Text.Trim()) ? txtEmail.Text.Trim() : currentEmail;

            // Create a new Recep object with the updated information and update the database
            Recep rcpt = new Recep(newPhone, newAddress, newEmail, recepId);
            rcpt.UpdateRecepInfo();
            MessageBox.Show("Receptionist Info Updated");

            // Show the main receptionist menu and hide the current form
            frmMainReceptionist mainMenu = new frmMainReceptionist(un);
            mainMenu.Show();
            this.Hide();
        }
    }
}
