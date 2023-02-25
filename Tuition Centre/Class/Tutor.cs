using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Tuition_Centre.Tutor;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace Tuition_Centre.Class
{
    internal class TutorClass
    {
        // The connection string to the database
        private string un;
        private string subjectName;
        private string timestart;
        private string timeend;
        private string date;
        private string location;
        private string tutorFullName;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public TutorClass()
        {
            
        }


        

        internal DataTable ViewTutorClass()
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT subjectName, timestart, timeend, date, location, teacher FROM class where teacher = 'Mr.Smith Jonh H.'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
    }
}
