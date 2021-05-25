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
        
        Dictionary<String, String> users = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = Convert.ToString(txtUserName.Text);
            bool keyExists = users.ContainsKey(temp);
            //Console.WriteLine(users);
            String value = users[temp]; 
            if (keyExists)
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
            Form3 frm3 = new Form3();
            frm3.Show();
            //String username = Convert.ToString(Form3.SetValueForText1);
            //String password = Convert.ToString(Form3.SetValueForText2);
            users.Add(Form3.SetValueForText1, Form3.SetValueForText2);
            //users.Add("moneil", "patel");

        }
        
    }
}
