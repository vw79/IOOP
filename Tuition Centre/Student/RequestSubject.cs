﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre.Student
{
    public partial class RequestSubject : Form
    {
        public RequestSubject()
        {
            InitializeComponent();
        }

        private void StudentMainPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            frmMainStudent obj1 = new frmMainStudent();
            this.Close();
            obj1.ShowDialog();
        }
    }
}
