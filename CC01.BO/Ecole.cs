using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{[Serializable]
   public class Ecole
    {
        public string Nom_ecole { get; set; }
        public string Ville { get; set; }
        public string Devise { get; set; }
        public string statut { get; set; }

        public Ecole()
        {
        }

        public Ecole(string nom_ecole, string ville, string devise, string statut)
        {
            Nom_ecole = nom_ecole;
            Ville = ville;
            Devise = devise;
            this.statut = statut;
        }
    }
}
