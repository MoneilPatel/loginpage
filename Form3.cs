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
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public Form3()
        {
            InitializeComponent();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SetValueForText1 = txtUserName.Text;
            

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            SetValueForText2 = txtPassword.Text;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
