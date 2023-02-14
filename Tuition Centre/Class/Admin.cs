using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Centre.Class
{
    internal class Admin
    {
        //write method here//
        private string name;
        private string id;
        private string phone;
        private string email;
        private string subject;
        private string level;

        public Admin(string tutorName, string tutorId, string tutorPhone, string tutorEmail, string tutorSubject, string tutorLevel)
        {
            name = tutorName;
            id = tutorId;
            phone = tutorPhone;
            email = tutorEmail;
            subject = tutorSubject;
            level = tutorLevel;
        }
    }
}
