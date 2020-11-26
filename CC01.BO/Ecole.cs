using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int Bp { get; set; }
        public double ContactEcole { get; set; }
        public string EmailEcole { get; set; }
        public string Logo { get; set; }

        public Ecole()
        {
                
        }

        public Ecole(string nom, string adresse, int bp, double contactEcole, string emailEcole, string logo )
        {
            Nom = nom;
            Adresse = adresse;
            Bp = bp;
            ContactEcole = contactEcole;
            EmailEcole = emailEcole;
            Logo = logo;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Bp == ecole.Bp;
        }

        public override int GetHashCode()
        {
            return -1247926009 + Bp.GetHashCode();
        }
    }
}
