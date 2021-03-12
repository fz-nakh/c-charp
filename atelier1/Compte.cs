using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compteb
{
    class Compte
    {
        static int cpt = 0;
        Mad plafond = new Mad(3000);
        private int Numcompte;
        private Mad solde;
        private Personne titulaire;

        public Compte(Mad s, Personne p)
        {
            Numcompte = ++cpt;
            solde =s;
            titulaire = new Personne(p);
        }

        public void retirer(Mad s)
        {
            if (this.solde > s && s < plafond)
                this.solde = this.solde - s;

        }
        public void ajouter(Mad s)
        {
            solde += s;
        }
        public void verser_compte(Compte c, Mad s)
        {
            
            if (this.solde > s) { 
                this.solde = this.solde - s;
                c.solde = c.solde + s;
            }
        }
        public void consulter()
        {
            Console.WriteLine("le  Numcompte: ");

            titulaire.afficher();
            solde.print();

        }
    }
}





