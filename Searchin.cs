using System.Collections.Generic;
using System.Windows.Forms;

namespace AF_SearchHotel
{
    
    public class Searchin
    {
        public List<Searchin> list1 = new List<Searchin>();

        protected string country, city, camperOrHotel;
        protected double moneyOf, moneyIn, price;
        protected int countDay = 0, countPerson = 0, countStarType = 0;
         bool onlinePayment;


        
        public string GetCamperOrString()
        {
            return camperOrHotel;
        }
        //constructor does not arguments
        public Searchin()
        {
            country = "Lego-coutry";
            city = "Lego-city";
            countDay = 777;
            moneyOf = 777.777f;
            moneyIn = 7777.7777f;
            price = totalPrice(moneyIn, moneyOf);
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
            this.price = totalPrice(moneyOf, moneyIn);
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
            camperOrHotel = search.camperOrHotel;
            moneyOf = search.moneyOf;
            moneyIn = search.moneyIn;
            countDay = search.countDay;
            price = totalPrice(search.moneyOf, search.moneyIn);
            countPerson = search.countPerson;
            countStarType = search.countStarType;
            onlinePayment = search.onlinePayment;
        }

        public virtual void Write(ListBox resList)
        {
            resList.Items.Add("Country: " + country);
            resList.Items.Add("City: " + city);
            resList.Items.Add("Count person: " + countPerson.ToString());
            resList.Items.Add("Count day: " + countDay.ToString());
            resList.Items.Add("Price: " + price.ToString());
            IsOnlinePayment(resList);

        }

        protected double totalPrice(double moneyOf, double moneyIn)
        {
            return moneyOf + moneyIn;
        }

        protected void IsOnlinePayment(ListBox resList)
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
