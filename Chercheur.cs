using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Chercheur
    {
        private string nom;
        private string spec;
        private int numOrd;
        public Chercheur(string nom, string spec,int numOrd)
        {
            this.nom = nom;
            this.spec = spec;
            this.numOrd = numOrd;
        }
        public int NUM_ORD
        {
            get { return numOrd; }
            set { numOrd = value; }
        }

        public string NOM
        {
            get { return nom; }
        }
        public string SPEC
        {
            get { return spec;  }
        }
        public void Affiche()
        {
            Console.WriteLine("le nom est: " + nom + ", la spec est: " + spec + "le num d'ord est: " + numOrd);
        }
        public bool Compare(Chercheur c)
        {
            return (nom == c.nom && numOrd == c.numOrd && spec == c.spec);
        }
    }
}
