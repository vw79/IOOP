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

namespace Tuition_Centre.Student
{
    public partial class EditProfile : Form
    {

        public EditProfile()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMain_Student obj1 = new frmMain_Student();
            this.Hide();
            obj1.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            student obj1 = new student(Name);
            MessageBox.Show(obj1.EditProfile(txtPassport.Text, dateBrithday.Text, txtPhoneNumber.Text, txtEmail.Text, txtmemo.Text));

        }

        
    }
}
