using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Centre.Class
{
    internal class Receptionist
    {
        private string stuName;
        private string stuIC;
        private string stuEmail;
        private string stuContact;
        private string stuAddress;
        private string stuMthEnroll;
        private string stuLv;
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

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string StuName { get => stuName; set => stuName = value; }

        //Constructor Overloading
        public Receptionist(string sN, string sIC, string sE, string sC, string sA, string sMOE, string sLV)
        {
            stuName = sN;
            stuIC = sIC;
            stuEmail = sE;
            stuContact = sC;
            stuAddress = sA;
            stuMthEnroll = sMOE;
            stuLv = sLV;
        }

        public Receptionist(string sP, string sCN, string sCVV)
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

        public Receptionist(string sS)
        {
            stuStatus = sS;
        }

        public Receptionist(string rN, string rIC, string rC, string rE, string rA)
        {
            rcpName = rN;
            rcpIC = rIC;
            rcpContact = rC;
            rcpEmail = rE;
            rcpAddress = rA;
        }
        /*
        public static object Register(Receptionist)
        {
            con.Open;
            SqlCommand cmd = new SqlCommand("select * from students where studentName = @a", con);
            con.Close; 
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
        */
    }
}
