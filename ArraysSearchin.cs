using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public partial class ArraysSearchin : Form
    {
        public ArraysSearchin()
        {
            InitializeComponent();
            refresh();
           
        }
        private int s = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            if (s == 0)
            {
                button1.Enabled = false;
                button2.Enabled = true;

            }
            else
            {
                --s;
                if (Searchin.list12.Count > 0)
                    Searchin.list12[s].Write(listBox1, pictureBox1);
                
                if (Searchin.list12.Count > 1)
                {
                    button1.Enabled = true;

                }
                if (Searchin.list12.Count > 0)
                {
                    button2.Enabled = true;
                }
                refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Searchin.list12.Count > 0)
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
            refresh();
            pictureBox1.Visible = true;
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
            refresh();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    using (StreamReader streamReader = new StreamReader(openFileDialog1.FileName))
                        while (!streamReader.EndOfStream)
                        {
                            string header = streamReader.ReadLine();
                            if (header == "Hotel") new Hotel(streamReader);
                            if (header == "Camper") new Camper(streamReader);
                        }
                button2.Enabled = true;
                numericUpDown1.Maximum = Searchin.list12.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("nieprawidłowo wprowadzone dane w pliku tekstowym, nie według wzorca");
            }
            refresh();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            Searchin.list12.Clear();
            listBox1.Items.Clear();
            pictureBox1.Visible = false;
            refresh();
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
                listBox1.Items.Clear();
                
            }
            else
            {
                button6.Enabled = false;
            }
            refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
           refresh();
           Searchin.list12.Sort();
           listBox1.Items.Clear();
    }

        private void refresh()
        {
            numericUpDown1.Maximum = Searchin.list12.Count;
            if (Searchin.list12.Count > 0)
            {
                
                button1.Enabled = true;
                button2.Enabled = true;
                button6.Enabled = true;
                button5.Enabled = true;
                numericUpDown1.Enabled = true;
                button7.Enabled = true;
                

            }
            else if (Searchin.list12.Count == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                numericUpDown1.Enabled = false;
                pictureBox1.Visible = false;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ArraysSearchin_Load(object sender, EventArgs e)
        {

        }
    }
}
