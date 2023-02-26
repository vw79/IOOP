using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmPayment3 : Form
    {
        private string un;

        // This is the default constructor for the frmPayment3 class. It initializes the form components.
        public frmPayment3()
        {
            InitializeComponent();
        }

        // This constructor is used to pass the necessary information from the previous form to this form and display it.
        public frmPayment3(string un, string studentName, string studentId, string subjectId1, string subjectId2, string subjectId3, string paymentMethod, string payAmount)
        {
            // Initializes the form components.
            InitializeComponent();

            // Store the passed in username in the un variable.
            this.un = un;

            // Set the text of the lblStuNameS, lblStuIDS, lblPayS, and lblAmountS labels to the student's name, ID, payment method, and amount, respectively.
            lblStuNameS.Text = studentName;
            lblStuIDS.Text = studentId;
            lblPayS.Text = paymentMethod;
            lblAmountS.Text = payAmount;

            // Add the subject IDs to the ListBox if they are not null or empty.
            if (!string.IsNullOrEmpty(subjectId1))
            {
                lstSubject.Items.Add(subjectId1);
            }

            if (!string.IsNullOrEmpty(subjectId2))
            {
                lstSubject.Items.Add(subjectId2);
            }

            if (!string.IsNullOrEmpty(subjectId3))
            {
                lstSubject.Items.Add(subjectId3);
            }
        }

        // This method is called when the btnMainMenu button is clicked.
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // Create a new instance of the frmMainReceptionist form and pass in the current user's username.
            frmMainReceptionist rcpMain = new frmMainReceptionist(un);

            // Show the frmMainReceptionist form and hide this form.
            rcpMain.Show();
            this.Hide();
        }
    }
}
