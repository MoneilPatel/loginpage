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
    public partial class Form3 : Form
    {

        public static String User = "";
        public static String Pass = "";
        
        public Form3()
        {
            InitializeComponent();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            Pass = txtPassword.Text;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = Convert.ToString(txtUserName.Text);
            String pass = Convert.ToString(txtPassword.Text);
            
            bool keyExists = Form1.users.ContainsKey(temp);
            if (keyExists == true && Form1.button1WasClicked == true)
            {
                MessageBox.Show("The Username you entered is taken!");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
            
            if(!keyExists)
            {
                Form1.users.Add(temp,pass);
                Form1.button1WasClicked = false;
                txtUserName.Clear();
            }
        
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
