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

namespace Tuition_Centre.Admin
{
    public partial class FrmAdminUpdateProfile : Form
    {
        //Property
        private int userId;
        private string username;

        public FrmAdminUpdateProfile(string un)
        {
            InitializeComponent();
            //Assign property a value passed in from another form
            username = un;
            //Establish a new Connection to the database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            //Open the database
            con.Open();
            //Reads the database and select desired values
            SqlCommand cmdGetUsers = new SqlCommand("SELECT users.usersId, users.username, users.password, admin.adminEmail, admin.adminPhone, admin.adminAddress FROM admin INNER JOIN users ON admin.usersId = users.usersId WHERE username = @un", con);
            //Assign a value into the query
            cmdGetUsers.Parameters.AddWithValue("@un", username);
            //Reads the database
            SqlDataReader reader = cmdGetUsers.ExecuteReader();

            //If the programe reads something
            if (reader.Read())
            {
                //Assign value from database into these properties
                userId              = reader.GetInt32(0);
                txtbUsername.Text   = reader.GetString(1);
                txtbPassword.Text   = reader.GetString(2);
                txtbEmail.Text      = reader.GetString(3);
                txtbPhone.Text      = reader.GetString(4);
                txtbAddress.Text    = reader.GetString(5);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Checks if the textbox are empty or not
            if (!string.IsNullOrEmpty(txtbUsername.Text) || !string.IsNullOrEmpty(txtbPassword.Text) || !string.IsNullOrEmpty(txtbEmail.Text) ||
                !string.IsNullOrEmpty(txtbPhone.Text) || !string.IsNullOrEmpty(txtbAddress.Text))
            {
                MessageBox.Show("Information cannot be empty");
            }
            else
            {
                //Assign value into variables from text box
                string username = txtbUsername.Text;
                string password = txtbPassword.Text;
                string email = txtbEmail.Text;
                string phone = txtbPhone.Text;
                string address = txtbAddress.Text;
                //Create object with constructors and call a function while closing this form
                AdminClass update = new AdminClass(username, password, email, phone, address, userId);
                update.UpdateAdmin();
                this.Close();
            }
        }
    }
}
