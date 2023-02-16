using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commerciale_Fedi
{
    internal class Categorie
    {
        private string CodeCategorie;
        private string LibCategorie;
        private string Salaries;

        public string CodeCategorie1 { get => CodeCategorie; set => CodeCategorie = value; }
        public string LibCategorie1 { get => LibCategorie; set => LibCategorie = value; }
        public string Salaries1 { get => Salaries; set => Salaries = value; }

        public Categorie(string codeCategorie, string libCategorie)
        {
            this.CodeCategorie = codeCategorie;
            this.LibCategorie = libCategorie;
        }
        public override string ToString()
        {
            return "Son code est " + this.CodeCategorie + " et son libellé est " + this.LibCategorie+ ".\n\n";
        }
    }
}
