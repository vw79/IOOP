﻿using System;
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

namespace Tuition_Centre.Class
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

        public string start(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //COLLATE Latin1_General_CS_AS rule is used to validate case-sensitive and accent-sensitive
            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@a COLLATE Latin1_General_CS_AS and password=@b COLLATE Latin1_General_CS_AS", con);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@b", password);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username=@a COLLATE Latin1_General_CS_AS and password=@b COLLATE Latin1_General_CS_AS", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@b", password);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole.Trim() == "admin")
                {
                    FrmMainAdmin a = new FrmMainAdmin(un);
                    Main.ActiveForm.Hide();
                    a.ShowDialog();

                }
                else if (userRole.Trim() == "receptionist")
                {
                    frmMainReceptionist b = new frmMainReceptionist(un);
                    Main.ActiveForm.Hide();
                    b.ShowDialog();

                }
                else if (userRole.Trim() == "student")
                {
                    frmMain_Student c = new frmMain_Student(un);
                    Main.ActiveForm.Hide();
                    c.ShowDialog();

                }
                else if (userRole.Trim() == "tutor")
                {
                    frmMainTutor d = new frmMainTutor(un);
                    Main.ActiveForm.Hide();
                    d.ShowDialog();

                }
            }
            else
                status = " Sorry! Incorrect username or password Please try again";
            con.Close();

            return status;
        }
    }
}
