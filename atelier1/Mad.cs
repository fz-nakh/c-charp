using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compteb

{
    class Mad
    {
        private double valeur;
        public Mad(Mad m) 
        {
            valeur = m.valeur;
        }
        public Mad(double val) 
        {
           valeur = val;
        }
        public void print()
        {
            Console.WriteLine("le solde: " + valeur + "MAD");
        }
        
        public static bool operator >(Mad a, Mad b)
        {
            if (a.valeur > b.valeur)
                return true;
            else
                return false;
        }
        public static bool operator <(Mad a, Mad b)
        {
            if (a.valeur < b.valeur)
                return true;
            else
                return false;
        }
        public static Mad operator +(Mad a, Mad b)
        {
            double s = a.valeur + b.valeur;
            return new Mad(s);
        }
        public static Mad operator -(Mad a, Mad b)
        {
            double d = a.valeur - b.valeur;
            return new Mad(d);
        }
    }
}
