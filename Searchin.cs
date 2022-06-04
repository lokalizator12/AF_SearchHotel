using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace AF_SearchHotel
{

    public abstract class Searchin : IComparable<Searchin>
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
            countDay = 0;
            moneyOf = 777.777f;
            moneyIn = 7777.7777f;
            price = TotalPrice(moneyIn, moneyOf);
            countPerson = 10;
            countStarType = 5;
            onlinePayment = false;
            dateOf = DateTime.Now;
            dateIn = DateTime.Now;
        }

        protected Searchin(StreamReader reader)
        {
            ReadInfo(reader);
            list12.Add(this);
        }
        public virtual void WriteInfo(StreamWriter writer)
        {
            writer.WriteLine(country);
            writer.WriteLine(city);
            writer.WriteLine(countDay);
            writer.WriteLine(moneyOf);
            writer.WriteLine(moneyIn);
            writer.WriteLine(countPerson);
            writer.WriteLine(countStarType);
            writer.WriteLine(price);
            writer.WriteLine( onlinePayment);
            
            using (MemoryStream ms = new MemoryStream())
            {
                jmage.Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                writer.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));
            }
        }

        public virtual void ReadInfo(StreamReader streamReader)
        {
            country = streamReader.ReadLine();
            city = streamReader.ReadLine();
            countDay = Convert.ToInt32(streamReader.ReadLine());
            moneyOf = Convert.ToDouble(streamReader.ReadLine());
            moneyIn = Convert.ToDouble(streamReader.ReadLine());
            countPerson = Convert.ToInt32(streamReader.ReadLine());
            countStarType = Convert.ToInt32(streamReader.ReadLine());
            price = streamReader.ReadLine();
            if (streamReader.ReadLine().Equals("True")){onlinePayment = true;}else{onlinePayment = false;}
            byte[] bytes = Convert.FromBase64String(streamReader.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
            jmage = new Bitmap(ms);
        }

       
        public static int operator+(Searchin s1, int x)
        {
            return s1.countDay ;
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

        public int CompareTo(Searchin other)
        {
            if (other == null)
                return 1;
            if(String.Compare(this.country, other.country) == 1)
            {
                return 1;
            }else if(String.Compare(this.country, other.country) == -1)
            {
                return -1;
            }
            else
            {
                if(String.Compare(this.countDay.ToString(), other.countDay.ToString()) == 1)
                {
                    return 1;
                }else if(String.Compare(this.countDay.ToString(), other.countDay.ToString()) == 0)
                {
                    return -1;
                }
            }
            throw new NotImplementedException();
        }
    }
}
