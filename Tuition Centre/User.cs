using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Tuition_Centre.Admin;
using Tuition_Centre.Receptionist;
using Tuition_Centre.Student;
using Tuition_Centre.Tutor;

namespace Tuition_Centre
{
    class User
    {
        private string username;
        private string password;

        public User(string u, string p)

        {
            username = u;
            password = p;
        }

        public string Main(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //Sqlcommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@a and password=@b", con);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username=@a and password=@b", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@b", password);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole.Trim() == "admin")
                {
                    FrmMainAdmin a = new frmMainAdmin(un);
                    a.ShowDialog();

                }
                if (userRole.Trim() == "receptionist")
                {
                    frmMainReceptionist b = new frmMainReceptionist(un);
                    b.ShowDialog();

                }
                if (userRole.Trim() == "student")
                {
                    frmMain_Student c = new frmMain_Student(un);
                    c.ShowDialog();

                }
                else if (userRole.Trim() == "tutor")
                {
                    frmMainTutor d = new frmMainTutor(un);
                    d.ShowDialog();

                }
            }
            else
                status = " Sorry! Incorrect username or password Please try again";
            con.Close();

            return status;
        }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }

    internal class frmMainAdmin : FrmMainAdmin
    {
        private string un;

        public frmMainAdmin(string un)
        {
            this.un = un;
        }
    }
}
