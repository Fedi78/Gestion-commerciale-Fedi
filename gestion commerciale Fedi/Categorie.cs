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

        public string CodeCategorie1 { get => CodeCategorie; set => CodeCategorie = value; }
        public string LibCategorie1 { get => LibCategorie; set => LibCategorie = value; }

        public Categorie(string CodeCategorie, string LibCategorie)
        {
            this.CodeCategorie = CodeCategorie;
            this.LibCategorie = LibCategorie;
        }
        public override string ToString()
        {
            return CodeCategorie + "" + LibCategorie;
        }
    }
}
