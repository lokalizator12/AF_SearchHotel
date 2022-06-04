using System;
using System.Collections.Generic;
using System.IO;
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


        private void button5_Click(object sender, EventArgs e)
        {
            operation formCount = new operation();
            formCount.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
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
               
            }
            catch (Exception)
            {
                MessageBox.Show("nieprawidłowo wprowadzone dane w pliku tekstowym, nie według wzorca");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (Searchin searchin in Searchin.list12)
                    {
                        searchin.WriteInfo(streamWriter);
                        
                    }
                }
            }
        }

        

        public void refresh()
        {
            if (Searchin.list12.Count > 0)
            {
                button3.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
            }
            else if (Searchin.list12.Count == 0)
            {
                button5.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            refresh();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
