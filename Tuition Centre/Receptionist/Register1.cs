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
        public frmRegister1()
        {
            InitializeComponent();
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

private void btnRegister_Click(object sender, EventArgs e)
{
string role = "Student";

int levelId = cmbStuLv.SelectedIndex;
if (cmbStuLv.SelectedIndex == 1) 
{
levelId = 1;
}
else if (cmbStuLv.SelectedIndex == 2)
{ 
levelId = 2; 
}
else if (cmbStuLv.SelectedIndex == 3)
{
levelId = 3;
}
else if (cmbStuLv.SelectedIndex == 4)
{
levelId = 4;
}
else if (cmbStuLv.SelectedIndex == 5)
{
levelId = 5;
}

string subName1 = cmbStuSub1.Text;
string subName2 = cmbStuSub2.Text;
string subName3 = cmbStuSub3.Text;

Recep rcp = new Recep(txtUsername.Text, txtPw.Text, role, levelId, txtStuId.Text, txtStuName.Text, txtStuIC.Text, txtStuEmail.Text,txtStuNo.Text, txtStuAddress.Text, dtpEnrollDate.Text, dtpBirthday.Text, txtCourse.Text, txtMemo.Text, subName1, subName2, subName3);
ClearAllFields();
MessageBox.Show(rcp.addStudent());
}*/
    }
}
