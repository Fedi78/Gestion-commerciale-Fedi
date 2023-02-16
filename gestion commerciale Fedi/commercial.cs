using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commerciale_Fedi

{
    class Commercial
    {
        private string prenom; 
        private int anneeNaissance;
        private string nom;
        private Categorie cat;

       

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        internal Categorie Cat { get => cat; set => cat = value; }

        public Commercial(string pprenom, string pnom, int panneeNaissance, Categorie cat)
        {
            this.Prenom = pprenom;
            this.Nom = pnom;
            this.AnneeNaissance = panneeNaissance;
            this.Cat = cat;
        }
         public int calculAge()
        {
            int diff = DateTime.Now.Year - this.AnneeNaissance;
            return diff;
        }
        public override string ToString()
        {
            return "Nom : " + this.nom + "\nPrenom : " + this.prenom + "\nAnnee de Naissance : " + this.anneeNaissance + "\nLe commercial a " + calculAge() + " ans.\n" + this.Cat;
        }

    }
}

   