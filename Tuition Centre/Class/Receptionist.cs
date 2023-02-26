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

        private string paidBy;
        private string payAmount;
        private string acceptStatus;
        private DateTime date;

        private string status;


        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Constructor Overloading
        public Recep()
        {

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

        public Recep(string payAmount, string paidBy, DateTime date, string acceptStatus, string stuUsername)
        {
            this.payAmount = payAmount;
            this.paidBy = paidBy;
            this.date = date;
            this.acceptStatus = acceptStatus;
            this.stuUsername = stuUsername;
        }

        public Recep(string stuName, string stuUsername, string subId1, string subId2, string subId3)
        {
            this.subId1 = subId1;
            this.subId2 = subId2;
            this.subId3 = subId3;
            this.stuName = stuName;
            this.stuUsername = stuUsername;
        }

        public Recep(string studentName)
        {
            this.stuName = studentName;
        }

        public Recep (string stuName, string payMethod, string cardNum, string cvv)
        {
            this.stuName= stuName;
            this.payMethod = payMethod;
            this.cardNumber = cardNum;
            this.CVV = cvv;
        }

        // Method getting receptionist name from database and return as string

        public string[] getRecepData(string un)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

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
        public DataTable searchStu(string searchName)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT i.studentId, i.studentName, i.studentEnrollmentDate, i.studyCourse, i.level, s.subjectid1, s.subjectid2, s.subjectid3 " +
                                            "FROM studentInfo i " +
                                            "LEFT JOIN studentSubject s ON i.studentDatabaseld = s.studentDatabaseId " +
                                    "WHERE i.studentName LIKE @searchName", con);
            cmd.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            con.Close();

            // Return the DataTable if rows are found, otherwise return null
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public void UpdateStuSubject(string acceptanceStatus)
        {
            // Create a new SqlConnection and SqlCommand to execute the update query
              
            con.Open(); 

            SqlCommand cmd = new SqlCommand("UPDATE studentSubject SET subjectid1=@subId1, subjectid2=@subId2, subjectid3=@subId3 WHERE fullname=@studentName", con);

            // Set the parameters for the query
            cmd.Parameters.AddWithValue("@subId1", subId1);
            cmd.Parameters.AddWithValue("@subId2", subId2);
            cmd.Parameters.AddWithValue("@subId3", subId3);
            cmd.Parameters.AddWithValue("@studentName", stuName);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("UPDATE changeSubject SET acceptanceStatus=@status WHERE username=@stuUsername", con);
            // Set the parameters for the query
            cmd1.Parameters.AddWithValue("@status", acceptanceStatus);
            cmd1.Parameters.AddWithValue("@stuUsername", stuUsername);
            cmd1.ExecuteNonQuery();

            con.Close();
        }
        
        
        public void UpdateStuPayment()
        {
            con.Open();
            // Create a SqlCommand to retrieve the student's database ID based on their name.
            SqlCommand cmdGetId = new SqlCommand("SELECT i.studentDatabaselD FROM studentInfo i INNER JOIN paymentInfo p ON i.studentDatabaselD = p.studentDatabaseID WHERE i.studentName = @stuName", con);
            // Set the parameter for the query to the student's name.
            cmdGetId.Parameters.AddWithValue("@stuName", stuName);
            // Execute the query and retrieve the student's database ID.
            int stuDbId = (int)cmdGetId.ExecuteScalar();

            // Create a SqlCommand to update the paymentInfo table for the student with the retrieved database ID.
            SqlCommand cmdUpdate = new SqlCommand("UPDATE paymentInfo SET paymentMethod = @paymentMethod, cardNumber = @cardNumber, CVV = @cvv WHERE studentDatabaseID = @stuDbId", con);
            // Set the parameters for the query to the new payment information and the student's database ID.
            cmdUpdate.Parameters.AddWithValue("@paymentMethod", payMethod);
            cmdUpdate.Parameters.AddWithValue("@cardNumber", cardNumber);
            cmdUpdate.Parameters.AddWithValue("@cvv", CVV);
            cmdUpdate.Parameters.AddWithValue("@stuDbId", stuDbId);
            // Execute the query to update the payment information in the database.
            cmdUpdate.ExecuteNonQuery();

            con.Close();
        }
   
        

        public string deleteStudent(string stuName)
        {
            string status = "";
            
            con.Open();

            // Get the student's database ID based on their name.
            SqlCommand cmdGetStudentId = new SqlCommand("SELECT studentDatabaseld FROM studentInfo WHERE studentName = @studentName", con);
            cmdGetStudentId.Parameters.AddWithValue("@studentName", stuName);
            int studentId = (int)cmdGetStudentId.ExecuteScalar();

            // Delete the student's subjects.
            SqlCommand cmdDeleteStudentSubjects = new SqlCommand("DELETE FROM studentSubject WHERE studentDatabaseId = @studentId", con);
            cmdDeleteStudentSubjects.Parameters.AddWithValue("@studentId", studentId);
            cmdDeleteStudentSubjects.ExecuteNonQuery();

            // Delete the student's payment info
            SqlCommand cmdDeleteStudentPayInfo = new SqlCommand("DELETE FROM paymentInfo WHERE studentDatabaseId = @studentId", con);
            cmdDeleteStudentPayInfo.Parameters.AddWithValue("@studentId", studentId);
            cmdDeleteStudentPayInfo.ExecuteNonQuery();

            // Delete the student's user account.
            SqlCommand cmdDeleteStudentUser = new SqlCommand("DELETE FROM users WHERE username = @studentName", con);
            cmdDeleteStudentUser.Parameters.AddWithValue("@studentName", stuName);
            cmdDeleteStudentUser.ExecuteNonQuery();

            // Delete the student's information.
            SqlCommand cmdDeleteStudentInfo = new SqlCommand("DELETE FROM studentInfo WHERE studentName = @studentName", con);
            cmdDeleteStudentInfo.Parameters.AddWithValue("@studentName", stuName);
            cmdDeleteStudentInfo.ExecuteNonQuery();

            status = "Student information has been deleted successfully.";
           
          
            con.Close();
            

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
        
        public void GenerateReceipt()
        {
            con.Open();

            SqlCommand cmdPayment = new SqlCommand("INSERT INTO payment (studentDatabaseId, paidBy, paymentAmount, acceptanceStatus, date) " +
                                                    "SELECT s.studentDatabaseld, @paidBy, @payAmount, @acceptStatus, @date " +
                                                    "FROM studentInfo s " +
                                                    "LEFT JOIN payment p ON s.studentDatabaseld = p.studentDatabaseId " +
                                                    "WHERE s.username = @stuUsername", con);

            cmdPayment.Parameters.AddWithValue("@paidBy", paidBy);
            cmdPayment.Parameters.AddWithValue("@payAmount", payAmount);
            cmdPayment.Parameters.AddWithValue("@acceptStatus", acceptStatus);
            cmdPayment.Parameters.AddWithValue("@date", date);
            cmdPayment.Parameters.AddWithValue("@stuUsername", stuUsername);
            cmdPayment.ExecuteNonQuery();

            con.Close();
        }

        
    }
}
