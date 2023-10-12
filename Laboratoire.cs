using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Laboratoire
    {
        private string nom;
        private string spec;
        private Bureau[] TabBureau = new Bureau[50];
        private int nbBureau=0;

        public Laboratoire(string nom, string spec)
        {
            this.nom = nom;
            this.spec = spec;
            TabBureau = new Bureau[50];
        }
        public string NOM
        {
            get { return nom; }
            set { nom = value; }
        }
        public string SPEC
        {
            get { return spec; }
            set { spec = value; }
        }
        public void ajouterBureau(Bureau bureau)
        {
            if (nbBureau < 50)
            {
                TabBureau[nbBureau] = bureau;
                nbBureau++;
            }
            else
            {
                Console.WriteLine("labo est saturé ");
            }
        }
        public void affiche()
        {
            Console.WriteLine(nom + " " + spec);
            for(int i=0; i<nbBureau; i++)
            {
                Console.WriteLine(TabBureau[i].CODE + " " + TabBureau[i].NOM + "affecté au" + TabBureau[i].CHERCHEUR.NOM + " " + TabBureau[i].CHERCHEUR.SPEC + " " + TabBureau[i].CHERCHEUR.NUM_ORD);
            }       
        }
        public bool appartenirBureau(int code)
        {
            for(int i=0;i<nbBureau; i++)
            {
                if(TabBureau[i].CODE == code.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        }

}

