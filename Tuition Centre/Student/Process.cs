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
    public partial class Process : Form
    {
        public Process(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMain_Student obj1 = new frmMain_Student(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UnpendingRequest obj1 = new UnpendingRequest();
            this.Close();
            obj1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pendingRequest obj1 = new pendingRequest();
            this.Close();
            obj1.ShowDialog();
        }

        private void Process_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from changeSubject where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblOldSubject.Text = rd.GetString(5);
                lblNewSubject.Text = rd.GetString(6);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private void lblOldSubject_Click(object sender, EventArgs e)
        {

        }
    }
}
