using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tuition_Centre.Student;

namespace Tuition_Centre
{
    internal class student
    {
        private string stuname;
        private string passNum;
        private string birthday;
        private string phoneNum;
        private string email;
        private string studentNum;
        private string studyCourse;
        private string memo;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string PassNum { get => passNum; set => passNum = value; }
        public string Birthday { get => birthday;set => birthday = value; }
        public string PhoneNum { get => phoneNum;set => phoneNum = value; }
        public string Email { get => email;set => email = value; }
        public string StudentNum { get => studentNum;set => studentNum = value; }
        public string StudyCourse { get => studyCourse;set => studyCourse = value; }
        public string Memo { get => memo;set => memo = value; }

        public student(string n, string p, string b, string ph, string e, string s, string c, string m)
        {
            stuname = n;
            passNum = p;
            birthday = b;
            phoneNum = ph;
            email = e;
            studentNum = s;
            studyCourse = c;
            memo = m;
        }

        public student(string n)
        {
            stuname= n;
        }

        public static void viewProfile(student o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where studentName = @a", con);
            cmd.Parameters.AddWithValue("@a", o1.stuname);
            SqlDataReader rd= cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.stuname= rd.GetString(1);
                o1.passNum= rd.GetString(2);
                o1.birthday= rd.GetString(3);
                o1.phoneNum= rd.GetString(4);
                o1.email= rd.GetString(5);
                o1.StudentNum= rd.GetString(6);
                o1.StudyCourse= rd.GetString(7);
                o1.memo= rd.GetString(8);
            }
            con.Close();
        }
        public string EditProfile( string p, string b, string ph, string e, string m)
        {
            string status;
            con.Open();

            passNum = p;
            birthday = b;
            phoneNum = ph;
            email = e;
            memo = m;

            SqlCommand cmd = new SqlCommand("update students set Passport = '" + passNum + " ',birthday = '" + birthday + " ',Phonenum = '" + phoneNum + " ',Email = '" + email + " ', Memo = '" + memo + " '", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update";
            con.Close();
            return status;
            

        }

        internal string EditProfile()
        {
            throw new NotImplementedException();
        }
    }

}
