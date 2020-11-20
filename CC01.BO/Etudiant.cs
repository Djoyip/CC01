using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant : Ecole 
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Nee { get; set; }
        public string A { get; set; }
        public string Sexe { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }

        public Etudiant()
        {
                
        }

        public Etudiant(string nom, string prenom, DateTime nee, string a, string sexe, double contact, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Nee = nee;
            A = a;
            Sexe = sexe;
            Contact = contact;
            Email = email;
        }
    }
}
