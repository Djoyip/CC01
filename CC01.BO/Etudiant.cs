using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant : Ecole
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Nee { get; set; }
        public string A { get; set; }
        public string Sexe { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string Logo { get; set; }
        public string Matricule { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string nom, string prenom, DateTime nee, string a, string sexe, double contact, string email, byte[] photo, string logo, string matricule)
        {
            Nom = nom;
            Prenom = prenom;
            Nee = nee;
            A = a;
            Sexe = sexe;
            Matricule = matricule;
            Contact = contact;
            Email = email;
            Photo = photo;
            Logo = logo;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
