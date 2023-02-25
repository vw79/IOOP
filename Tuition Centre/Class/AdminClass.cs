using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Tuition_Centre.Admin;

namespace Tuition_Centre.Class
{
    internal class AdminClass
    {
        //Property
        private int adminUserId;
        private string adminName;
        private string adminId;
        private string adminUsername;
        private string adminPassword;
        private string adminPhone;
        private string adminEmail;
        private string adminICorPass;
        private string adminAddress;

        private int recepDataId;
        private string recepId;
        private string recepName;
        private string recepIcP;
        private string recepEmail;
        private string recepPhone;
        private string recepAddress;
        private string recepUsername;
        private string recepPassword;

        private int tutorDataId;
        private string tutorId;
        private string tutorUsername;
        private string tutorPassword;
        private string tutorFullName;
        private string tutorIcP;
        private string tutorPhone;
        private string tutorEmail;
        private string tutorDOB;
        private string tutorAddress;
        private string tutorSubject;
        private string tutorLevel;

        private int usersId;

        private string payment;
        private string subject1;
        private string subject2;
        private string subject3;
        private int mth;
        private int sci;
        private int his;
        private int eng;
        private int bah;
        private int geo;
        private int level1;
        private int level2;
        private int level3;
        private int level4;
        private int level5;
        private int total;

        //Establishing connection to databse
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Empty Constructor
        public AdminClass()
        {

        }

        //Constructor
        public AdminClass(string adminUsername, string adminPassword, string adminEmail, string adminPhone, string adminAddress, int adminUserId)
        {
            this.adminUsername  = adminUsername;
            this.adminPassword  = adminPassword;
            this.adminEmail     = adminEmail;
            this.adminPhone     = adminPhone;
            this.adminAddress   = adminAddress;
            this.adminUserId    = adminUserId;
        }

        //Constructor
        public AdminClass(string name, string id, string phone, string email, string icpass, string address)
        {
            adminName = name;
            adminId = id;
            adminPhone = phone;
            adminEmail = email;
            adminICorPass = icpass;
            adminAddress = address;
        }


        //Constructor
        public AdminClass(string recepName, string recepIcP, string recepEmail, string recepPhone, string recepAddress, string recepUsername, string recepPassword)
        {
            this.recepName = recepName;
            this.recepIcP = recepIcP;
            this.recepEmail = recepEmail;
            this.recepPhone = recepPhone;
            this.recepAddress = recepAddress;
            this.recepUsername = recepUsername;
            this.recepPassword = recepPassword;
        }

        //Constructor
        public AdminClass(string tutorFullName, string tutorUsername, string tutorPassword, string tutorPhone, string tutorEmail, string tutorDOB, string tutorAddress, string tutorSubject, string tutorLevel, string tutorIcP)
        {
            this.tutorUsername = tutorUsername;
            this.tutorPassword = tutorPassword;
            this.tutorFullName = tutorFullName;
            this.tutorPhone = tutorPhone;
            this.tutorEmail = tutorEmail;
            this.tutorDOB = tutorDOB;
            this.tutorAddress = tutorAddress;
            this.tutorSubject = tutorSubject;
            this.tutorLevel = tutorLevel;
            this.tutorIcP = tutorIcP;
        }


        public string NameDisplay(string un)
        {
            //Open database
            con.Open();
            //Select admin Name where the foreign key usersId matches with the primary key usersId and usernames match
            SqlCommand cmd = new SqlCommand("SELECT admin.adminName FROM admin INNER JOIN users ON users.usersId = admin.usersId WHERE users.username = @un", con);
            //Insert the variable into the query
            cmd.Parameters.AddWithValue("@un", un);
            //Reads the database
            SqlDataReader reader = cmd.ExecuteReader();

            //If a row is read
            if (reader.Read())
            {
                //Assign data from database into property
                adminName = reader.GetString(0);
            }

            //Close the database
            con.Close();
            //Returns property 
            return adminName;
        }

        public string IdentityDisplay(string un)
        {
            //Open database
            con.Open();
            //Selects adminId from database where foreign key usersId matches with primary key usersId and username match
            SqlCommand cmd = new SqlCommand("SELECT admin.adminId FROM admin INNER JOIN users ON users.usersId = admin.usersId WHERE users.username = @un", con);
            //Insert the variable into the query
            cmd.Parameters.AddWithValue("@un", un);
            //Reads the database
            SqlDataReader reader = cmd.ExecuteReader();
            //If a row is read
            if (reader.Read())
            {
                //Assign value from database
                adminId = reader.GetString(0);
            }
            //Closes database
            con.Close();
            //Returns adminId
            return adminId;
        }

        public DataTable ViewTutorList()
        {
            //Open database
            con.Open();
            //Select a number of information from the tutor table
            SqlCommand cmd = new SqlCommand("SELECT userId, tutorFullName, tutorId, tutorICorPass, tutorEmail, tutorPhone, tutorDOB, tutorAddress, subject, level FROM tutor", con);
            //Puts the data into a data table
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //Closes the database
            con.Close();
            //returns the datatable
            return dataTable;
        }

        public DataTable ViewReceptionistList()
        {
            //Open database
            con.Open();
            //Select a number of information ffrom the receptionist table
            SqlCommand cmd = new SqlCommand("SELECT usersId, recepId, recepName, recepIcP, recepEmail, recepPhone, recepAddress FROM receptionist", con);
            //Puts the data into a data table
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //Closes the database
            con.Close();
            //Returns the datatable
            return dataTable;
        }

        public void DeleteUser(string identity, string table, string idType)
        {
            //Opens database
            con.Open();
            //Deletes either tutor or receptionist using usersId to identify the correct user to delete
            SqlCommand cmd = new SqlCommand($"DELETE FROM {table} WHERE usersId = @identity", con);
            //Assign value into the query
            cmd.Parameters.AddWithValue("@identity", identity);
            //Executes the query and change the database
            cmd.ExecuteNonQuery();
            //Delete the user from the users table using userId as an identifier
            SqlCommand cmd2 = new SqlCommand($"DELETE FROM users WHERE usersId = @identity", con);
            //Assign value into the query
            cmd2.Parameters.AddWithValue("@identity", identity);
            //Executes the query and change the database
            cmd2.ExecuteNonQuery();
            //Closes the database
            con.Close();
        }

        public void RegisterReceptionist()
        {
            //Open the database
            con.Open();
            //Select the last row of the receptionist table
            SqlCommand cmd = new SqlCommand($"SELECT TOP 1 receptionistDatabaseId FROM receptionist ORDER BY receptionistDatabaseId DESC", con);
            //Reads the database
            SqlDataReader reader = cmd.ExecuteReader();
            //If a row is read
            if (reader.Read())
            {
                //Gets the receptionistDatabaseId and assign a string before it depending on the value
                recepDataId = reader.GetInt32(0);
                if (recepDataId == null)
                {
                    recepId = "RCP001";
                }
                else if (recepDataId < 9)
                {
                    recepId = $"RCP00{recepDataId + 1}";
                }
                else if (recepDataId < 99)
                {
                    recepId = $"RCP0{recepDataId + 1}";
                }
                else
                {
                    recepId = $"RCP{recepDataId + 1}";
                }
                //Closes the reader
                reader.Close();
                //Insert a new receptionist into the table and select the Primary Key
                SqlCommand cmd2 = new SqlCommand("INSERT INTO users VALUES (@recepUsername, @recepPassword, 'receptionist'); SELECT SCOPE_IDENTITY()", con);
                //Assign value into the query
                cmd2.Parameters.AddWithValue("@recepUsername", recepUsername);
                cmd2.Parameters.AddWithValue("@recepPassword", recepPassword);
                //Executes the query and changes the database
                cmd2.ExecuteNonQuery();
                //Assign usersId the first collumn of the table
                usersId = Convert.ToInt32(cmd2.ExecuteScalar());
                //Insert a new receptionist into the database table
                SqlCommand cmd4 = new SqlCommand("INSERT INTO receptionist VALUES (@recepId, @usersId, @recepName, @recepIcP, @recepEmail, @recepPhone, @recepAddress)", con);
                //Assign value into the query
                cmd4.Parameters.AddWithValue("@recepId", recepId);
                cmd4.Parameters.AddWithValue("@usersId", usersId);
                cmd4.Parameters.AddWithValue("@recepName", recepName);
                cmd4.Parameters.AddWithValue("@recepIcP", recepIcP);
                cmd4.Parameters.AddWithValue("@recepEmail", recepEmail);
                cmd4.Parameters.AddWithValue("@recepPhone", recepPhone);
                cmd4.Parameters.AddWithValue("@recepAddress", recepAddress);
                //Executes the query and changes the database
                cmd4.ExecuteNonQuery();
                //Closes the database
                con.Close();
            }
        }

        public void RegisterTutor()
        {
            //Open the database
            con.Open();
            //Select the last row of the tutor table
            SqlCommand cmd = new SqlCommand($"SELECT TOP 1 tutorDatabaseId FROM tutor ORDER BY tutorDatabaseId DESC", con);
            //Reads the database
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //Gets the tutorDatabaseId and assign a string before it depending on the value
                tutorDataId = reader.GetInt32(0);
                if (tutorDataId == null)
                {
                    tutorId = "TO001";
                }
                else if (tutorDataId < 9)
                {
                    tutorId = $"TO00{tutorDataId + 1}";
                }
                else if (tutorDataId < 99)
                {
                    tutorId = $"TO0{tutorDataId + 1}";
                }
                else
                {
                    tutorId = $"TO{tutorDataId + 1}";
                }
                //Closes the reader
                reader.Close();
                //Insert a new tutor into the table and select the Primary Key
                SqlCommand cmd2 = new SqlCommand("INSERT INTO users VALUES (@tutorUsername, @tutorPassword, 'tutor'); SELECT SCOPE_IDENTITY()", con);
                //Assign value into the query
                cmd2.Parameters.AddWithValue("@tutorUsername", tutorUsername);
                cmd2.Parameters.AddWithValue("@tutorPassword", tutorPassword);
                //Executes the query and changes the database
                cmd2.ExecuteNonQuery();
                //Assign usersId the first collumn of the table
                usersId = Convert.ToInt32(cmd2.ExecuteScalar());
                //Insert a new tutor into the database table
                SqlCommand cmd4 = new SqlCommand("INSERT INTO tutor VALUES (@tutorId, @usersId, @tutorUsername, @tutorFullName ,@tutorIcP, @tutorEmail, @tutorPhone, @tutorDOB, @tutorAddress, @tutorSubject, @tutorLevel)", con);
                //Assign value into the query
                cmd4.Parameters.AddWithValue("@tutorId", tutorId);
                cmd4.Parameters.AddWithValue("@usersId", usersId);
                cmd4.Parameters.AddWithValue("@tutorUsername", tutorUsername);
                cmd4.Parameters.AddWithValue("@tutorFullName", tutorFullName);
                cmd4.Parameters.AddWithValue("@tutorIcP", tutorIcP);
                cmd4.Parameters.AddWithValue("@tutorEmail", tutorEmail);
                cmd4.Parameters.AddWithValue("@tutorPhone", tutorPhone);
                cmd4.Parameters.AddWithValue("@tutorDOB", tutorDOB);
                cmd4.Parameters.AddWithValue("@tutorAddress", tutorAddress);
                cmd4.Parameters.AddWithValue("@tutorSubject", tutorSubject);
                cmd4.Parameters.AddWithValue("@tutorLevel", tutorLevel);
                //Executes the query and changes the database
                cmd4.ExecuteNonQuery();
                //Closes the database
                con.Close();
            }
        }

        public void UpdateAdmin()
        {
            //Open the database
            con.Open();
            //Updates the users database
            SqlCommand cmdUpdateUser = new SqlCommand("UPDATE users SET username = @adminUsername, password = @adminPassword WHERE usersId = @adminUserId", con);
            //Assign value into the query
            cmdUpdateUser.Parameters.AddWithValue("@adminUsername", adminUsername);
            cmdUpdateUser.Parameters.AddWithValue("@adminPassword", adminPassword);
            cmdUpdateUser.Parameters.AddWithValue("@adminUserId", adminUserId);
            //Executes the query and changes the database
            cmdUpdateUser.ExecuteNonQuery();
            //Updates the admin database
            SqlCommand cmdUpdateAdmin = new SqlCommand("UPDATE admin SET adminEmail = @adminEmail, adminPhone = @adminPhone, adminAddress = @adminAddress WHERE usersId = @adminUserId", con);
            //Assign value into the query
            cmdUpdateAdmin.Parameters.AddWithValue("@adminEmail", adminEmail);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminPhone", adminPhone);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminAddress", adminAddress);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminUserId", adminUserId);
            //Executes the query and changes the database
            cmdUpdateAdmin.ExecuteNonQuery();
            //Closes the database
            con.Close();
        }

        public ArrayList CalculateIncome(int month, int year)
        {
            //Creates a new arraylist
            ArrayList report = new ArrayList();
            //Open database
            con.Open();
            //Select the a number a values where the month and year matches with foreign key and primary key matching
            SqlCommand cmdReadPayment = new SqlCommand("SELECT payment.paymentAmount, studentSubject.subjectid1, studentSubject.subjectid2, studentSubject.subjectid3 " +
                                                        "FROM payment " +
                                                        "INNER JOIN studentSubject " +
                                                        "ON payment.studentDatabaseId = studentSubject.studentDatabaseId " +
                                                        "WHERE MONTH(payment.date) = @month AND YEAR(payment.date) =@year", con);
            //Assign the date into the query converted to string
            cmdReadPayment.Parameters.AddWithValue("@month",month.ToString());
            cmdReadPayment.Parameters.AddWithValue("@year", year.ToString());
            //Reads the database
            SqlDataReader reader = cmdReadPayment.ExecuteReader();
            //Reads every row
            while (reader.Read())
            {
                //Get value from database
                payment = reader.GetString(0);
                subject1 = reader.GetString(1);
                subject2 = reader.GetString(2);
                subject3 = reader.GetString(3);
                //Adds to variables depnding on the subject or level 
                switch (subject1[0].ToString())
                {
                    case "m":
                        mth += Convert.ToInt32(payment);
                        break;
                    case "s":
                        sci += Convert.ToInt32(payment);
                        break;
                    case "h":
                        his += Convert.ToInt32(payment);
                        break;
                    case "e":
                        eng += Convert.ToInt32(payment);
                        break;
                    case "b":
                        bah += Convert.ToInt32(payment);
                        break;
                    case "g":
                        geo += Convert.ToInt32(payment);
                        break;
                }
                switch (subject2[0].ToString())
                {
                    case "m":
                        mth += Convert.ToInt32(payment);
                        break;
                    case "s":
                        sci += Convert.ToInt32(payment);
                        break;
                    case "h":
                        his += Convert.ToInt32(payment);
                        break;
                    case "e":
                        eng += Convert.ToInt32(payment);
                        break;
                    case "b":
                        bah += Convert.ToInt32(payment);
                        break;
                    case "g":
                        geo += Convert.ToInt32(payment);
                        break;
                }
                switch (subject3[0].ToString())
                {
                    case "m":
                        mth += Convert.ToInt32(payment);
                        break;
                    case "s":
                        sci += Convert.ToInt32(payment);
                        break;
                    case "h":
                        his += Convert.ToInt32(payment);
                        break;
                    case "e":
                        eng += Convert.ToInt32(payment);
                        break;
                    case "b":
                        bah += Convert.ToInt32(payment);
                        break;
                    case "g":
                        geo += Convert.ToInt32(payment);
                        break;
                }
                switch (subject1[5])
                {
                    case '1':
                        level1 += Convert.ToInt32(payment);
                        break;
                    case '2':
                        level2 += Convert.ToInt32(payment);
                        break;
                    case '3':
                        level3 += Convert.ToInt32(payment);
                        break;
                    case '4':
                        level4 += Convert.ToInt32(payment);
                        break;
                    case '5':
                        level5 += Convert.ToInt32(payment);
                        break;
                }
                total += Convert.ToInt32(payment);
            }
            //Adds the properties into the ArrayList
            report.Add(total);
            report.Add(mth);
            report.Add(sci);
            report.Add(his);
            report.Add(eng);
            report.Add(bah);
            report.Add(geo);
            report.Add(level1);
            report.Add(level2);
            report.Add(level3);
            report.Add(level4);
            report.Add(level5);
            //Closes the reader
            reader.Close();
            //Closses the database
            con.Close();
            //Return the ArrayList
            return report;
        }

    }
}