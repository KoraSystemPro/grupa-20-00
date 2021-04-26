using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    class Program
    {

        static List<double> IzbaciDuplikate(List<double> lista)
        {
            List<double> originali = new List<double>();
            for(int i = 0; i < lista.Count; i++)
            {
                if (originali.Contains(lista[i]) == false)
                {
                    originali.Add(lista[i]);
                }
            }

            return originali;
        }


        static List<double> IzbaciDuplikateSortirana(List<double> lista)
        {
            // 3 1 8 3 7 9 8 8
            // --- sortiramo ----
            // 1 3 7 8 9
            //         x y ->
            int x = 0;
            while (x < lista.Count)
            {
                int y = x + 1;
                // Da li mozemo da stavimo y?
                if(y == lista.Count)
                {
                    break;
                }
                // Ako je nadjen duplikat, skidamo ga sa liste
                if(lista[x] == lista[y])
                {
                    lista.RemoveAt(y);
                } else
                {
                    x++;
                }
            }
            
            return lista;

        }

        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            // Unos 
            while (true)
            {
                string linija = Console.ReadLine();
                if (linija == "q")
                {
                    break;
                }
                lista.Add(Convert.ToDouble(linija));
            }

            // Sortiranje - rastuce
            //lista.Sort();

            // Sortiranje - opadajuce
            //lista.Sort();
            //lista.Reverse();

            // Izbacivanje duplikata sortirane liste
            //lista.Sort();
            //lista = IzbaciDuplikateSortirana(lista);

            // Izbaci duplikate nesortirane liste
            lista = IzbaciDuplikate(lista);
            

            // Ispis
            foreach(double broj in lista)
            {
                Console.Write(broj + " ");
            }

            Console.ReadKey();
        }

        
    }
}
