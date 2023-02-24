using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuition_Centre.Admin;

namespace Tuition_Centre.Class
{
    internal class AdminClass
    {
        //write method here//
        private string tutorId;
        private string adminName;
        private string adminId;
        private string adminPhone;
        private string adminEmail;
        private string adminICorPass;
        private string adminAddress;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string AdminPhone { get => adminPhone; set => adminPhone = value; }
        public string AdminEmail { get => adminEmail; set => adminEmail = value; }
        public string AdminAddress { get => adminAddress; set => adminAddress = value; }

        public AdminClass()
        {

        }

        public AdminClass(string name, string id, string phone, string email, string icpass, string address)
        {
            adminName = name;
            adminId = id;
            adminPhone = phone;
            adminEmail = email;
            adminICorPass = icpass;
            adminAddress = address;
        }

        public AdminClass( string id)
        {
            tutorId = id;
        }

        public string NameDisplay(string un)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT admin.adminName FROM admin INNER JOIN users ON users.usersId = admin.usersId WHERE users.username = @un", con);
            cmd.Parameters.AddWithValue("@un", un);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                adminName = reader.GetString(0);
            }

            con.Close();
            return adminName;
        }

        public string IdentityDisplay(string un)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT admin.adminId FROM admin INNER JOIN users ON users.usersId = admin.usersId WHERE users.username = @un", con);
            cmd.Parameters.AddWithValue("@un", un);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                adminId = reader.GetString(0);
            }
            con.Close();
            return adminId;
        }

        public DataTable ViewTutorList()
        { 
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT tutorFullName, tutorId, tutorICorPass, tutorEmail, tutorPhone, tutorDOB, tutorAddress, subject, level FROM tutor", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable ViewReceptionistList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT recepId, recepName, recepIcP, recepEmail, recepPhone, recepAddress FROM receptionist", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public void DeleteUser(string identity, string table , string idType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"DELETE FROM {table} WHERE {idType} = @identity", con);
            cmd.Parameters.AddWithValue("@identity", identity);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /*public void DeleteReceptionist(identity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM receptionist WHERE recepId = @identity", con);
            cmd.Parameters.AddWithValue("@identity", identity);
            cmd.ExecuteNonQuery();
            MessageBox.Show("this ran");
            con.Close();
        }*/
    }
}