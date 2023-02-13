using Tuition_Centre.Admin;
using Tuition_Centre.Class;
using Tuition_Centre.Receptionist;
using Tuition_Centre.Student;
using Tuition_Centre.Tutor;

namespace Tuition_Centre
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start;
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            start = obj1.Main(txtUsername.Text);
            if(start != null)
            {
                MessageBox.Show(start);
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}