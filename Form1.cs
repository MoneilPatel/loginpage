using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginpage
{
    public partial class Form1 : Form
    {
        
        public static Dictionary<String, String> users = new Dictionary<String, String>();
        public static bool button1WasClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UserEnteredUser = Convert.ToString(txtUserName.Text);
            String UserEnteredPass = Convert.ToString(txtPassword.Text);
            bool keyExists = users.ContainsKey(UserEnteredUser);
            /*if (button1WasClicked)
            {
                users.Add(Form3.User, Form3.Pass);
                button1WasClicked = false;
            }
            */
            
            if (keyExists)
            {
                String rightPass = users[UserEnteredUser];
                if (rightPass == UserEnteredPass)
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password you enter is incorrect");
                    txtPassword.Clear();
                    txtUserName.Clear();
                    txtUserName.Focus();
                }

            }
            else
            {
                MessageBox.Show("The Username or Password you enter is incorrect");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();   
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password: password");

        }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: user");
        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            Form3 frm3 = new Form3();
            frm3.Show();
            

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
