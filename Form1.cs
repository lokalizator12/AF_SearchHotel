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
    public partial class Form1 : Form
    {
        public List<Searchin> list1 = new List<Searchin>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            createSearch();
            Form formCamper = new Form3Camper();
            formCamper.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createSearch();
            Form formHotel = new Form2Hotel();
            formHotel.ShowDialog();
        }

        private void createSearch()
        {
            Searchin search1 = new Searchin(); 
            
        }

       
    }
}
