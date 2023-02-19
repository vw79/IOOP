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

namespace Tuition_Centre.Student
{
    public partial class UnpendingRequest : Form
    {
        public UnpendingRequest(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMain_Student obj1 = new frmMain_Student(Name);
            this.Close();
            obj1.ShowDialog();
        }

        private void pictureBackward_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete changeSubject where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cancel Successfully");
            
        }
    }
}
