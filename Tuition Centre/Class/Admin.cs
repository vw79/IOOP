using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuition_Centre.Admin;

namespace Tuition_Centre.Class
{
    internal class Admin
    {
        //write method here//
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

        public Admin(string name, string id, string phone, string email, string icpass, string address)
        {
            adminName = name;
            adminId = id;
            adminPhone = phone;
            adminEmail = email;
            adminICorPass = icpass;
            adminAddress = address;
        }
    }
}