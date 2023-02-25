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

        public frmUpdateRcp(string un)
        {
            InitializeComponent();
            this.un = un;
            Recep rcp = new Recep();
            string[] recepData = rcp.getRecepData(un); // call the method and store the returned value in a variable

            lblRcpIDS.Text = recepData[0].ToString();
            lblRcpNameS.Text = recepData[1].ToString();
            lblRcpICS.Text = recepData[2].ToString();
        }

        // Method to return to the main receptionist menu
        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }

        // Method to update the receptionist's information in the database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Initialize variables to store the current phone, address, email, and receptionist ID
            int recepId = 0;
            string currentPhone = "";
            string currentAddress = "";
            string currentEmail = "";

            // Connect to the database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            // Validate that at least one textbox is filled with data
            if (string.IsNullOrEmpty(txtContact.Text.Trim()) &&
                string.IsNullOrEmpty(txtAdress.Text.Trim()) &&
                string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please at least update one info");
                return;
            }

            // Retrieve the current receptionist information from the database based on the logged in user
            SqlCommand cmd = new SqlCommand("SELECT r.recepPhone, r.recepAddress, r.recepEmail, u.usersId " +
                                            "FROM receptionist r INNER JOIN users u ON r.usersId = u.usersId " +
                                            "WHERE u.username = @un", con);
            cmd.Parameters.AddWithValue("@un", un);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Store the current phone, address, and email in variables
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
