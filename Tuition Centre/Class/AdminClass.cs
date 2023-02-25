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
        //write method here//
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

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public AdminClass()
        {

        }

        public AdminClass(string adminUsername, string adminPassword, string adminEmail, string adminPhone, string adminAddress, int adminUserId)
        {
            this.adminUsername  = adminUsername;
            this.adminPassword  = adminPassword;
            this.adminEmail     = adminEmail;
            this.adminPhone     = adminPhone;
            this.adminAddress   = adminAddress;
            this.adminUserId    = adminUserId;
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
            SqlCommand cmd = new SqlCommand("SELECT userId, tutorFullName, tutorId, tutorICorPass, tutorEmail, tutorPhone, tutorDOB, tutorAddress, subject, level FROM tutor", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable ViewReceptionistList()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT usersId, recepId, recepName, recepIcP, recepEmail, recepPhone, recepAddress FROM receptionist", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public void DeleteUser(string identity, string table, string idType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"DELETE FROM {table} WHERE usersId = @identity", con);
            cmd.Parameters.AddWithValue("@identity", identity);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand($"DELETE FROM users WHERE usersId = @identity", con);
            cmd2.Parameters.AddWithValue("@identity", identity);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public void RegisterReceptionist()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT TOP 1 receptionistDatabaseId FROM receptionist ORDER BY receptionistDatabaseId DESC", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
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
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO users VALUES (@recepUsername, @recepPassword, 'receptionist'); SELECT SCOPE_IDENTITY()", con);
                cmd2.Parameters.AddWithValue("@recepUsername", recepUsername);
                cmd2.Parameters.AddWithValue("@recepPassword", recepPassword);
                cmd2.ExecuteNonQuery();
                usersId = Convert.ToInt32(cmd2.ExecuteScalar());
                SqlCommand cmd4 = new SqlCommand("INSERT INTO receptionist VALUES (@recepId, @usersId, @recepName, @recepIcP, @recepEmail, @recepPhone, @recepAddress)", con);
                cmd4.Parameters.AddWithValue("@recepId", recepId);
                cmd4.Parameters.AddWithValue("@usersId", usersId);
                cmd4.Parameters.AddWithValue("@recepName", recepName);
                cmd4.Parameters.AddWithValue("@recepIcP", recepIcP);
                cmd4.Parameters.AddWithValue("@recepEmail", recepEmail);
                cmd4.Parameters.AddWithValue("@recepPhone", recepPhone);
                cmd4.Parameters.AddWithValue("@recepAddress", recepAddress);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
        }

        public void RegisterTutor()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT TOP 1 tutorDatabaseId FROM tutor ORDER BY tutorDatabaseId DESC", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
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
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO users VALUES (@tutorUsername, @tutorPassword, 'tutor'); SELECT SCOPE_IDENTITY()", con);
                cmd2.Parameters.AddWithValue("@tutorUsername", tutorUsername);
                cmd2.Parameters.AddWithValue("@tutorPassword", tutorPassword);
                cmd2.ExecuteNonQuery();
                usersId = Convert.ToInt32(cmd2.ExecuteScalar());
                SqlCommand cmd4 = new SqlCommand("INSERT INTO tutor VALUES (@tutorId, @usersId, @tutorUsername, @tutorFullName ,@tutorIcP, @tutorEmail, @tutorPhone, @tutorDOB, @tutorAddress, @tutorSubject, @tutorLevel)", con);
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
                cmd4.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateAdmin()
        {
            con.Open();
            SqlCommand cmdUpdateUser = new SqlCommand("UPDATE users SET username = @adminUsername, password = @adminPassword WHERE usersId = @adminUserId", con);
            cmdUpdateUser.Parameters.AddWithValue("@adminUsername", adminUsername);
            cmdUpdateUser.Parameters.AddWithValue("@adminPassword", adminPassword);
            cmdUpdateUser.Parameters.AddWithValue("@adminUserId", adminUserId);
            cmdUpdateUser.ExecuteNonQuery();
            SqlCommand cmdUpdateAdmin = new SqlCommand("UPDATE admin SET adminEmail = @adminEmail, adminPhone = @adminPhone, adminAddress = @adminAddress WHERE usersId = @adminUserId", con);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminEmail", adminEmail);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminPhone", adminPhone);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminAddress", adminAddress);
            cmdUpdateAdmin.Parameters.AddWithValue("@adminUserId", adminUserId);
            cmdUpdateAdmin.ExecuteNonQuery();
            con.Close();
        }

        public ArrayList CalculateIncome(int month, int year)
        {
            ArrayList report = new ArrayList();
            con.Open();
            SqlCommand cmdReadPayment = new SqlCommand("SELECT payment.paymentAmount, studentSubject.subjectid1, studentSubject.subjectid2, studentSubject.subjectid3 " +
                                                        "FROM payment " +
                                                        "INNER JOIN studentSubject " +
                                                        "ON payment.studentDatabaseId = studentSubject.studentDatabaseId " +
                                                        "WHERE MONTH(payment.date) = @month AND YEAR(payment.date) =@year", con);
            cmdReadPayment.Parameters.AddWithValue("@month",month.ToString());
            cmdReadPayment.Parameters.AddWithValue("@year", year.ToString());
            SqlDataReader reader = cmdReadPayment.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("This ran");
                payment = reader.GetString(0);
                subject1 = reader.GetString(1);
                subject2 = reader.GetString(2);
                subject3 = reader.GetString(3);
                SubjectCalculator(subject1, mth, sci, his, eng, bah, geo, payment);
                SubjectCalculator(subject2, mth, sci, his, eng, bah, geo, payment);
                SubjectCalculator(subject3, mth, sci, his, eng, bah, geo, payment);
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
            reader.Close();
            con.Close();
            MessageBox.Show(total.ToString());
            return report;
        }

        private int SubjectCalculator(string subject, int mth, int sci, int his, int eng, int bah, int geo, string payment)
        {
            switch (subject[0])
            {
                case 'm':
                    mth += Convert.ToInt32(payment);
                    return mth;
                case 's':
                    sci += Convert.ToInt32(payment);
                    return sci;
                case 'h':
                    his += Convert.ToInt32(payment);
                    return his;
                case 'e':
                    eng += Convert.ToInt32(payment);
                    return eng;
                case 'b':
                    bah += Convert.ToInt32(payment);
                    return bah;
                case 'g':
                    geo += Convert.ToInt32(payment);
                    return geo;
                default:
                    throw new ArgumentException("Invalid subject");
            }
        }

    }
}