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
            int month = dtpMonthYear.Value.Month;
            int year = dtpMonthYear.Value.Year;
            AdminClass calculator = new AdminClass();
            ArrayList report = calculator.CalculateIncome(month, year);
            lstbReport.Items.Add("Income for this month");
            foreach (var item in report)
            {
                int count = 0;
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
                lstbReport.Items.Add($"Total income = {item}");
            }
        }

        private void dtbMonthYear_ValueChanged(object sender, EventArgs e)
        {
            dtpMonthYear.Value = new DateTime(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month, 1);
            int month = dtpMonthYear.Value.Month;
            int year = dtpMonthYear.Value.Year;
            AdminClass calculator = new AdminClass();
            ArrayList report = calculator.CalculateIncome(month, year);
            lstbReport.Items.Add("Income for this month");
            foreach (var item in report)
            {
                int count = 0;
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
                lstbReport.Items.Add($"Total income = {item}");
            }
        }
    }
}
