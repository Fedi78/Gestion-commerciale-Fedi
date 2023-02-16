using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commerciale_Fedi
    {
        internal class Service
        {
            private string nomService;
            private int effectif;
            private Commercial[] tabCom;

            public string NomService { get => nomService; set => nomService = value; }
            public int Effectif { get => effectif; set => effectif = value; }
            internal Commercial[] TabCom { get => tabCom; set => tabCom = value; }

            public Service(string nomService)
            {
                this.TabCom = new Commercial[10];
                this.Effectif = 0;
                this.NomService = nomService;
            }
            public void ajouterUnCom(Commercial c)
            {
                this.tabCom[this.effectif] = c;
                this.Effectif++;

            }

            public override string ToString()
            {
                return " Dans le service " + this.NomService + ".\n\n";
            }

            public void afficheCom()
            {
                Console.WriteLine("Liste du service" + this.NomService + "\n");
                foreach (Commercial c in tabCom)
                {
                    if (c != null)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            public void leplusAge()
            {
                Commercial leplusAge = this.tabCom[0];
                foreach (Commercial em in this.TabCom)
                {
                    if (em != null && em.AnneeNaissance < leplusAge.AnneeNaissance)
                    {
                        leplusAge = em;
                    }
                }
                Console.WriteLine("Le Commerciale le plus Agé est : \n" + leplusAge);


            }
        }
    }

    

