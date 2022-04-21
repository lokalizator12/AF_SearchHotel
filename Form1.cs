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
    public partial class Form1 : Form { 
        public List<Registred> listPerson = new List<Registred>();
        public List<Searchin> listSearch = new List<Searchin>();
        Searchin searchin;
        Kemper kemse;
        Hotel hotel;
        public Form1()
        {
            InitializeComponent();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Registred profileForm = new Registred(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToString(maskedTextBox1.Text), Convert.ToInt32(textBox5.Text));
            listPerson.Add(profileForm);
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string equalSt = searchin.GetKemperOrString();
            if (equalSt == "Kemper") 
            {
                Kemper kemperAnonim = new Kemper();
                listSearch.Add(kemperAnonim);
            }else if (equalSt == "Hotel")
            {
                Hotel hotelAnonim = new Hotel();
                listSearch.Add(hotelAnonim);
            }
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listPerson[listPerson.Count - 1].printInfo(); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kemper kemper1 = new Kemper(textBoxCountry.Text, textBoxCity.Text,Convert.ToInt32(textBoxCenaOd.Text), Convert.ToInt32(textBoxCenaDo.Text), Convert.ToInt32(textBoxDay.Text), Convert.ToInt32(textBoxPerson.Text), Convert.ToInt32(textBoxVIP.Text));
            listSearch.Add(kemper1);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listSearch[listSearch.Count - 1].printInfo(listBox1);
        }

        private void buttonHotel_Click(object sender, EventArgs e)
        {
            Kemper kemper1 = new Kemper(textBoxCountry.Text, textBoxCity.Text, Convert.ToInt32(textBoxCenaOd.Text), Convert.ToInt32(textBoxCenaDo.Text), Convert.ToInt32(textBoxDay.Text), Convert.ToInt32(textBoxPerson.Text), Convert.ToInt32(textBoxVIP.Text));
            listSearch.Add(kemper1);
        }
    }
}
