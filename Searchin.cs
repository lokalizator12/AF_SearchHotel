using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AF_SearchHotel
{

    public abstract class Searchin
    {
        public static List<Searchin> list12 = new List<Searchin>();/////////////

        protected string country, city, camperOrHotel, price;
        protected double moneyOf, moneyIn;
        protected int countDay = 0, countPerson = 0, countStarType = 0;
        bool onlinePayment;
        protected DateTime dateOf, dateIn;
        Bitmap jmage;



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
            price = TotalPrice(moneyIn, moneyOf);
            countPerson = 10;
            countStarType = 5;
            onlinePayment = false;
            dateOf = DateTime.Now;
            dateIn = DateTime.Now;


        }


        //constructor with all arguments
        public Searchin(string country, string city, double moneyOf, double moneyIn, int countDay, int countPerson, int countStarType, bool onlinePayment, DateTime dateOf, DateTime dateIn, Bitmap jmage)
        {
            this.dateOf = dateOf;
            this.dateIn = dateIn;
            this.country = country;
            this.city = city;
            this.moneyOf = moneyOf;
            this.moneyIn = moneyIn;
            this.countDay = countDay;
            this.countPerson = countPerson;
            this.countStarType = countStarType;
            price = TotalPrice(moneyOf, moneyIn);
            this.onlinePayment = onlinePayment;
            this.jmage = jmage;
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
            price = TotalPrice(search.moneyOf, search.moneyIn);
            countPerson = search.countPerson;
            countStarType = search.countStarType;
            onlinePayment = search.onlinePayment;
            dateOf = search.dateOf;
            dateIn = search.dateIn;
        }

        public virtual void Write(ListBox resList, PictureBox picturBox)
        {
            resList.Items.Add("Country: " + country);
            resList.Items.Add("City: " + city);
            resList.Items.Add("Count person: " + countPerson.ToString());
            resList.Items.Add("Count day: " + countDay.ToString());
            resList.Items.Add("Price: " + price.ToString());
            resList.Items.Add("Period: " + dateOf.ToString() + " - " + dateIn.ToString());
            IsOnlinePayment(resList);
            picturBox.Image = jmage;
        }



        protected String TotalPrice(double moneyOf, double moneyIn)
        {
            return Convert.ToString(moneyOf) + " - " + Convert.ToString(moneyIn);
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
