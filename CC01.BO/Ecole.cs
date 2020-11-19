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
        public int Pb { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }

        public Ecole()
        {
                
        }

        public Ecole(string nom, string adresse, int pb, double contact, string email)
        {
            Nom = nom;
            Adresse = adresse;
            Pb = pb;
            Contact = contact;
            Email = email;
        }
    }
}
