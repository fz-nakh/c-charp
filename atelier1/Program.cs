using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compteb;

namespace compteb
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Compte c1 = new Compte(new Mad(20000), new Personne("fati", "nakh", "jdygedtkzvtedvk"));
            Compte c2 = new Compte( new Mad(1000), new Personne("salma", "nokh", "jdygeghkedvk"));
            
            
            c1.consulter();
            c2.consulter();
            
            c1.consulter();
            Console.WriteLine("retirer");
            c1.retirer(new Mad(20000000));
            c1.consulter();
            Console.WriteLine("ajouter");
            c1.ajouter(new Mad(209));
            c1.consulter();
            c1.verser_compte(c2, new Mad(2));
            c2.consulter();

            Console.ReadKey();

        }
    }
}

