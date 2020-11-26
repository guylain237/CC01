using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{[Serializable]
  public  class Carte
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Date_naissance { get; set; }
        public string Lieu { get; set; }
        public string Matricule { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Carte()
        {
        }

        public Carte(string nom, string prenom, string date_naissance, string lieu, string matricule, string contact, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Date_naissance = date_naissance;
            Lieu = lieu;
            Matricule = matricule;
            Contact = contact;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Carte carte &&
                   Matricule.Equals(carte.Matricule, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
