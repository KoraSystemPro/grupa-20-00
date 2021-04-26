using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static bool JednakeListe(List<int> lista1, List<int> lista2)
        {
            // Da li su iste duzine
            if (lista1.Count != lista2.Count)
            {
                return false;
            }

            // Da li su im svi clanovi jednaki
            for(int i = 0; i < lista1.Count; i++)
            {
                if(lista1[i] != lista2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static int UporediListe(List<int> lista1, List<int> lista2)
        {
            // l1: 5 4 3 2 1
            // l2: 5 4 1 2 3
            // i:  0 1 2 3 4
            // Prvo mesto gde se liste ne poklapaju => i=2
            int n1 = lista1.Count;
            int n2 = lista2.Count;
            int n;
            if (n1 < n2)
            {
                n = n1;
            }
            else
            {
                n = n2;
            }
            
            for (int i = 0; i <= n; i++)
            {
                if(i == n || lista1[i] != lista2[i])
                {
                    return i ;
                }
            }

            return n;
        }

        static void Main(string[] args)
        {
            List<int> brojevi1 = new List<int>();
            Console.WriteLine("Unesite brojeve u prvu listu sve dok se ne unese q.");
            while (true)
            {
                string linija = Console.ReadLine();
                if(linija == "q")
                {
                    break;
                }
                brojevi1.Add(Convert.ToInt32(linija));
            }

            List<int> brojevi2 = new List<int>();
            Console.WriteLine("Unesite brojeve u drugu listu sve dok se ne unese q.");
            while (true)
            {
                string linija = Console.ReadLine();
                if (linija == "q")
                {
                    break;
                }
                brojevi2.Add(Convert.ToInt32(linija));
            }

            if(JednakeListe(brojevi1, brojevi2) == true)
            {
                Console.WriteLine("Liste su identicne!");
            }
            else
            {
                Console.WriteLine("Liste nisu jednake!");
            }


            //for(int i = 0; i < brojevi.Count; i++)
            //{
            //    Console.Write(brojevi[i] + " ");
            //}

            //foreach (int broj in brojevi)
            //{
            //    Console.Write(broj + " ");
            //}
            Console.WriteLine(UporediListe(brojevi1, brojevi2));
            Console.ReadKey();

        }
    }
}
