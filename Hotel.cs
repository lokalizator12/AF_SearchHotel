using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    internal class Hotel : Searchin
    {
        //child class #1
        string camperOrHotel;
        private int floor;
        private int countRoom;
        private double rate;
        private bool haveBalcony;
        private bool haveWiFi;
        private bool freeBreakfast;
        private bool parking;
        


        public static List<Hotel> HotelList = new List<Hotel>();

        public  List<String> listPerson = new List<String>();
        public void AddPerson(string s)
        {
            listPerson.Add(s);
        }
        public void WritePerson(ListBox reslist)
        {

            if (listPerson.Count > 0)
            {
                reslist.Items.Add("List Person: ");
                for (int i = 0; i < listPerson.Count; i++)
                    reslist.Items.Add(listPerson[i]);
            }
        }
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
        public override void ReadInfo(StreamReader streamReader)
        {
            
            floor = Convert.ToInt32(streamReader.ReadLine());
            countRoom = Convert.ToInt32(streamReader.ReadLine());
            rate = Convert.ToDouble(streamReader.ReadLine());
            if (streamReader.ReadLine().Equals("True")) { haveBalcony = true; } else { haveBalcony = false; }
            if (streamReader.ReadLine().Equals("True")) { freeBreakfast = true; } else { freeBreakfast = false; }
            if ( streamReader.ReadLine().Equals("True")) { parking = true; } else { parking = false; }
            if (streamReader.ReadLine().Equals("True")) { haveWiFi = true; } else { haveWiFi = false; }
            base.ReadInfo(streamReader);

        }

        public override void WriteInfo(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("Hotel");
            streamWriter.WriteLine(floor);
            streamWriter.WriteLine(countRoom);
            streamWriter.WriteLine(rate);
            streamWriter.WriteLine( haveBalcony);
            streamWriter.WriteLine(freeBreakfast);
            streamWriter.WriteLine( parking);
            streamWriter.WriteLine(haveWiFi);
            base.WriteInfo(streamWriter);
        }
        //constructor with all arguments
        public Hotel(string country, string city, double moneyOf, double moneyIn, int countDay, int countPerson, int countStarType, bool onlinePayment,
            int floor, int countRoom, double rate, bool haveBalcony, bool haveWiFi, bool freeBreakfast, bool parking, DateTime dateOf, DateTime dateIn, Bitmap jmage)
            : base(country, city, moneyOf, moneyIn, countDay, countPerson, countStarType, onlinePayment, dateOf, dateIn, jmage)
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
        public Hotel(StreamReader stream) : base(stream)
        {
            HotelList.Add(this);
        }
        //distructor
        ~Hotel()
        {

        }

        public static bool operator!=(Hotel h1, Hotel h2)
        {
            return (h1.dateOf != h2.dateOf);

        }

        public static bool operator ==(Hotel h1, Hotel h2)
        {
            return (h1.dateOf == h2.dateOf);

        }

        public static int operator+(Hotel h1, int n1)
        {
            return h1.countDay + HotelList[n1].countDay;

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


        public override void Write(ListBox resListBox, PictureBox pictureBox)
        {
            resListBox.Items.Add("Type: " + camperOrHotel);
            base.Write(resListBox, pictureBox);
            resListBox.Items.Add("which floor: " + floor);
            resListBox.Items.Add("Rooms: " + countRoom);
            resListBox.Items.Add("Rate: " + rate);
            resListBox.Items.Add("Balcon: " + haveBalcony);
            resListBox.Items.Add("Wi-Fi: " + haveWiFi);
            resListBox.Items.Add("Parking: " + parking);
        }

        public void RecommendationsForRoomBaseMoney()
        {
            MessageBox.Show("If 0-100$: floor -- 10-12, 1 room, not have balcon, not have wi-fi and not have parking" +
                "\n_______________________________________________________________________________________" +
                "\nIf 100$ - 300$: floor -- 7-10, 1 room, not have balcon, have wi-fi and not have parking" +
                "\n______________________________________________________________________________________" +
                "\nIf 300$ - 500$: floor -- 5-7, 1-2 room, not have balcon, have wi-fi and not have parking" +
                "\n______________________________________________________________________________________" +
                "\nIf 500$ - 700$: floor -- 3-5, 1-2 room, not have balcon, have wi-fi and have parking" +
                "\n______________________________________________________________________________________" +
                "\nIf 700$ - 100000000$: floor -- 1-3, 1-3 room, have balcon, have wi-fi and have parking");
        }

        public void AdditionalServices()
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
