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
    public partial class ViewProcess : Form
    {
        public ViewProcess(string un)
        {
            InitializeComponent();
            Name = un;
        }

        private void ViewProcess_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from changeSubject where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblOldSubject.Text = "            " + rd.GetString(5) + "            ";
                lblNewSubject.Text = "            " + rd.GetString(6) + "            ";

            }
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMain_Student obj1 = new frmMain_Student(Name);
            this.Hide();
            obj1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from changeSubject where username = @username", con);
            cmd.Parameters.AddWithValue("@username", Name);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = rd.GetString(2);
                if (label3.Text == "Pending")
                {
                    UnpendingRequest obj1 = new UnpendingRequest(Name);
                    this.Hide();
                    obj1.ShowDialog();
                }
                else if (label3.Text == "Completed")
                {
                    pendingRequest obj1 = new pendingRequest(Name);
                    this.Hide();
                    obj1.ShowDialog();
                    obj1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The Request was not Successfully Please try again");
                }

            }
        }
    }
}
