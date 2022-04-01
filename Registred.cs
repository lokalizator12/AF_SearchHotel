using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_SearchHotel
{
     internal class Registred : Form1
    {
        private List<Registred> profiles = new List<Registred>();

        private string login, pass;

        public Registred()
        {
            this.login = "null";
            this.pass = "null";
        }

        public void AddProfile(Registred newProf)
        {
            profiles.Add(newProf);
        }
        public Registred(string login, string pass)
        {
            this.login=login;
            this.pass=pass;
        }

        public void SetLogin(string login)
        {
            this.login = login;
        }

        private void SetPass(string pass)
        {
            this.pass = pass;
        }
        
       
        public void PrintProfile()
        {
            MessageBox.Show(login + "\n" + pass);
        }

        public void Registration()
        {
            SetLogin(GetText("login"));
            SetPass(GetText("pass"));
        }
    }
}
