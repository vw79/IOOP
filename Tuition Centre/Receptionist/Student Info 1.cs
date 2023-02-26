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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateStu1 : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmUpdateStu1()
        {
            InitializeComponent();
        }
        public frmUpdateStu1(string un)
        {
            InitializeComponent();
            

            if (!string.IsNullOrEmpty(subjectId1))
            {
                lstSubject.Items.Add(subjectId1);
            }

            if (!string.IsNullOrEmpty(subjectId2))
            {
                lstSubject.Items.Add(subjectId2);
            }

            if (!string.IsNullOrEmpty(subjectId3))
            {
                lstSubject.Items.Add(subjectId3);
            }
        }

    }
}
