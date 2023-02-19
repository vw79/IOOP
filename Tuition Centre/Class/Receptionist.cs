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
        private string stuName;
        private string stuIC;
        private string stuEmail;
        private string stuContact;
        private string stuAddress;
        private string stuMthEnroll;
        private string stuLv;
        private string stuSub;
        private string stuPay;
        private string stuCardNo;
        private string stuCVV;
        private string stuStatus;
        private string stuCurrentSub;
        private string stuUpSub;
        private string stuPayAmount;
        private string rcpName;
        private string rcpIC;
        private string rcpContact;
        private string rcpEmail;
        private string rcpAddress;

        // The connection string to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string StuName { get => stuName; set => stuName = value; }
        public string StuIC { get => stuIC; set => stuIC = value; }
        public string StuEmail { get => stuEmail; set => stuEmail = value; }
        public string StuContact { get => stuContact; set => stuContact = value; }
        public string StuAddress { get => stuAddress; set => stuAddress = value; }
        public string StuMthEnroll { get => stuMthEnroll; set => stuMthEnroll = value; }
        public string StuLv { get => stuLv; set => stuLv = value; }
        public string StuPay { get => stuPay; set => stuPay = value; }
        public string StuCardNo { get => stuCardNo; set => stuCardNo = value; }
        public string StuCVV { get => stuCVV; set => stuCVV = value; }
        public string StuCVV1 { get => stuCVV; set => stuCVV = value; }
        public string StuStatus { get => stuStatus; set => stuStatus = value; }
        public string StuCurrentSub { get => stuCurrentSub; set => stuCurrentSub = value; }
        public string StuUpSub { get => stuUpSub; set => stuUpSub = value; }
        public string StuPayAmount { get => stuPayAmount; set => stuPayAmount = value; }
        public string RcpName { get => rcpName; set => rcpName = value; }
        public string RcpIC { get => rcpIC; set => rcpIC = value; }
        public string RcpContact { get => rcpContact; set => rcpContact = value; }
        public string RcpEmail { get => rcpEmail; set => rcpEmail = value; }
        public string RcpAddress { get => rcpAddress; set => rcpAddress = value; }
        public string StuSub { get => stuSub; set => stuSub = value; }

        //Constructor Overloading
        public Recep(string sN, string sIC, string sE, string sC, string sA, string sMOE, string sLV, string sSub)
        {
            StuName = sN;
            StuIC = sIC;
            StuEmail = sE;
            StuContact = sC;
            StuAddress = sA;
            StuMthEnroll = sMOE;
            StuLv = sLV;
            StuSub = sSub;
        }

        public Recep(string sP, string sCN, string sCVV)
        {
            stuPay = sP;
            stuCardNo = sCN;
            stuCVV = sCVV;
        }

        /*public Receptionist(string stS, string sCS, string sUS)
        {
            stuStatus = stS;
            stuCurrentSub = sCS;
            stuUpSub = sUS;
        }*/

        public Recep(string sS)
        {
            stuStatus = sS;
        }

        public Recep(string rN, string rIC, string rC, string rE, string rA)
        {
            rcpName = rN;
            rcpIC = rIC;
            rcpContact = rC;
            rcpEmail = rE;
            rcpAddress = rA;
        }

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

        //Constructor Overloading
        public Recep()
        { }

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
