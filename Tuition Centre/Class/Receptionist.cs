using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tuition_Centre.Class
{
    internal class Recep
    {
        //Properties
        private string un;
        private string stuUsername;
        private string stuPw;
        private string role;

        private int stuDbId;
        private string stuLv;
        private string stuId;
        private string stuName;
        private string stuIcP;
        private string stuEmail;
        private string stuPhone;
        private string stuAddress;
        private string stuEnrollDate;
        private string birthday;
        private string studyCourse;
        private string memo;

        private string subId1;
        private string subId2;
        private string subId3;

        private string payMethod;
        private string cardNumber;
        private string CVV;

        private string searchName;

        private int recepId;
        private string rcpPhone;
        private string rcpAddress;
        private string rcpEmail;


        public string SearchName { get => searchName; set => searchName = value; }

        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Constructor Overloading
        public Recep()
        {

        }

        public Recep(string un) 
        { 
            this.un = un;
        }

        public Recep(string stuLv, string stuUsername, string stuPw, string role, string stuId, string stuName, string stuIcP, string stuEmail, string stuPhone, string stuAddress, string stuEnrollDate, string birthday, string studyCourse, string memo)
        {
            this.stuLv = stuLv;
            this.stuUsername = stuUsername;
            this.stuPw = stuPw;
            this.role = role;
            this.stuId = stuId;
            this.stuName = stuName;
            this.stuIcP = stuIcP;
            this.stuEmail = stuEmail;
            this.stuPhone = stuPhone;
            this.stuAddress = stuAddress;
            this.stuEnrollDate = stuEnrollDate;
            this.birthday = birthday;
            this.studyCourse = studyCourse;
            this.memo = memo;
        }

        public Recep(string username, string subId1, string subId2, string subId3, string stuLv, string stuEnrollDate, string payMethod, string cardNum, string cvv, string stuName, int stuDbId)
        {
            this.stuUsername = username;
            this.subId1 = subId1;
            this.subId2 = subId2;
            this.subId3 = subId3;
            this.stuLv = stuLv;
            this.stuEnrollDate = stuEnrollDate;
            this.payMethod = payMethod;
            this.cardNumber = cardNum;
            this.CVV = cvv;
            this.stuName = stuName;
            this.stuDbId = stuDbId;
        }

        public Recep(string rcpPhone, string rcpAddress, string rcpEmail, int recepId)
        {
            this.rcpPhone = rcpPhone;
            this.rcpAddress = rcpAddress;
            this.rcpEmail = rcpEmail;
            this.recepId = recepId;
        }

        // Method getting receptionist name from database and return as string

        public string[] getRecepData(string un)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT r.recepId, r.recepName, r.recepIcP FROM receptionist r " +
                                            "INNER JOIN users u ON u.usersId = r.usersId WHERE u.username = @un", con);
            cmd.Parameters.AddWithValue("@un", un);
            SqlDataReader reader = cmd.ExecuteReader();

            string[] recepData = new string[3];

            reader.Read();
            recepData[0] = reader.GetString(0);
            recepData[1] = reader.GetString(1);
            recepData[2] = reader.GetString(2);

            con.Close();
            
            return recepData;

        }

        // Method to Register into users, studentInfo database 
        public void addStudent()
        {
            con.Open();

            // Insert the value of username, password, role to the users database
            SqlCommand cmdUsers = new SqlCommand("INSERT INTO users (username, password, role) " +
                                                 "VALUES (@username, @password, @role)", con);
            cmdUsers.Parameters.AddWithValue("@username", stuUsername);
            cmdUsers.Parameters.AddWithValue("@password", stuPw);
            cmdUsers.Parameters.AddWithValue("@role", role);
            cmdUsers.ExecuteNonQuery();

            // Insert student's information to the studentInfo database
            SqlCommand cmdStuInfo = new SqlCommand("INSERT INTO studentInfo (level, username, studentId, studentName, studentPass, studentEmail, studentPhone, studentAddress, studentEnrollmentDate, birthday, studyCourse, memo) " +
                                                   "VALUES (@stuLv, @stuUsername, @stuId, @stuName, @stuIcP, @stuEmail, @stuPhone, @stuAddress, @stuEnrollDate, @birthday, @studyCourse, @memo)", con);
            cmdStuInfo.Parameters.AddWithValue("@stuLv", stuLv);
            cmdStuInfo.Parameters.AddWithValue("@stuUsername", stuUsername);
            cmdStuInfo.Parameters.AddWithValue("@stuId", stuId);
            cmdStuInfo.Parameters.AddWithValue("@stuName", stuName);
            cmdStuInfo.Parameters.AddWithValue("@stuIcP", stuIcP);
            cmdStuInfo.Parameters.AddWithValue("@stuEmail", stuEmail);
            cmdStuInfo.Parameters.AddWithValue("@stuPhone", stuPhone);
            cmdStuInfo.Parameters.AddWithValue("@stuAddress", stuAddress);
            cmdStuInfo.Parameters.AddWithValue("@stuEnrollDate", stuEnrollDate);
            cmdStuInfo.Parameters.AddWithValue("@studyCourse", studyCourse);
            cmdStuInfo.Parameters.AddWithValue("@memo", memo);
            cmdStuInfo.Parameters.AddWithValue("@birthday", birthday);
            cmdStuInfo.ExecuteNonQuery();

            con.Close();
        }

        // Method to Register into studentSubject, paymentInfo
        public void addSubjectPay()
        {
            con.Open();

            // Insert the value of username, subject1, subject2,subject3 to the studentSSubject database
            SqlCommand cmdstuSub = new SqlCommand("INSERT INTO studentSubject (username, subjectId1, subjectId2, subjectId3, fullName, studentDatabaseId) " +
                                                  "SELECT s.username, @subId1, @subId2, @subId3, s.studentName, s.studentDatabaseld " +
                                                  "FROM studentInfo s " +
                                                  "WHERE s.username = @username", con);
            cmdstuSub.Parameters.AddWithValue("@username", stuUsername);
            cmdstuSub.Parameters.AddWithValue("@subId1", subId1);
            cmdstuSub.Parameters.AddWithValue("@subId2", subId2);
            cmdstuSub.Parameters.AddWithValue("@subId3", subId3);
            cmdstuSub.ExecuteNonQuery();

            // Update the value of level, studentEnrollmentDate in the studentInfo database
            SqlCommand cmdStuInfo = new SqlCommand("UPDATE studentInfo SET level=@stulv, studentEnrollmentDate=@stuEnrollDate " +
                                                   "WHERE username=@un", con);
            cmdStuInfo.Parameters.AddWithValue("@stulv", stuLv);
            cmdStuInfo.Parameters.AddWithValue("@stuEnrollDate", stuEnrollDate);
            cmdStuInfo.Parameters.AddWithValue("@un", stuUsername);
            cmdStuInfo.ExecuteNonQuery();

            // Insert the value of studentDatabaseId, paymentMethod, cardNumber,CVV to the paymentInfo database
            SqlCommand cmdStuPayInfo = new SqlCommand("INSERT INTO paymentInfo (studentDatabaseId, paymentMethod, cardNumber, CVV) " +
                                                  "SELECT s.studentDatabaseld, @payMethod, @cardNum, @cvv " +
                                                  "FROM studentInfo s " +
                                                  "LEFT JOIN paymentInfo p ON s.studentDatabaseld = p.studentDatabaseId " +
                                                  "WHERE s.username = @un", con);

            cmdStuPayInfo.Parameters.AddWithValue("@payMethod", payMethod);
            cmdStuPayInfo.Parameters.AddWithValue("@cardNum", cardNumber);
            cmdStuPayInfo.Parameters.AddWithValue("@cvv", CVV);
            cmdStuPayInfo.Parameters.AddWithValue("@un", stuUsername);
            cmdStuPayInfo.ExecuteNonQuery();

            con.Close();
        }

        // Method to search for a student in the database and return the results as a DataTable
        public DataTable SearchStu(string searchName)
        {
            // Create a new SqlConnection object with the connection string
            con.Open();

            // Create a new SqlCommand object with a SELECT statement to search for the student
            // The search term is passed as a parameter to prevent SQL injection attacks
            SqlCommand cmd = new SqlCommand("SELECT studentId, studentName, studentEnrollmentDate, studyCourse FROM studentInfo WHERE studentName LIKE @searchName", con);
            cmd.Parameters.AddWithValue("searchName", "%" + searchName + "%");

            // Create a new SqlDataAdapter object with the SqlCommand object as a parameter
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            // Create a new DataTable object to hold the search results
            DataTable dt = new DataTable();

            // Fill the DataTable with the search results using the SqlDataAdapter
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                con.Close();
                return null;
            }

            con.Close() ;
            // Return the DataTable
            return dt;
        }



        /*
        public void UpdateStuSubject(Receptionist)
        {

        }

        public void UpdateStuPayment(Receptionist)
        {

        }
        */

        public string deleteStudent()
        {
            string status;
            string searchName = null;
            int stuDbId = 0;

            con.Open();
            
            // Delete the student's subjects first
            SqlCommand cmdDeleteStudentSubjects = new SqlCommand("DELETE FROM studentSubject WHERE studentDatabaseId = (SELECT studentDatabaseId FROM studentInfo WHERE studentName = @studentName)", con);
            cmdDeleteStudentSubjects.Parameters.AddWithValue("@studentName", searchName);
            cmdDeleteStudentSubjects.Parameters.AddWithValue("@stuDbId", stuDbId);
            cmdDeleteStudentSubjects.ExecuteNonQuery();

            // Delete the student's user account next
            SqlCommand cmdDeleteStudentUser = new SqlCommand("DELETE FROM users WHERE username = @studentName", con);
            cmdDeleteStudentUser.Parameters.AddWithValue("@studentName", searchName);
            cmdDeleteStudentUser.ExecuteNonQuery();

            // Delete the student's information last
            string deleteStudentInfoQuery = "DELETE FROM studentInfo WHERE studentName = @studentName";
            SqlCommand cmdDeleteStudentInfo = new SqlCommand(deleteStudentInfoQuery, con);
            cmdDeleteStudentInfo.Parameters.AddWithValue("@studentName", searchName);
            cmdDeleteStudentInfo.ExecuteNonQuery();

            status = "Student information has been deleted successfully.";
            return status;
        }

        public void UpdateRecepInfo()
        {
            con.Open();

            SqlCommand cmdRecepInfo = new SqlCommand("UPDATE receptionist SET recepPhone = @rcpPhone, recepAddress = @rcpAddress, recepEmail = @rcpEmail WHERE usersId = @recepId", con);
            cmdRecepInfo.Parameters.AddWithValue("@rcpPhone", rcpPhone);
            cmdRecepInfo.Parameters.AddWithValue("@rcpAddress", rcpAddress);
            cmdRecepInfo.Parameters.AddWithValue("@rcpEmail", rcpEmail);
            cmdRecepInfo.Parameters.AddWithValue("@recepId", recepId);
            cmdRecepInfo.ExecuteNonQuery();

            con.Close();
        }
        /*
            public void GenerateReceipt(Receptionist)
            {

            }

        }*/
    }
}
