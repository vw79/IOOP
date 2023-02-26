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
    public partial class Update_Payment : Form
    {
        private string un;
        private string stuName;
        private string paymentMethod;
        private string cardNumber;
        private string cvv;

        public Update_Payment()
        {
            InitializeComponent();
        }

        public Update_Payment(string un, string stuName, string studentId, string paymentMethod, string cardNumber, string CVV)
        {
            InitializeComponent();
            this.un = un;
            this.stuName = stuName;
            this.paymentMethod = paymentMethod;
            this.cardNumber = cardNumber;
            this.cvv = CVV;
            lblNameS.Text = stuName;
            lblIdS.Text = studentId;
            grpCardInfo.Visible = false;
            cmbPayment.SelectedIndexChanged += cmbPayment_SelectedIndexChanged;
        }

        // Disable the payment method combobox input
        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedItem.ToString() == "Cash")
            {
                // If the user selects "credit card", hide the panel
                grpCardInfo.Visible = false;
            }
            else
            {
                // If the user selects any other payment method, show the panel
                grpCardInfo.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCard.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount. Please enter a numeric value.");
                return; // Stop the method from continuing.
            }
            if (!decimal.TryParse(txtCVV.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount. Please enter a numeric value.");
                return; // Stop the method from continuing.
            }

            Recep rcp = new Recep(stuName, paymentMethod, cardNumber, cvv);
            rcp.UpdateStuPayment();

            MessageBox.Show("Payment Info Updated");
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmSearchPay back = new frmSearchPay(un);

            // Show the frmMainReceptionist form and hide this form.
            back.Show();
            this.Hide();
        }   
    }
}
