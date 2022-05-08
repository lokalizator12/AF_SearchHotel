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
    public partial class Count : Form
    {
        public Count()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberAndType(Hotel.HotelList, Camper.CampersList);
        }

        private void NumberAndType(List<Hotel> hotels, List<Camper> campers)
        {
            int sum = sumNum(hotels.Count, campers.Count);
            if (campers == null && hotels != null) MessageBox.Show("Hotel: " + hotels.Count + "\nCamper: 0 \nAll: " + sum);
            else if(campers != null && hotels == null)  MessageBox.Show("Hotel: 0" + "\nCamper: 0 \nAll: " + sum);
            else if (campers != null && hotels != null) MessageBox.Show("Hotel: " + hotels.Count + "\nCamper: " + campers.Count + "\nAll: " + sum);
            
        }

        public int sumNum(int intHotel, int intCamper)
        {
            return intHotel + intCamper;
        }
    }
}
