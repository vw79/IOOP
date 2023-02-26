using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Admin
{
    public partial class FrmAdminRegisterReceptionist : Form
    {
        public FrmAdminRegisterReceptionist()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Checks if the textbox are empty or not
            if (string.IsNullOrEmpty(txtbName.Text) || string.IsNullOrEmpty(txtbIcP.Text) || string.IsNullOrEmpty(txtbPhone.Text) || 
                string.IsNullOrEmpty(txtbEmail.Text) || string.IsNullOrEmpty(txtbAddress.Text) || string.IsNullOrEmpty(txtbUsername.Text) ||
                string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Please make sure all fields are filled");
            }
            else
            {
                //Read user input and assign value into the variables
                string name = txtbName.Text;
                string icP = txtbIcP.Text;
                string phone = txtbPhone.Text;
                string email = txtbEmail.Text;
                string address = txtbAddress.Text;
                string username = txtbUsername.Text;
                string password = txtbPassword.Text;

                //Calls object and method to create a new receptionist while closing this form
                AdminClass register = new AdminClass(name, icP, email, phone, address, username, password);
                register.RegisterReceptionist();
                this.Close();
                
            }
        }
    }
}
