using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Centre.Class
{
    internal class Recep
    {
        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Constructor Overloading
        public Recep()
        { }

        public void Register(string sN, string sIC, string sE, string sC, string sA, string sMOE, string sLV, string sSub)
        {
            con.Open();
            string reg = "INSERT INTO studentinfo (studentName, studentIC/Pass, studentEmail, studentPhone, studentAddress, studentEnrollmentDate, levelId) VALUES (@studentName, @studentIC/Pass, @studentEmail, @studentPhone, @studentAddress, @studentEnrollMth, @levelId)";
            SqlCommand cmd = new SqlCommand(reg, con);
            cmd.Parameters.AddWithValue("@studentName", sN);
            cmd.Parameters.AddWithValue("@studentIC/Pass", sIC);
            cmd.Parameters.AddWithValue("@studentEmail", sE);
            cmd.Parameters.AddWithValue("@studentPhone", sC);
            cmd.Parameters.AddWithValue("@studentAddress", sA);
            cmd.Parameters.AddWithValue("@studentEnrollmentDate", sMOE);
            cmd.Parameters.AddWithValue("@levelId", sLV);
            cmd.Parameters.AddWithValue("@levelId", sLV);
            cmd.ExecuteNonQuery();

            string getID = "SELECT studentDatabasedId('studentinfo')";
            SqlCommand cmd2 = new SqlCommand(getID, con);
            int studentDatabaseID = Convert.ToInt32(cmd2.ExecuteScalar());

            //<<<<<<< HEAD
            //int usersId = this.UsersId;
            //=======
            // int usersId = this.UsersId;
            //>>>>>>> b210ce48ed86a5556db0a399a06686b3eeedd36e
            string stuUserId = "INSERT INTO studentinfo (studenDatabaseID, usersId) VALUES (@studenDatabaseID, @usersId)";
            SqlCommand cmd3 = new SqlCommand(stuUserId, con);
            cmd3.Parameters.AddWithValue("@studenDatabaseID", studentDatabaseID);
            // cmd3.Parameters.AddWithValue("@usersId", usersId);
            cmd3.ExecuteNonQuery();

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

            // Return the DataTable
            return dt;
        }

        /*
        public static object Register(Receptionist)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where studentName = @a", con);
            con.Close()
        }

        public void UpdateStuSubject(Receptionist)
        {

        }

        public void UpdateStuPayment(Receptionist)
        {

        }

        public void DeleteStudent(Receptionist)
        {

        }

        public void UpdateRecepInfo(Receptionist)
        {

        }

        public void GenerateReceipt(Receptionist)
        {

        }


        public void SearchStu()
        {
            string status = null;
            con.Open();

            
            SqlCommand cmd = new SqlCommand("select count(*) from studentInfo where studentName=@stuName", con);
            cmd.Parameters.AddWithValue("@stuName", studentName);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lblStudentInfo.Text = rd.GetString(5) + " |  " + rd.GetString(4) + " |  " +  rd.GetString(12);
            }

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username=@a and password=@b", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@b", password);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole.Trim() == "admin")
                {
                    FrmMainAdmin a = new FrmMainAdmin(un);
                    Main.ActiveForm.Hide();
                    a.ShowDialog();
                }
            }
        }
        */
    }
}
