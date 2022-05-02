using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private int vyska;
        private double hmotnost;

        public Osoba(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public Osoba(string jmeno, string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }

        public Osoba(string jmeno, string prijmeni, int vyska, double hmotnost)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            if (vyska >= 15 && vyska <= 300)
            {
                this.vyska = vyska;
            }
            if (hmotnost >= 1 && hmotnost <= 500)
            {
                this.hmotnost = hmotnost;
            }

        }

        public string GetJmeno()
        {
            return jmeno;
        }

        //set jmeno nedovolime
        public string GetPrijmeni()
        {
            return prijmeni;
        }

        public void SetPrijmeni(string prijmeni)
        {
            this.prijmeni = prijmeni;
        }

        public int GetVyska()
        {
            return vyska;
        }

        public void SetVyska(int vyska)
        {
            if (vyska >= 15 && vyska <= 300)
            {
                this.vyska = vyska;
            }

        }
        public double GetHmotnost()
        {
            return hmotnost;
        }

        public void SetHmotost(double hmotnost)
        {
            if (hmotnost >= 1 && hmotnost <= 500)
            {
                this.hmotnost = hmotnost;
            }
        }

        public double BMI()
        {
            double bmi = ((double)hmotnost / (vyska * vyska)) / 10;
            return bmi;
        }

        public override string ToString()
        {
            string s = "\nJmeno: " + jmeno
                        + "\nPrijmeni: " + prijmeni
                        + "\nVyska: " + vyska + " cm"
                        + "\nHmotnost: " + hmotnost + " kg"
                        + "\nBMI: " + BMI();

            return base.ToString() + "\n" + s;
        }


    }
}
