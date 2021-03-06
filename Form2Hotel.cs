using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class Form2Hotel : Form
    {

        //List<Hotel> hotelList = new List<Hotel>();
        Hotel anonimHotel = new Hotel();
        Bitmap bitmap;
        public Form2Hotel()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Hotel searchHotel = new Hotel(textBox1.Text, textBox2.Text, Convert.ToDouble(numericUpDown8.Value), Convert.ToDouble(numericUpDown7.Value), Convert.ToInt32(numericUpDown6.Value), Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value),
            checkBox5.Checked, Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), Convert.ToDouble(numericUpDown2.Value), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, dateTimePicker1.Value, dateTimePicker2.Value, bitmap);
           
            Searchin.list12.Add(searchHotel);
            button5.Enabled = true;
            Hotel.HotelList.Add(searchHotel);

            if (numericUpDown4.Value > 1)
            {
                buttonListPerson.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel.HotelList[Hotel.HotelList.Count - 1].Write(listBox1, pictureBox1);
                pictureBox1.Visible = true;
                pictureBox1.Image = bitmap;

            }
            catch (Exception ex)
            { MessageBox.Show("Nothing to watch"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleaning();
            anonimHotel.listPerson.Clear();
        }

        private void cleaning()
        {
            pictureBox1.Visible = false;
            checkBox4.Checked = false;
            checkBox3.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            buttonListPerson.Visible = false;
            button5.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            if (Hotel.HotelList.Count > 0)
            {
                Hotel.HotelList[Hotel.HotelList.Count - 1] = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anonimHotel.AdditionalServices();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            anonimHotel.RecommendationsForRoomBaseMoney();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                    BackgroundImage = bitmap;
                    
                }
            }catch (System.ArgumentException)
            {
                MessageBox.Show("This is not image");
            }
        }


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 1)
            {
                textBox3.Enabled = true;
                textBox3.Visible = true;
                label13.Visible = true;
                button7.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anonimHotel.AddPerson(textBox3.Text);
            textBox3.Clear();
            if (anonimHotel.listPerson.Count == numericUpDown4.Value)
            {
                textBox3.Enabled = false;
                textBox3.Visible = false;
                label13.Visible = false;
                button7.Visible = false;
                numericUpDown4.Enabled = false;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value != 0 || numericUpDown2.Value > 0 || numericUpDown3.Value > 0 || numericUpDown6.Value > 0 || numericUpDown7.Value > 0 || numericUpDown8.Value > 0)
            {
                textBox3.Enabled = false;
                textBox3.Visible = false;
                label13.Visible = false;
                button7.Visible = false;
            }
        }
        private void fullEnter()
        {
            textBox1.Text = "USA";
            textBox2.Text = "New York";
            dateTimePicker2.Value.AddDays(30);
            numericUpDown4.Value = 2;
            numericUpDown5.Value = 5;
            numericUpDown6.Value = 5;
            numericUpDown7.Value = 1000;
            numericUpDown8.Value = 100;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 2;
            numericUpDown3.Value = 5;
            checkBox2.Checked = true;
            checkBox1.Checked = true;
            checkBox5.Checked = true;
            textBox3.Enabled = true;
            textBox3.Visible = true;
            label13.Visible = true;
            button7.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fullEnter();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            anonimHotel.WritePerson(listBox1);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bitmap = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = bitmap;
                    button1.Enabled = true;
                }
            }
            catch (System.ArgumentException)
            {

                MessageBox.Show("this is not image");
            }
            

        }

       

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Right)
                {
                    textBox1.Text = "Poland";
                }
            
            
        }

        private void Form2Hotel_MouseDown(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Right)
                {
                BackgroundImage = Bitmap.FromFile("C:\\Users\\fatik\\Pictures\\1625492016_12-kartinkin-com-p-sinii-fon-akvarel-krasivie-foni-14.jpg");
                }
            
        }

        private void Form2Hotel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                BackgroundImage = null;
            }
        }

        

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    textBox1.Text = "Poland";
                }
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    textBox2.Text = "Opole";
                }
            }
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("order data window", listBox1);
        }

        
    }
}
