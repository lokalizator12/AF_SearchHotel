﻿using System;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class ArraysSearchin : Form
    {
        public ArraysSearchin()
        {
            InitializeComponent();
        }
        int s = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            Searchin.list12[s].Write(listBox1, pictureBox1);
            s--;
            if (Searchin.list12.Count > 0)
            {
                button1.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Searchin.list12[s].Write(listBox1, pictureBox1);
            s++;
            if (Searchin.list12.Count == s)
            {
                button2.Enabled = false;
            }
            if (Searchin.list12.Count > 0)
            {
                button1.Enabled = true;

            }

        }
    }
}