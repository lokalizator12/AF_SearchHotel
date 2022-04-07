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

        
    { public List<Registred> list = new List<Registred>();
        
        public Form1()
        {
            InitializeComponent();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Registred profileForm = new Registred(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToString(maskedTextBox1.Text), Convert.ToInt32(textBox5.Text));
            list.Add(profileForm);
           // MainForm mainForm = new MainForm();
           // mainForm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Registred anonimProfile = new Registred();
            list.Add(anonimProfile);
            Form mainForm = new MainForm();
           // mainForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list[list.Count - 1].printInfo(); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
