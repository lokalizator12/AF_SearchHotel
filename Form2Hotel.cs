using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class Form2Hotel : Form
    {

        List<Hotel> hotelList = new List<Hotel>();
        Hotel searchHotel;
        public Form2Hotel()
        {
            InitializeComponent();
        }

        private void Form2Hotel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchHotel = new Hotel(textBox1.Text, textBox2.Text, Convert.ToDouble(numericUpDown8.Value), Convert.ToDouble(numericUpDown7.Value), Convert.ToInt32(numericUpDown6.Value), Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value),
                checkBox5.Checked, Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), Convert.ToDouble(numericUpDown2.Value), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, dateTimePicker1.Value, dateTimePicker2.Value);
            hotelList.Add(searchHotel);
            button5.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hotelList.Count > 0)
            {
                hotelList[hotelList.Count - 1].Write(listBox1);
            }
            else { MessageBox.Show("Nothing to watch"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleaning();
        }

        private void cleaning()
        {
            checkBox4.Checked = false;
            checkBox3.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            if (hotelList.Count > 0)
            {
                hotelList[hotelList.Count - 1] = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          searchHotel = new Hotel();
            searchHotel.additionalServices();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchHotel = new Hotel();
            searchHotel.recommendationsForRoomBaseMoney();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 1 )
            {
                searchHotel = new Hotel();
                searchHotel.addPersons(textBox1);
                textBox3.Enabled = true;
                textBox3.Visible = true;
                label13.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
