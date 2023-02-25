﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuition_Centre.Class;

namespace Tuition_Centre.Receptionist
{
    public partial class frmUpdateStu : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string un;
        private string searchName;
        private string stuId;
        private string stuName;

        private Button currentButton;
        private Form activeForm;

        public frmUpdateStu()
        {
            InitializeComponent();
        }

        public frmUpdateStu(string un, string stuName)
        {
            InitializeComponent();
            this.un = un;

            frmStuSearch selectStu = new frmStuSearch();
            selectStu.TopLevel = true;
            panel3.Controls.Clear();
            panel3.Controls.Add(selectStu);
            selectStu.Show();
        }

        /*
        private void dgvChangeSubject_SelectionChanged(object sender, EventArgs e)
        {
            // Get the currently selected row in the DataGridView
            DataGridViewRow selectedRow = dgvChangeSubject.CurrentRow;

            // Extract the data for each column from the selected row
            string id = selectedRow.Cells
            string date = selectedRow.Cells["Date"].Value.ToString();
            string studentName = selectedRow.Cells["Student Name"].Value.ToString();
            string oldSubject = selectedRow.Cells["Old Subject"].Value.ToString();
            string newSubject = selectedRow.Cells["New Subject"].Value.ToString();
            string reason = selectedRow.Cells["Reason"].Value.ToString();
            string status = selectedRow.Cells["Status"].Value.ToString();

            lblStuName.Text = studentName;

            // Create a new instance of the frmUpdateSubject form and pass in the extracted data as parameters
            frmUpdateStu1 updateStuSub = new frmUpdateStu1(date, studentName, oldSubject, newSubject, reason, status);

            // Add the frmUpdateSubject form to the panel3 control
            panel3.Controls.Clear();
            panel3.Controls.Add(updateStuSub);
            updateStuSub.Dock = DockStyle.Fill;
            updateStuSub.BringToFront();
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainReceptionist back = new frmMainReceptionist(un);
            back.Show();
            this.Hide();
        }

        
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.Show();
        } */


        private void btnUpSub_Click(object sender, EventArgs e)
        {
            // openChildForm(new frmUpdateStu1(), btnUpSub);
            btnUpSub.Enabled = false;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = true;

            panel3.Visible = true;
            panel3.BringToFront();

            frmUpdateStu1 upStu1 = new frmUpdateStu1();
            upStu1.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(upStu1);
            upStu1.Show();
        }



        /*
        private void btnUpPay_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu2(), btnUpPay);
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = false;
            btnDeleteStu.Enabled = true;
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateStu3(), btnDeleteStu);
            btnUpSub.Enabled = true;
            btnUpPay.Enabled = true;
            btnDeleteStu.Enabled = false;
        }

       private void btnSearch_Click(object sender, EventArgs e)
        {
            Recep rcp = new Recep();
            DataTable dt = rcp.SearchStu(searchName);
            searchName = txtSearch.Text;

            if (dt != null && dt.Rows.Count > 0)
            {
                lblStuID.Text = dt.Rows[0]["studentId"].ToString();
                lblStuName.Text = dt.Rows[0]["studentName"].ToString();

                if (btnUpSub.Enabled == false)
                {
                    currentButton = btnUpSub;
                }
                else if (btnUpPay.Enabled == false)
                {
                    currentButton = btnUpPay;
                }
                else if (btnDeleteStu.Enabled == false)
                {
                    currentButton = btnDeleteStu;
                }

                openChildForm(new frmUpdateStu1(), currentButton);
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

            lblSearch.Hide();
            txtSearch.Hide();
            this.Hide();
        } */





    }
}
