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
using static System.Net.Mime.MediaTypeNames;

namespace Tuition_Centre.Receptionist
{
    public partial class frmRegister2 : Form
    {
        private string stuUsername;

        public frmRegister2()
        {
            InitializeComponent();
        }

        public frmRegister2(string stuUsername)
        {
            InitializeComponent();
            this.stuUsername = stuUsername;
            grpCardInfo.Visible = false;
            // Attach the cmbPayment_SelectedIndexChanged method to the SelectedIndexChanged event of the cmbPayment ComboBox
            cmbPayment.SelectedIndexChanged += cmbPayment_SelectedIndexChanged;
            cmbLevel.SelectedIndex = 0;
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedItem.ToString() == "Cash")
            {
                // If the user selects "credit card", show the panel
                grpCardInfo.Visible = false;
            }
            else
            {
                // If the user selects any other payment method, hide the panel
                grpCardInfo.Visible = true;
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedIndex == 0)
            {
                txtCardNum.Text = "-";
                txtCVV.Text = "-";
            }

            Recep rcp = new Recep(stuUsername, cmbSubject1.Text, cmbSubject2.Text, cmbSubject3.Text, cmbLevel.Text, dtpEnrollDate.Text, cmbPayment.Text, txtCardNum.Text, txtCVV.Text);
            rcp.addSubjectPay();

            MessageBox.Show("haha");
        }




    }
}
