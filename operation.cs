using System;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class operation : Form
    {
        public operation()
        {
            InitializeComponent();
            Refresh2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Hotel.HotelList[(int)numericUpDown2.Value] + (int)numericUpDown1.Value;
            MessageBox.Show("Total days with " + numericUpDown2.Value.ToString() + "st. and " + numericUpDown1.Value.ToString() + "st. order: " + result.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Hotel.HotelList.Count > 0)
            {
                numericUpDown1.Maximum = Hotel.HotelList.Count - 1;
                numericUpDown2.Maximum = Hotel.HotelList.Count - 1;
                numericUpDown2.Minimum = 0;
                numericUpDown1.Minimum = 0;
            }

            Refresh2();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Hotel.HotelList[(int)numericUpDown2.Value] != Hotel.HotelList[(int)numericUpDown1.Value])
            {
                MessageBox.Show("Not arrival");
            }
            else if (Hotel.HotelList[(int)numericUpDown2.Value] == Hotel.HotelList[(int)numericUpDown1.Value])
            {
                MessageBox.Show("Yes, compare");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Refresh2();
        }
        private void Refresh2()
        {
            if (numericUpDown1.Value == numericUpDown2.Value)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else if (numericUpDown1.Value != numericUpDown2.Value)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
    }
}
