﻿using System.Windows.Forms;

namespace AF_SearchHotel
{
    internal class Camper : Searchin
    {
        readonly string camperOrHotel;
        readonly char typeCamper;
        readonly int countSleepNumber;
        private bool haveShower;
        private bool haveKitchen;
        private readonly bool haveRoomForPersonCar;


        // counstructor nit arguments
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
        public Camper(char typeCamper, int countSleepNumber, bool haveShower, bool haveKitchen, bool haveRoomForPersonCar)
            : base()
        {
            camperOrHotel = "Camper";
            this.typeCamper= typeCamper;
            this.countSleepNumber = countSleepNumber;
            this.haveShower = haveShower;
            this.haveKitchen= haveKitchen;
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


        public override void Write(ListBox resListCamper)
        {
            resListCamper.Items.Add("Search: " + camperOrHotel);
            base.Write(resListCamper);
            resListCamper.Items.Add("Type camper: " + typeCamper);
            resListCamper.Items.Add("Number of sleeping places: " + countSleepNumber);
            resListCamper.Items.Add("Have shower? : " + haveShower);
            resListCamper.Items.Add("Have kitchen? : " + haveKitchen);
            resListCamper.Items.Add("Have place for personality car? : " + haveRoomForPersonCar);
        }

        public void recommendationsForTypeCamper()
        {
            if (countSleepNumber <= 2 && !haveShower && !haveKitchen && !haveRoomForPersonCar && base.price <= 2000)
            {
                MessageBox.Show("Recomended: type A (Small Camper)");
            }
            else if (countSleepNumber <= 5 && !haveShower && !haveKitchen && !haveRoomForPersonCar && base.price <= 3000)
            {
                MessageBox.Show("Recomended: type B (Pop up)");
            }
            else if (countSleepNumber <= 8 && !haveShower && haveKitchen && !haveRoomForPersonCar && base.price <= 6000)
            {
                MessageBox.Show("Recomended: type C (Travel Trailer)");
            }
            else if (countSleepNumber <= 8 && haveShower && haveKitchen && haveRoomForPersonCar && base.price <= 10000)
            {
                MessageBox.Show("Recomended: type D (Toyhauler.)");
            }
            else { MessageBox.Show("Please choose parametrs"); }
        }

        public void infoTypeCamper()
        {
            if (typeCamper == 'A')
            {
                MessageBox.Show("Small Camper. " +
                     "\nAll amenities and features have been designed to require as little space as possible," +
                     "\nAll amenities and features have been designed to require as little space as possible," +
                     "\n and allow the user to add or subtract different elements as they find their comfort level.");
            }
            else if (typeCamper == 'B')
            {
                MessageBox.Show("Pop Up.\nThese models are ideal for those new to RV camping, and families with young children." +
                    "\nOffering both canvas tent and hard - top A - frame options, there is a right entry point for everyone.");
            }
            else if (typeCamper == 'C')
            {
                MessageBox.Show("Travel Trailer." +
                    "\nThe Travel Trailer category offers a wide berth of options, including smooth - sided(laminates) and corrugated - sided(conventional)." +
                    "\nThese trailers are known most for their slide-out feature, which expands the interior living space at the push of a button!");
            }
            else if (typeCamper == 'D')
            {
                MessageBox.Show("Toyhauler." +
                    "\nThese models offer wide availability, including everything from single-axle small travel trailer toy haulers, " +
                    "\nall the way up to 40 + foot fifth wheel toy haulers." +
                    "\nMake your selection based on use!");
            }

        }
    }
}
