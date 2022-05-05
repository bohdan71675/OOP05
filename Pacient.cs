using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    class Pacient : Osoba
    {
        private double obvodpasu = 0;

        public double ObvodPasu
        {
            get { return obvodpasu; }
            set
            {
                if (value <= 2)
                {
                    obvodpasu = value;
                }
                else
                {
                    value = value / 10;
                    obvodpasu = value;
                }
            }
        }

        public Pacient(string jmeno, string prijmeni, int vyska, double hmotnost, double obvodpasu) : base(jmeno, prijmeni, vyska, hmotnost)
        {
            ObvodPasu = obvodpasu;
        }


        public double ABSI()
        {
            return obvodpasu / (Math.Pow(BMI(), (double)2/3) + Math.Sqrt(vyska));
        }

        public override string ToString()
        {
            return base.ToString() + "\nObvod pasu je " + ObvodPasu + "\nABSI je " + ABSI();
        }
    }
}
