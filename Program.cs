using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Chercheur c1 = new Chercheur("Taha","info",15);
            Chercheur c2 = new Chercheur("ahmad","technique",12);
            Bureau b1 = new Bureau("1234","b-one");
            Bureau b2 = new Bureau("4321","b-two");
            b1.affecterChercheur(c1);
            b2.affecterChercheur(c2);
            Laboratoire l1 = new Laboratoire("labo1","info");
            l1.ajouterBureau(b1);
            l1.ajouterBureau(b2);
            l1.affiche();
            if (c1.Compare(c2))
            {
                Console.WriteLine("ils sont identiques");
            }
            else
            {
                Console.WriteLine("ils sont differents");
            }

            if (l1.appartenirBureau(1234))
            {
                Console.WriteLine("le bureau existe");
            }
            else
            {
                Console.WriteLine("le bureau n'existe pas");

            }

            string  ch = Console.ReadLine();
        }
    }
}
