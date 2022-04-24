using System.Windows.Forms;

namespace AF_SearchHotel
{
    internal class Hotel : Searchin
    {
        //child class #1
        string camperOrHotel;
        private int floor;
        private int countRoom;
        private readonly double rate;
        private bool haveBalcony;
        private bool haveWiFi;
        private bool freeBreakfast;
        private readonly bool parking;
        


        // counstructor not arguments
        public Hotel() : base()
        {
            camperOrHotel = "Hotel but i dont know, maybe camper";
            rate = 1;
            haveBalcony = false;
            haveWiFi = false;
            freeBreakfast = false;
            parking = false;
            floor = 0;
            countRoom = 0;

        }

        //constructor with all arguments
        public Hotel(int floor, int countRoom, double rate, bool haveBalcony, bool haveWiFi, bool freeBreakfast, bool parking)
            : base()
        {
            camperOrHotel = "Hotel";
            this.floor = floor;
            this.countRoom = countRoom;
            this.rate = rate;
            this.haveBalcony = haveBalcony;
            this.haveWiFi = haveWiFi;
            this.freeBreakfast = freeBreakfast;
            this.parking = parking;
        }

        //distructor
        ~Hotel()
        {

        }

        //copy constructor 
        public Hotel(Hotel hotel) : base(hotel)
        {
            camperOrHotel = hotel.camperOrHotel;
            floor = hotel.floor;
            countRoom = hotel.countRoom;
            rate = hotel.rate;
            haveBalcony = hotel.haveBalcony;
            haveWiFi = hotel.haveWiFi;
            freeBreakfast = hotel.freeBreakfast;
            parking = hotel.parking;
        }

        public override void Write(ListBox resListBox)
        {
            resListBox.Items.Add("Type: " + camperOrHotel);
            base.Write(resListBox);
            resListBox.Items.Add("which floor: " + floor);
            resListBox.Items.Add("Rooms: " + countRoom );
            resListBox.Items.Add("Rate: " + rate );
            resListBox.Items.Add("Balcon: " + haveBalcony);
            resListBox.Items.Add("Wi-Fi: " + haveWiFi);
            resListBox.Items.Add("Parking: " + parking);
            
        }

        protected void recommendationsForRoomBaseMoney()
        {
            if (price <= 100)
            {
                MessageBox.Show("Recomended: floor -- 10-12, 1 room, not have balcon, not have wi-fi and not have parking");
            }else if( price <= 300)
            {
                MessageBox.Show("Recomended: floor -- 7-10, 1 room, not have balcon, have wi-fi and not have parking");
            }else if (price <= 500)
            {
                MessageBox.Show("Recomended: floor -- 5-7, 1-2 room, not have balcon, have wi-fi and not have parking");
            } else if (price <= 700)
            {
                MessageBox.Show("Recomended: floor -- 3-5, 1-2 room, not have balcon, have wi-fi and have parking");
            }else if (price <= 1000)
            {
                MessageBox.Show("Recomended: floor -- 1-3, 1-3 room, have balcon, have wi-fi and have parking");
            }
        }

        public void additionalServices()
        {
            MessageBox.Show("Additional Services which can be used inside the hotel." +
                "\nrepair of clothes and shoes, laundry and dry cleaning;" +
                "\nhairdressing services;" +
                "\nuse of sauna, steam room, swimming pool;" +
                "\nuse of the billiard room, gym and playgrounds;" +
                "\nsale of printed products, souvenirs;" +
                "\nflower and gift delivery;" +
                "\nuse of luggage storage or safe deposit box;" +
                "\ncar rental;" +
                "\nentertainment services;");
        }

    }
}
