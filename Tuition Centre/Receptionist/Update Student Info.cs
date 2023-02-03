using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateStu : Form
    {
        private Button currentButton;
        private Form activeForm;
        
        public frmUpdateStu()
        {
            InitializeComponent();
        }

        private void openChildForm (Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm= childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.Show();
        }

        private void btnUpSub_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu1(),sender);
        }

        private void btnUpPay_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu2(), sender);
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu3(), sender);
        }
    }
}
