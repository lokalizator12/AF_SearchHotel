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
    public partial class Form3Camper : Form
    {
        public Form3Camper()
        {
            InitializeComponent();
        }

        List <Camper> campers = new List<Camper>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text == null && numericUpDown1.Value == null)
                {
                    Camper camperAnonim = new Camper();
                    campers.Add(camperAnonim);
                }
                else
                {
                    Camper camper = new Camper(Convert.ToChar(maskedTextBox1.Text), Convert.ToInt16(numericUpDown1.Value), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
                    campers.Add(camper);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cleaning();
           
        }

        private void cleaning()
        {
            maskedTextBox1 = null;
            numericUpDown1 = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleaning();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (campers.Count > 0) {
                campers[campers.Count - 1].Write(listBox1);
        } }

        private void button4_Click(object sender, EventArgs e)
        {
            if (campers.Count > 0)
            {
                campers[campers.Count - 1].infoTypeCamper();
            }
            else { MessageBox.Show("Please enter type in text box (A,B,C or D)"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                campers[campers.Count - 1].recommendationsForTypeCamper();
            }
            catch (Exception d) {
                MessageBox.Show("Please fill in the fields and click \"Search\"");
            }
            
        }
    }
}
