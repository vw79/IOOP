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
        private string un;  // The username of the currently logged in receptionist

        public frmUpdateStu()
        {
            InitializeComponent();
        }

        public frmUpdateStu(string un)
        {
            InitializeComponent();
            this.un = un;
        }

        private void btnUpSub_Click(object sender, EventArgs e)
        {
            frmChangeSub changeSub = new frmChangeSub(un);
            changeSub.Show();
            this.Hide();
        }

        private void btnUpPay_Click(object sender, EventArgs e)
        {
            frmSearchPay upPay = new frmSearchPay(un);
            upPay.Show();
            this.Hide();
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            frmSearchDelete deleteStu = new frmSearchDelete(un);
            deleteStu.Show();   
            this.Hide();
        }

        // This method is called when the pictureHome picture box is clicked.
        private void pictureHome_Click(object sender, EventArgs e)
        {
            // Create a new instance of the frmMainReceptionist form and pass in the current user's username.
            frmMainReceptionist back = new frmMainReceptionist(un);

            // Show the frmMainReceptionist form and hide this form.
            back.Show();
            this.Hide();
        }        
    }
}
