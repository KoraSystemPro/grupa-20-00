using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // NIZOVI
            // Deklaracija niza
            //int[100000] niz_brojeva;

            // Deklaracaija i inicijalizacija
            int[] niz_brojeva = {3, 8, 15, 4};
            //     indeks        0  1  2   3
            for(int i = 0; i < niz_brojeva.Length; i++) // niz_brojeva.Length = 4
            {
                Console.WriteLine(niz_brojeva[i]);
            }
            // Console.WriteLine(niz_brojeva[1]);
            */

            // Liste
            // Dodajete, Skinete, Proverite da li nesto postoji u listi
            // Deklaracija liste
            //List<string> lista = new List<string>() { 
            //    "hleb", "jaja", "sir", "mleko", "jogurt"
            //};

            // Dodavanje clanova liste uz pomoc metode .Add()
            List<string> lista_za_kupovinu = new List<string>();
            lista_za_kupovinu.Add("Hleb");
            lista_za_kupovinu.Add("Jaja");
            lista_za_kupovinu.Add("Mleko");
            lista_za_kupovinu.Add("Jogurt");
            lista_za_kupovinu.Add("Sir");
            lista_za_kupovinu.Add("Ananas");
            lista_za_kupovinu.Add("Jogurt");
            // 2 2 2 2 4 4 2 2 6 7 8 9 2 2
            // 0 1 2 3 4 5 6 7 8 9 ....
            List<int> lista_brojeva = new List<int>() {
                2, 2, 2, 2, 4, 4, 8, 9, 2, 2, 3
            };

            for (int i = 0; i < lista_brojeva.Count; i++)
            {
                if(lista_brojeva[i] == 2)
                {
                    lista_brojeva.RemoveAt(i);
                    i--;
                }
                
            }
            for (int i = 0; i < lista_brojeva.Count; i++)
            {
                Console.WriteLine(lista_brojeva[i]);

            }
            //lista_za_kupovinu.Sort();
            int n = lista_za_kupovinu.Count;
            //for (int i = 0; i < n; i++) // niz_brojeva.Length = 4
            //{
            //    Console.WriteLine(lista_za_kupovinu[i]);
            //}

        }
    }
}
