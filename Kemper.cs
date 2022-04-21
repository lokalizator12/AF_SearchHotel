using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    internal class Kemper : Searchin
    {
        string kemperOrHotel;


        // counstructor nit arguments
        public Kemper() : base()
        {
            kemperOrHotel = "Kemper, but i dont know, maybe hotel";
        }

        //constructor with all arguments
        public Kemper(string country, string city, float moneyOf, float moneyIn, int countDay, int countPerson, int countStarType, bool onlinePayment)
            : base(country, city, moneyOf, moneyIn, countDay, countPerson, countStarType, onlinePayment)
        {
            this.kemperOrHotel = "Kemper";
        }
        /*
                public string GetKemperOrString()
                {
                    return kemperOrHotel;
                }
        */
        //distructor
        ~Kemper()
        {

        }

        //copy constructor 
        public Kemper(Kemper kemper) : base(kemper)
        {
            this.kemperOrHotel = kemper.kemperOrHotel;
        }

        public override void Write(ListBox resListKemper)
        {
            resListKemper.Items.Add("Type: " + kemperOrHotel);
            base.Write(resListKemper);
        }
    }
}
