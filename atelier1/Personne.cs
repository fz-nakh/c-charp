using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compteb
{
    class Personne
    {
        private string nom;
        private string prenom;
        private string adresse;
        public Personne( Personne  p)
        {
            nom = p.nom;
            prenom = p.prenom;
            adresse = p.adresse;
        }
        public Personne(string n, string pn, string ad)
        {
            nom = n;
            prenom = pn;
            adresse = ad;
        }

        public void afficher()
        {
            Console.WriteLine("le nom: " + nom);
            Console.WriteLine("le prenom: " + prenom);
            Console.WriteLine("l'adresse:  " + adresse);
        }
       
    }
}

