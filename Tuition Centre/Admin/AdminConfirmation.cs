using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Admin
{
    public partial class FrmConfirm : Form
    {

        //Property while allowing this property to be accessed ooutside
        public bool confirmation{ get; set; }

        public FrmConfirm()
        {
            InitializeComponent();
        }

        //Declares the property as true and closing the form
        private void btnYes_Click(object sender, EventArgs e)
        {
            confirmation = true;
            this.Close();
        }

        //Declares the property as false and closing the form
        private void btnNo_Click(object sender, EventArgs e)
        {
            confirmation = false;
            this.Close();
        }
    }
}
