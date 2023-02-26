using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateStu : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string un;
        private string searchName;
        private string stuId;
        private string stuName;

        private Form activeForm;

        public frmUpdateStu()
        {
            InitializeComponent();
        }

        public frmUpdateStu(string un)
        {
            InitializeComponent();
            this.un = un;
        }

        private void openChildForm(Form childForm, Panel parentPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(childForm);
            parentPanel.Tag = childForm;
            childForm.Show();
        }

        private void btnStuSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStuSearch(), panel3);
            btnStuSearch.Enabled = false;
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = true;
        }

        private void btnUpSub_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu1(), panel3);
            btnStuSearch.Enabled = true;
            btnUpSub.Enabled = false;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = true;
        }

        private void btnUpPay_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu2(), panel3);
            btnStuSearch.Enabled = true;
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = false;
            btnDeleteStu.Enabled = true;
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu3(), panel3);
            btnStuSearch.Enabled = true;
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = false;
        }


    }
}
