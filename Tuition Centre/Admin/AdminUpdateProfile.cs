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
        private int userId;
        private string username;
        public FrmAdminUpdateProfile(string un)
        {
            InitializeComponent();
            username = un;
            MessageBox.Show(username);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdGetUsers = new SqlCommand("SELECT users.usersId, users.username, users.password, admin.adminEmail, admin.adminPhone, admin.adminAddress FROM admin INNER JOIN users ON admin.usersId = users.usersId WHERE username = @un", con);
            cmdGetUsers.Parameters.AddWithValue("@un", username);
            SqlDataReader reader = cmdGetUsers.ExecuteReader();

            if (reader.Read())
            {
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
            if (!string.IsNullOrEmpty(txtbUsername.Text) || !string.IsNullOrEmpty(txtbPassword.Text) || !string.IsNullOrEmpty(txtbEmail.Text) ||
                !string.IsNullOrEmpty(txtbPhone.Text) || !string.IsNullOrEmpty(txtbAddress.Text))
            {
                MessageBox.Show("Information cannot be empty");
            }
            else
            {
                string username = txtbUsername.Text;
                string password = txtbPassword.Text;
                string email = txtbEmail.Text;
                string phone = txtbPhone.Text;
                string address = txtbAddress.Text;
                AdminClass update = new AdminClass(username, password, email, phone, address, userId);
                update.UpdateAdmin();
                this.Close();
            }
        }
    }
}
