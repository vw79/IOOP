using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Admin
{
    public partial class FrmAdminFinance : Form
    {
        public static string name;


        public FrmAdminFinance()
        {
            InitializeComponent();
            //Get the month and year from the date time picker
            int month = dtpMonthYear.Value.Month;
            int year = dtpMonthYear.Value.Year;
            //Creates a new object and assign report as an ArrayList from the class and method
            AdminClass calculator = new AdminClass();
            ArrayList report = calculator.CalculateIncome(month, year);
            //Adds this string into the list
            lstbReport.Items.Add("Income for this month");
            //Declare count as 0
            int count = 0;
            //Prints out the total amount earned in the list box
            foreach (var item in report)
            {
                //Determines how much count is and determine what should be printed
                switch (count)
                {
                    case 0:
                        lstbReport.Items.Add($"Total income = RM{item}");
                        break;
                    case 1:
                        lstbReport.Items.Add($"Total income from Mathematics = RM{item}");
                        break;
                    case 2:
                        lstbReport.Items.Add($"Total income from Science = RM{item}");
                        break;
                    case 3:
                        lstbReport.Items.Add($"Total income from Histroy = RM{item}");
                        break;
                    case 4:
                        lstbReport.Items.Add($"Total income from English = RM{item}");
                        break;
                    case 5:
                        lstbReport.Items.Add($"Total income from Bahasa = RM{item}");
                        break;
                    case 6:
                        lstbReport.Items.Add($"Total income from Geography = RM{item}");
                        break;
                    case 7:
                        lstbReport.Items.Add($"Total income from Level 1 = RM{item}");
                        break;
                    case 8:
                        lstbReport.Items.Add($"Total income from Level 2 = RM{item}");
                        break;
                    case 9:
                        lstbReport.Items.Add($"Total income from Level 3 = RM{item}");
                        break;
                    case 10:
                        lstbReport.Items.Add($"Total income from Level 4 = RM{item}");
                        break;
                    case 11:
                        lstbReport.Items.Add($"Total incoem from Level 5 = RM{item}");
                        break;
                }
                //Increase count by one each loop
                count++;
            }
        }

        private void dtbMonthYear_ValueChanged(object sender, EventArgs e)
        {
            //Forces the day of the date time picker to always be 1
            dtpMonthYear.Value = new DateTime(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month, 1);
            //Get the month and year from the date time picker
            int month = dtpMonthYear.Value.Month;
            int year = dtpMonthYear.Value.Year;
            //Creates a new object and assign report as an ArrayList from the class and method
            AdminClass calculator = new AdminClass();
            ArrayList report = calculator.CalculateIncome(month, year);
            //Clears the list
            lstbReport.Items.Clear();
            //Add the string
            lstbReport.Items.Add("Income for this month");
            //Declare count as 0
            int count = 0;
            //Prints out the total amount earned in the list box
            foreach (var item in report)
            {
                //Determines how much count is and determine what should be printed
                switch (count)
                {
                    case 0:
                        lstbReport.Items.Add($"Total income = RM{item}");
                        break;
                    case 1:
                        lstbReport.Items.Add($"Total income from Mathematics = RM{item}");
                        break;
                    case 2:
                        lstbReport.Items.Add($"Total income from Science = RM{item}");
                        break;
                    case 3:
                        lstbReport.Items.Add($"Total income from Histroy = RM{item}");
                        break;
                    case 4:
                        lstbReport.Items.Add($"Total income from English = RM{item}");
                        break;
                    case 5:
                        lstbReport.Items.Add($"Total income from Bahasa = RM{item}");
                        break;
                    case 6:
                        lstbReport.Items.Add($"Total income from Geography = RM{item}");
                        break;
                    case 7:
                        lstbReport.Items.Add($"Total income from Level 1 = RM{item}");
                        break;
                    case 8:
                        lstbReport.Items.Add($"Total income from Level 2 = RM{item}");
                        break;
                    case 9:
                        lstbReport.Items.Add($"Total income from Level 3 = RM{item}");
                        break;
                    case 10:
                        lstbReport.Items.Add($"Total income from Level 4 = RM{item}");
                        break;
                    case 11:
                        lstbReport.Items.Add($"Total incoem from Level 5 = RM{item}");
                        break;
                }
                //Increase count by one each loop
                count++;
            }
        }
    }
}
