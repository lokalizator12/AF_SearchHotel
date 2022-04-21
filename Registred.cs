using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_SearchHotel
{
     public class Registred 
    {
        // NO READ !!!
        // THIS 5-6 LISTA
        private string firstName, lastName, city, country, numberPh;
        private double haveMoney;
        private int year;

        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public string GetCity() { return city; }
        public string GetCountry() { return country; }
        public string GetNumberPh() { return numberPh; }
        public int GetDateBirthday() { return year; }


        //anonim constructor create
        public Registred()
        {
            this.firstName = "person";
            this.lastName = "person";
            this.city = "PC";
            this.country = "Mars";
            this.numberPh = "777777777";
            this.year = 99;
        }
        //create constructor static profile 
        public Registred(string firstName, string lastName, string city, string country, string numberPh, int year)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.country = country;
            this.numberPh = numberPh;
            this.year = year;

        }

        //create destructor
         ~Registred()
        {
            MessageBox.Show("Likwidacja obiektu klas.");
        }
        // copy-constructor
        public Registred(Registred profileCopy)
        {
            this.firstName = profileCopy.firstName;
            this.lastName = profileCopy.lastName;
            this.city = profileCopy.city;
            this.country = profileCopy.country;
            this.year = profileCopy.year;
            this.numberPh = profileCopy.numberPh;
        }

        public virtual void printInfo()
        {
            MessageBox.Show("Name: " + firstName + " " + lastName + "\n location: " + country + 
                ", " + city + "\n Phone: " + numberPh + "\n Year: " + year);
        } 

    }
}
