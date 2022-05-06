using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class Form3Camper : Form
    {
        public Form3Camper()
        {
            InitializeComponent();
        }

        List<Camper> campers = new List<Camper>();
        Camper camper;
        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                camper = new Camper(textBox1.Text, textBox2.Text, Convert.ToDouble(numericUpDown6.Value), Convert.ToDouble(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value),
                    Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value), checkBox4.Checked, Convert.ToChar(maskedTextBox1.Text), Convert.ToInt16(numericUpDown1.Value),
                    checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, dateTimePicker1.Value, dateTimePicker2.Value, bmp);
                campers.Add(camper);
                Searchin.list12.Add(camper);//////
                button5.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleaning()
        {
            maskedTextBox1 = null;
            textBox2.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            listBox1.Items.Clear();
            if (campers.Count > 0)
            {
                campers[campers.Count - 1] = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleaning();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (campers.Count > 0)
            {
                campers[campers.Count - 1].Write(listBox1, pictureBox1);
                pictureBox1.Visible = true;
                pictureBox1.Image = bmp;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            camper = new Camper();
            camper.InfoTypeCamper();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                campers[campers.Count - 1].RecommendationsForTypeCamper();
            }
            catch (Exception d)
            {
                MessageBox.Show("Please fill in the fields and click \"Search\"");
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                BackgroundImage = bitmap;
            }
        }
        private void FullEnter()
        {
            textBox1.Text = "USA";
            textBox2.Text = "New York";
            dateTimePicker2.Value.AddDays(30);
            numericUpDown4.Value = 2;
            numericUpDown5.Value = 5;
            numericUpDown6.Value = 100;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 2000;
            numericUpDown3.Value = 5;
            checkBox2.Checked = true;
            checkBox1.Checked = true;
            maskedTextBox1.Text = "A";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FullEnter();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
