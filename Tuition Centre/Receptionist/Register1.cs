using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tuition_Centre.Receptionist
{
    public partial class frmRegister1 : Form
    {
        private string un;
        public frmRegister1()
        {
            InitializeComponent();
        }
        public frmRegister1(string un)
        {
            InitializeComponent();
            this.un = un;
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }
        /*
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

private void ClearAllFields()
{
// Clear all text boxes
txtUsername.Text = "";
txtPw.Text = "";
txtStuId.Text = "";
txtStuName.Text = "";
txtStuIC.Text = "";
txtStuEmail.Text = "";
txtStuNo.Text = "";
txtStuAddress.Text = "";
dtpBirthday.Text = "";
txtCourse.Text = "";
txtMemo.Text = "";

// Clear all combo boxes
cmbStuLv.SelectedIndex = -1;
cmbPayment.SelectedIndex = -1;
cmbStuSub1.SelectedIndex = -1;
cmbStuSub2.SelectedIndex = -1;
cmbStuSub3.SelectedIndex = -1;

// Set focus to the first text box
txtUsername.Focus();
}
*/




        private void btnNext_Click(object sender, EventArgs e)
        {

            string stuLv = "lv";
            string role = "student";
            string stuEnrollDate = "today";

            Recep rcp = new Recep(stuLv, txtUsername.Text, txtPw.Text, role, txtStuId.Text, txtStuName.Text, txtStuIcP.Text, txtStuEmail.Text, txtStuPhone.Text, txtStuAddress.Text, stuEnrollDate, dtpBirthday.Text, txtCourse.Text, txtMemo.Text);

            rcp.addStudent();
                
                
            frmRegister2 regNext = new frmRegister2();
            regNext.Show();
            this.Hide();  

            // ClearAllFields();
            // MessageBox.Show(rcp.addStudent());
        }


    }
}