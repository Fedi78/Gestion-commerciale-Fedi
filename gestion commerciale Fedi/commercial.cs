using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commerciale_Fedi

{
    class Commercial
    {
        string prenom; 
        int anneeNaissance;
        string nom;
       

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }

        public Commercial(string pprenom, string pnom, int panneeNaissance)
        {
            this.Prenom = pprenom;
            this.Nom = pnom;
            this.AnneeNaissance = panneeNaissance;
        }
         public int calculAge()
        {
            return DateTime.Now.Year - this.AnneeNaissance;
        }
        public override string ToString()
        {
            return " Nom " + this.nom + " Prenom " + this.prenom + " Annee de Naissance " + this.anneeNaissance;
        }

    }
}

   