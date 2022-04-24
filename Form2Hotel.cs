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
    public partial class Form2Hotel : Form
    {

        List<Hotel> hotelList = new List<Hotel>();
        public Form2Hotel()
        {
            InitializeComponent();
        }

        private void Form2Hotel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel searchHotel = new Hotel(Convert.ToInt16(numericUpDown1.Value),Convert.ToInt16(numericUpDown2.Value),Convert.ToDouble(numericUpDown2.Value), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
            hotelList.Add(searchHotel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(hotelList.Count > 0)
            hotelList[hotelList.Count - 1].Write(listBox1);
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
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            listBox1.Items.Clear();
        }

    }
}
