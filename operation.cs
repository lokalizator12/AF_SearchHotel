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
            try
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
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("Index not found");
            }
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Refresh2();
        }
        private void Refresh2()
        {
            numericUpDown2.Maximum = Searchin.list12.Count;
            numericUpDown1.Maximum = Searchin.list12.Count;
            if (numericUpDown1.Value == numericUpDown2.Value)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if (numericUpDown1.Value != numericUpDown2.Value)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = 0;
            Searchin s5 = new Hotel();
       
            foreach (Searchin s1 in Searchin.list12)
            {
                sum += s1+0;  //s1+0 => get countDay;
            }
            sum = sum / Searchin.list12.Count;

            MessageBox.Show(sum.ToString());
        }
    }
}
