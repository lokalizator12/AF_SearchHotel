using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_SearchHotel
{   
    public partial class Form1 : Form

        
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registred profileForm = new Registred(GetText("login"), GetText("pass"));
            profileForm.AddProfile(profileForm);
            MessageBox.Show("Succesfull");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetText(string LogOrPass)
        {
            switch (LogOrPass)
            {
                case "login": return textBox1.Text;
                    
                case "pass": return textBox2.Text;
                    
            }
            return "if not found";
            
        }
    }
}
