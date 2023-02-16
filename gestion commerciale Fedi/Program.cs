// EL Manoubi Fedi
using System;
 namespace gestion_commerciale_Fedi
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorie cat1 = new Categorie("001", "salaries");
            Categorie cat2 = new Categorie("002", "indep");

            Commercial c1 = new Commercial("abdel", "abdel", 1975, cat1);
            Commercial c2 = new Commercial("fedi", "fedi", 2003, cat2);
            Commercial c3 = new Commercial("antoine", "antoine", 2000, cat1);
            

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);


            
         


        }


    }

}