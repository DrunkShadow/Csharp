using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Bureau
    {
        private string code;
        private string nom;
        private Chercheur chercheur;
        public Bureau (string code, string nom)
        {
            this.code = code;
            this.nom = nom;

        }
        public string CODE
        {
            get { return code; }
            set { code = value; }
        }

        public string NOM
        {
            get { return nom; }
            set { nom = value; }
        }

        public Chercheur  CHERCHEUR
        {
            get { return chercheur ; }
        }
        public void Affiche()
        {
            Console.WriteLine(code + nom + " affecté au chercheur" + chercheur.NOM + chercheur.SPEC + chercheur.NUM_ORD);
        }
        public bool affecterChercheur(Chercheur c)
        {
        if(chercheur == null)
            {
                chercheur = c;
                return true;
            }
        else { return false; }
        }
        public int trouverOrdinateur()
        {
            return chercheur.NUM_ORD;
        }
    }
}
