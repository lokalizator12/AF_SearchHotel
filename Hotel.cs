using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    internal class Hotel : Searchin
    {
        //child class #1
        string kemperOrHotel;



        // counstructor nit arguments
        public Hotel() : base()
        {
            kemperOrHotel = "Hotel but i dont know, maybe kemper";
        }

        //constructor with all arguments
        public Hotel(string country, string city, double moneyOf, double moneyIn, int countDay, int countPerson, int countStarType, bool onlinePayment)
            : base(country, city, moneyOf, moneyIn, countDay, countPerson, countStarType, onlinePayment)
        {
            this.kemperOrHotel = "Hotel";
        }
        /*
                public string GetKemperOrString()
                {
                    return kemperOrHotel;
                }
        */
        //distructor
        ~Hotel()
        {

        }

        //copy constructor 
        public Hotel(Hotel hotel) : base(hotel)
        {
            this.kemperOrHotel = hotel.kemperOrHotel;
        }

        public override void Write(ListBox resListBox)
        {
            resListBox.Items.Add("Type: " + kemperOrHotel);
            base.Write(resListBox);
        }


    }
}
