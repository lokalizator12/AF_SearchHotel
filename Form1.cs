using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class Form1 : Form
    {
        public List<Searchin> list1 = new List<Searchin>();
        public Form1()
        {
            InitializeComponent();

        }



        private void button2_Click(object sender, EventArgs e)
        {

            Form formCamper = new Form3Camper();
            formCamper.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form formHotel = new Form2Hotel();
            formHotel.ShowDialog();
        }



        private void button3_Click(object sender, EventArgs e)
        {

            ArraysSearchin arraysSearchin = new ArraysSearchin();
            arraysSearchin.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Searchin.list12.Count > 0) button3.Enabled = true;
            if (Hotel.HotelList.Count > 0 || Camper.CampersList.Count > 0)
            {
                button5.Enabled = true;
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation formCount = new operation();
            formCount.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
