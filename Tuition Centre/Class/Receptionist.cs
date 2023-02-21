using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tuition_Centre.Class
{
    internal class Recep
    {
        private string stuUsername;
        private string stuPw;
        private string role;

        private int levelId;
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

        private string subName1;
        private string subName2;
        private string subName3;


        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Constructor Overloading
        public Recep()
        {

        }

        public Recep(string stuUsername, string stuPw, string role, int levelId, string stuId, string stuName, string stuIcP, string stuEmail, string stuPhone, string stuAddress, string stuEnrollDate, string birthday, string studyCourse, string memo, string subName1, string subName2, string subName3)
        {
            this.stuUsername = stuUsername;
            this.stuPw = stuPw;
            this.role = role;
            this.levelId = levelId;
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
            this.subName1 = subName1;
            this.subName2 = subName2;
            this.subName3 = subName3;
        }

        
        // Method to Register into users, studentInfo, studentSubject database 
        public string addStudent()
        {
            string status;

            // Create a new SqlConnection object with the connection string and return the status as result
            con.Open();

            // Insert the value of username, password, role to the users database
            SqlCommand cmdUsers = new SqlCommand("INSERT INTO users (username, password, role) VALUES (@username, @password, @role); SELECT SCOPE_IDENTITY();", con);
            cmdUsers.Parameters.AddWithValue("@username", stuUsername);
            cmdUsers.Parameters.AddWithValue("@password", stuPw);
            cmdUsers.Parameters.AddWithValue("@role", role);
            int usersId = Convert.ToInt32(cmdUsers.ExecuteScalar());

            // Insert student's information to the studentInfo database
            SqlCommand cmdStuInfo = new SqlCommand("INSERT INTO studentInfo (usersId, levelId, studentId, studentName, studentIcP, studentEmail, studentPhone, studentAddress, studentEnrollDate, birthday, studyCourse, memo) " +
                                                 "VALUES (@usersId, @levelId, @stuId, @stuName, @stuIcP, @stuEmail, @stuPhone, @stuAddress, @stuEnrollDate, @birthday, @studyCourse, @memo); SELECT SCOPE_IDENTITY();", con);
            cmdStuInfo.Parameters.AddWithValue("@usersId", usersId);
            cmdStuInfo.Parameters.AddWithValue("@levelId", levelId);
            cmdStuInfo.Parameters.AddWithValue("@stuId", stuId);
            cmdStuInfo.Parameters.AddWithValue("@stuName", stuName);
            cmdStuInfo.Parameters.AddWithValue("@stuIcP", stuIcP);
            cmdStuInfo.Parameters.AddWithValue("@stuEmail", stuEmail);
            cmdStuInfo.Parameters.AddWithValue("@stuPhone", stuPhone);
            cmdStuInfo.Parameters.AddWithValue("@stuAddress", stuAddress);
            cmdStuInfo.Parameters.AddWithValue("@stuEnrollDate", stuEnrollDate);
            cmdStuInfo.Parameters.AddWithValue("@birthday", birthday);
            cmdStuInfo.Parameters.AddWithValue("@studyCourse", studyCourse);
            cmdStuInfo.Parameters.AddWithValue("@memo", memo);
            int studentDatabaseId = Convert.ToInt32(cmdStuInfo.ExecuteScalar());

            // Insert the subjectId(s) into the studentSubject database
            if (!string.IsNullOrEmpty(subName1))
            {
                // Get the subjectId according to the subjectName the user choose (subject 1)
                SqlCommand cmdSub1 = new SqlCommand("SELECT subjectId FROM subject WHERE subjectName = @subName", con);
                cmdSub1.Parameters.AddWithValue("@subName", subName1);
                int subId1 = -1;

                using (SqlDataReader reader = cmdSub1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subId1 = Convert.ToInt32(reader["subjectId"]);
                    }
                }

                // Insert the subjectId into the studentSubject database (subject 1)
                SqlCommand cmdStuSub1 = new SqlCommand("INSERT INTO studentSubject (studentDatabaseId, subjectId) VALUES (@stuDbId, @subId)", con);
                cmdStuSub1.Parameters.AddWithValue("@stuDbId", studentDatabaseId);
                cmdStuSub1.Parameters.AddWithValue("@subId", subId1);
                cmdStuSub1.ExecuteNonQuery();
            }

            if (!string.IsNullOrEmpty(subName2))
            {
                // Get the subjectId according to the subjectName the user choose (subject 2)
                SqlCommand cmdSub2 = new SqlCommand("SELECT subjectId FROM subject WHERE subjectName = @subName", con);
                cmdSub2.Parameters.AddWithValue("@subName", subName2);
                int subId2 = -1;

                using (SqlDataReader reader = cmdSub2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subId2 = Convert.ToInt32(reader["subjectId"]);
                    }
                }

                // Insert the subjectId into the studentSubject database (subject 2)
                SqlCommand cmdStuSub2 = new SqlCommand("INSERT INTO studentSubject (studentDatabaseId, subjectId) VALUES (@stuDbId, @subId)", con);
                cmdStuSub2.Parameters.AddWithValue("@stuDbId", studentDatabaseId);
                cmdStuSub2.Parameters.AddWithValue("@subId", subId2);
                cmdStuSub2.ExecuteNonQuery();
            }

            if (!string.IsNullOrEmpty(subName3))
            {
                // Get the subjectId according to the subjectName the user choose (subject 3)
                SqlCommand cmdSub3 = new SqlCommand("SELECT subjectId FROM subject WHERE subjectName = @subName", con);
                cmdSub3.Parameters.AddWithValue("@subName", subName3);
                int subId3 = -1;

                using (SqlDataReader reader = cmdSub3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subId3 = Convert.ToInt32(reader["subjectId"]);
                    }
                }

                // Insert the subjectId into the studentSubject database (subject 3)
                SqlCommand cmdStuSub3 = new SqlCommand("INSERT INTO studentSubject (studentDatabaseId, subjectId) VALUES (@stuDbId, @subId)", con);
                cmdStuSub3.Parameters.AddWithValue("@stuDbId", studentDatabaseId);
                cmdStuSub3.Parameters.AddWithValue("@subId", subId3);
                cmdStuSub3.ExecuteNonQuery();
            }
            con.Close();

            status = "Registration Successful.";
            return status;
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

        /*
            public void UpdateRecepInfo(Receptionist)
            {

            }

            public void GenerateReceipt(Receptionist)
            {

            }

        }*/
    }
}
