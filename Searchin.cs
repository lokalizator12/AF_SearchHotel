using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    public abstract class Searchin
    {
        protected string country, city, kemperOrHotel, cena;
        protected double moneyOf, moneyIn;
        protected int countDay = 0, countPerson = 0, countStarType = 0;
        bool onlinePayment;

        public string GetKemperOrString()
        {
            return kemperOrHotel;
        }
        //constructor does not arguments
        public Searchin()
        {
            country = "Lego-coutry";
            city = "Lego-city";
            countDay = 777;
            moneyOf = 777.777f;
            kemperOrHotel = "Not kemper and not hotel, i want live in street";
            moneyIn = 7777.7777f;
            cena = moneyOf.ToString() + " - " + moneyIn.ToString();
            countPerson = 10;
            countStarType = 5;
            onlinePayment = false;
        }

        //constructor with all arguments
        public Searchin(string country, string city, double moneyOf, double moneyIn, int countDay, int countPerson, int countStarType, bool onlinePayment)
        {
            this.country = country;
            this.city = city;
            this.moneyOf = moneyOf;
            this.moneyIn = moneyIn;
            this.countDay = countDay;
            this.countPerson = countPerson;
            this.countStarType = countStarType;
            cena = moneyOf.ToString() + " - " + moneyIn.ToString();
            this.onlinePayment = onlinePayment;

        }

        //distructor
        ~Searchin()
        {

        }

        //copy constructor
        public Searchin(Searchin search)
        {
            country = search.country;
            city = search.city;
            kemperOrHotel = search.kemperOrHotel;
            moneyOf = search.moneyOf;
            moneyIn = search.moneyIn;
            countDay = search.countDay;
            cena = search.moneyOf.ToString() + " - " + search.moneyIn.ToString();
            countPerson = search.countPerson;
            countStarType = search.countStarType;
            onlinePayment = search.onlinePayment;
        }

        public virtual void Write(ListBox resList)
        {
            resList.Items.Add("Type: " + kemperOrHotel);
            resList.Items.Add("Country: " + country);
            resList.Items.Add("City: " + city);
            resList.Items.Add("Count person: " + countPerson.ToString());
            resList.Items.Add("Count day: " + countDay.ToString());
            resList.Items.Add("Cena: " + cena.ToString());
            IsOnlinePayment(resList);

        }


        private void IsOnlinePayment(ListBox resList)
        {
            if (onlinePayment)
            {
                resList.Items.Add("Online payment");
            }
            else if (!onlinePayment)
            {
                resList.Items.Add("Payment in cash");
            }
        }

    }
}
