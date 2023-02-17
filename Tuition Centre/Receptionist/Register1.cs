using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuition_Centre.Receptionist
{
    public partial class frmRegister1 : Form
    {
        public frmRegister1()
        {
            InitializeComponent();
        }

        List<string> selectedItems = new List<string>();
        private string sN;

        private void cmbStuSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            string selectedItem = cmbStuSub1.SelectedItem.ToString();

            // Check if the item has already been selected
            if (selectedItems.Contains(selectedItem))
            {
                MessageBox.Show("You have already selected this item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStuSub1.SelectedIndex = -1;
                return;
            }

            // Add the item to the selected items list
            selectedItems.Add(selectedItem);

            // Update the other ComboBox controls
            UpdateComboBoxes();
        }

        // Handle the SelectedIndexChanged event of the second ComboBox control
        private void cmbStuSub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            string selectedItem = cmbStuSub2.SelectedItem.ToString();

            // Check if the item has already been selected
            if (selectedItems.Contains(selectedItem))
            {
                MessageBox.Show("You have already selected this item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStuSub2.SelectedIndex = -1;
                return;
            }

            // Add the item to the selected items list
            selectedItems.Add(selectedItem);

            // Update the other ComboBox controls
            UpdateComboBoxes();
        }

        // Handle the SelectedIndexChanged event of the third ComboBox control
        private void cmbStuSub3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            string selectedItem = cmbStuSub3.SelectedItem.ToString();

            // Check if the item has already been selected
            if (selectedItems.Contains(selectedItem))
            {
                MessageBox.Show("You have already selected this item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStuSub3.SelectedIndex = -1;
                return;
            }

            // Add the item to the selected items list
            selectedItems.Add(selectedItem);

            // Update the other ComboBox controls
            UpdateComboBoxes();
        }

        // Update the ComboBox controls
        private void UpdateComboBoxes()
        {
            // Create a list of available items
            List<string> availableItems = new List<string>();
            availableItems.Add("IOOP");
            availableItems.Add("CGDD");
            availableItems.Add("IS3DA");
            availableItems.Add("FIS");
            availableItems.Add("MCFC");
            availableItems.Add("SAAD");

            // Remove the selected items from the available items list
            foreach (string item in selectedItems)
            {
                availableItems.Remove(item);
            }

            // Update the Items collection of each ComboBox control
            cmbStuSub1.Items.Clear();
            cmbStuSub2.Items.Clear();
            cmbStuSub3.Items.Clear();

            foreach (string item in availableItems)
            {
                cmbStuSub1.Items.Add(item);
                cmbStuSub2.Items.Add(item);
                cmbStuSub3.Items.Add(item);
            }
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedItem.ToString() == "Credit Card")
            {
                // If the user selects "credit card", show the panel
                grpBox1.Visible = true;
            }
            else
            {
                // If the user selects any other payment method, hide the panel
                grpBox1.Visible = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //receptionist reg = new receptionist(string sN, string sIC, string sE, string sC, string sA, string sMOE, string sLV);
            //reg.Register();
=======
            string sN = txtStuName.Text;
            string sIC = txtStuIC.Text;
            string sE = txtStuEmail.Text;
            string sC = txtStuNo.Text;
            string sA = txtStuAdress.Text;
            string sMOE = cmbStuMthEnroll.Text;
            string sLV = cmbStuLv.Text;
            string sSub = cmbStuSub1.Text + cmbStuSub2.Text + cmbStuSub3.Text;

            Recep reg = new Recep(sN, sIC, sE, sC, sA, sMOE, sLV, sSub);
            reg.Register(sN, sIC, sE, sC, sA, sMOE, sLV, sSub);
>>>>>>> b210ce48ed86a5556db0a399a06686b3eeedd36e

        }
    }
}
