using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    internal class Camper : Searchin
    {
        string camperOrHotel;
        char typeCamper;
        int countSleepNumber;
        private bool haveShower;
        private bool haveKitchen;
        private  bool haveRoomForPersonCar;


        public static List<Camper> CampersList = new List<Camper>();
        // counstructor nit arguments
        public Camper(StreamReader reader) : base(reader) { CampersList.Add(this); }

        public override void ReadInfo(StreamReader streamReader)
        {
            typeCamper = Convert.ToChar(streamReader.ReadLine());
            countSleepNumber = Convert.ToInt32(streamReader.ReadLine());
            if (streamReader.ReadLine().Equals("True")) { haveShower = true; } else { haveShower = false; }
            if (streamReader.ReadLine().Equals("True")) { haveRoomForPersonCar = true; } else { haveRoomForPersonCar = false; }
            if (streamReader.ReadLine().Equals("True")) { haveKitchen = true; } else { haveKitchen = false; }
            base.ReadInfo(streamReader);

        }
        public override void WriteInfo(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("Camper");
            streamWriter.WriteLine( typeCamper);
            streamWriter.WriteLine( countSleepNumber);
            streamWriter.WriteLine( haveShower);
            streamWriter.WriteLine(haveRoomForPersonCar);
            streamWriter.WriteLine( haveKitchen);
            base.WriteInfo(streamWriter);

        }
        public Camper() : base()
        {
            camperOrHotel = "camper, but i dont know, maybe hotel";
            haveShower = false;
            haveKitchen = false;
            countSleepNumber = 0;
            haveRoomForPersonCar = false;
            typeCamper = 'A';
        }

        //constructor with all arguments
        public Camper(string country, string city, double moneyOf, double moneyIn, int countDay, int countPerson, int countStarType, bool onlinePayment,
            char typeCamper, int countSleepNumber, bool haveShower, bool haveKitchen, bool haveRoomForPersonCar, DateTime dateOf, DateTime dateIn, Bitmap jmage)
            : base(country, city, moneyOf, moneyIn, countDay, countPerson, countStarType, onlinePayment, dateOf, dateIn, jmage)
        {
            camperOrHotel = "Camper";
            this.typeCamper = typeCamper;
            this.countSleepNumber = countSleepNumber;
            this.haveShower = haveShower;
            this.haveKitchen = haveKitchen;
            this.haveRoomForPersonCar = haveRoomForPersonCar;
        }

        //distructor
        ~Camper()
        {

        }

        //copy constructor 
        public Camper(Camper camper) : base(camper)
        {
            camperOrHotel = camper.camperOrHotel;
            typeCamper = camper.typeCamper;
            countSleepNumber = camper.countSleepNumber;
            haveShower = camper.haveShower;
            haveKitchen = camper.haveKitchen;
            haveRoomForPersonCar = camper.haveRoomForPersonCar;
        }


        public override void Write(ListBox resListCamper, PictureBox pictureBox)
        {
            resListCamper.Items.Add("Search: " + camperOrHotel);
            base.Write(resListCamper, pictureBox);
            resListCamper.Items.Add("Type camper: " + typeCamper);
            resListCamper.Items.Add("Number of sleeping places: " + countSleepNumber);
            resListCamper.Items.Add("Have shower? : " + haveShower);
            resListCamper.Items.Add("Have kitchen? : " + haveKitchen);
            resListCamper.Items.Add("Have place for personality car? : " + haveRoomForPersonCar);
        }

        public void RecommendationsForTypeCamper()
        {
            if (countSleepNumber <= 2 && !haveShower && !haveKitchen && !haveRoomForPersonCar)
            {
                MessageBox.Show("Recomended: type A (Small Camper)");
            }
            else if (countSleepNumber <= 5 && !haveShower && !haveKitchen && !haveRoomForPersonCar)
            {
                MessageBox.Show("Recomended: type B (Pop up)");
            }
            else if (countSleepNumber <= 8 && !haveShower && haveKitchen && !haveRoomForPersonCar)
            {
                MessageBox.Show("Recomended: type C (Travel Trailer)");
            }
            else if (countSleepNumber <= 8 && haveShower && haveKitchen && haveRoomForPersonCar)
            {
                MessageBox.Show("Recomended: type D (Toyhauler.)");
            }
            else { MessageBox.Show("Please choose parametrs"); }
        }

        public void InfoTypeCamper()
        {
            MessageBox.Show("Type A: Small Camper. " +
                 "\nAll amenities and features have been designed to require as little space as possible," +
                 "\nAll amenities and features have been designed to require as little space as possible," +
                 "\n and allow the user to add or subtract different elements as they find their comfort level." +
                 "\n_____________________________________________________________________________" +
                 "\nType B: Pop Up.\nThese models are ideal for those new to RV camping, and families with young children." +
                "\nOffering both canvas tent and hard - top A - frame options, there is a right entry point for everyone." +
                "\n_____________________________________________________________________________" +
                "\nType C: Travel Trailer." +
                "\nThe Travel Trailer category offers a wide berth of options, including smooth - sided(laminates) and corrugated - sided(conventional)." +
                "\nThese trailers are known most for their slide-out feature, which expands the interior living space at the push of a button!" +
                "\n_____________________________________________________________________________" +
                "\nType D: Toyhauler." +
                "\nThese models offer wide availability, including everything from single-axle small travel trailer toy haulers, " +
                "\nall the way up to 40 + foot fifth wheel toy haulers." +
                "\nMake your selection based on use!");

        }
    }
}
