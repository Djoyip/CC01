using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int Bp { get; set; }
        public double ContactEcole { get; set; }
        public string EmailEcole { get; set; }

        public Ecole()
        {
                
        }

        public Ecole(string nom, string adresse, int bp, double contactEcole, string emailEcole)
        {
            Nom = nom;
            Adresse = adresse;
            Bp = bp;
            ContactEcole = contactEcole;
            EmailEcole = emailEcole;
        }
    }
}
