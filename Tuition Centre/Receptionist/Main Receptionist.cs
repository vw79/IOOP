using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmMainReceptionist : Form
    {
        //Properties
        private string un;
        private string stuName;

        // Default constructor
        public frmMainReceptionist()
        {
        }

        // Parameterized constructor that takes in the username as an argument
        public frmMainReceptionist(string un)
        {
            // Initialize the form components and set the username to the argument value
            InitializeComponent();
            this.un = un;

            // Call the getRecepData method of the Recep class to retrieve the receptionist data
            Recep rcp = new Recep();
            string[] recepData = rcp.getRecepData(un); // call the method and store the returned value in a variable

            // Set the welcome label text using the receptionist name
            lblWlcRcp.Text = "Welcome Back, " + recepData[1].ToString();
        }

        // Button click event handler to navigate to the register student form
        private void btnRegNewStu_Click(object sender, EventArgs e)
        {
            frmRegister1 register1 = new frmRegister1(un);
            register1.Show();
            this.Hide();
        }

        // Button click event handler to navigate to the update receptionist info form
        private void btnUpdateRcpInfo_Click(object sender, EventArgs e)
        {
            frmUpdateRcp updateRcp = new frmUpdateRcp(un);
            updateRcp.Show();
            this.Hide();
        }

        // Button click event handler to navigate to the update student info form
        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            frmUpdateStu studentInfoPage1 = new frmUpdateStu(un);
            studentInfoPage1.Show();
            this.Hide();
        }

        // Button click event handler to navigate to the payment form
        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment1 paymentPage1 = new frmPayment1(un);
            paymentPage1.Show();
            this.Hide();
        }

        // Click event handler for the logout button
        private void picLogout_Click(object sender, EventArgs e)
        {
            // Show the main login form and hide the current form
            Main logOut = new Main();
            logOut.Show();
            this.Hide();
            MessageBox.Show("Logout");
        }
    }
}
