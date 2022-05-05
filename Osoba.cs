using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    class Osoba
    {
        protected string jmeno;
        protected string prijmeni;
        protected int vyska;
        protected double hmotnost;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                string p = value;
                Char.ToUpper(p[0]);
                jmeno = p[0] + p.Substring(1);
            }
        }
        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                string p = value;
                Char.ToUpper(p[0]);
                prijmeni = p[0] + p.Substring(1);
            }
        }
        public int Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if (value >= 35 && value <= 300)
                {
                    vyska = value;
                }
                else if (value >= 100) value /= 100;
                vyska = value;
            }
        }
        public double Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if (hmotnost >= 2 && hmotnost <= 500)
                {
                    hmotnost = value;
                }
            }
        }

        public Osoba(string jmeno, string prijmeni, int vyska, double hmotnost)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vyska = vyska;
            Hmotnost = hmotnost;
        }

        public double BMI()
        {
            return hmotnost / Math.Pow(vyska, 2);
        }

        public override string ToString()
        {
            string s = "\nJmeno: " + Jmeno
                        + "\nPrijmeni: " + Prijmeni
                        + "\nVyska: " + Vyska + " m"
                        + "\nHmotnost: " + Hmotnost + " kg"
                        + "\nBMI: " + BMI();

            return base.ToString() + "\n" + s;
        }


    }
}
