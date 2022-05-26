using System;
using System.IO;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class ArraysSearchin : Form
    {
        public ArraysSearchin()
        {
            InitializeComponent();
            if (Searchin.list12.Count > 0)
            { 
                button5.Enabled = true;
                numericUpDown1.Update();
            }
        }
        private int s = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (s == 0)
            {
                button1.Enabled = false;

            }
            else
            {
                --s;
                Searchin.list12[s].Write(listBox1, pictureBox1);
                
                if (Searchin.list12.Count > 1)
                {
                    button1.Enabled = true;

                }
                if (Searchin.list12.Count > 0)
                {
                    button2.Enabled = true;
                }

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
                s--;
            }
            if (Searchin.list12.Count > 0)
            {
                button1.Enabled = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach(Searchin searchin in Searchin.list12)
                    {
                        searchin.WriteInfo(streamWriter);
                    }
                }
            }
        }

        private void ArraysSearchin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                using (StreamReader streamReader = new StreamReader(openFileDialog1.FileName))
                    while (!streamReader.EndOfStream)
                    {
                        string header = streamReader.ReadLine();
                        if (header == "Hotel") new Hotel(streamReader);
                        if (header == "Camper") new Camper(streamReader);
                    }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Searchin.list12.Clear();
            listBox1.Items.Clear();
            pictureBox1.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (Searchin.list12.Count > 0)
            {
                numericUpDown1.Update();
                numericUpDown1.Maximum = Searchin.list12.Count-1;
                numericUpDown1.Update();
                int index = (int)numericUpDown1.Value;

                Searchin.list12.RemoveAt(index);
                listBox1.Update();
                pictureBox1.Update();
            }
            else
            {
                button6.Enabled = false;
            }
        }
    }
}
