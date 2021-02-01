using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // cout --> Console.ReadLine()
            // cin  --> Console.WriteLine()
            /*
                Ovo je komentar
                zapisan u vise
                linija
            */
            //Console.WriteLine("Ovo je moj prvi programu C#");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uneti broj je: " + a);

            // // Tipovi promenljivih
            // int broj = 5;           // long, unsigned
            // double pi = 3.14159;    
            // char slovo = 'A';
            // string ime = "Luka";
            // bool prover = true;


            int x;
            x = 5;
            //int z = x + a;
            //Console.WriteLine("a + 5 = " + z);

            double razlomeljni = 5.999999;
            int ceo = (int)razlomeljni; // kastujem double u int 5
            ceo = (int)Math.Round(razlomeljni);
            Console.WriteLine(ceo);

            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite godine: ");
            int godine = Convert.ToInt32(Console.ReadLine());
            if (godine >= 14)
            {
                Console.WriteLine("Dobrodosao, " + ime + "!\n");
            }
            else
            {
                Console.WriteLine("Begaj kidaro!");
            }

            // Nizovi 1D
            //Console.WriteLine("Unesite dimenziju niza: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] A = new int[n];
            //Console.WriteLine("Unesite clanove niza: ");
            //for (int i = 0; i < n; i++)
            //{
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Niz A: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            // Nizovi 2D (matrica)
            Console.WriteLine("Unesite dimenziju niza: ");
            int k = Convert.ToInt32(Console.ReadLine().Split());
            int l = Convert.ToInt32(Console.ReadLine().Split());
            int[,] M = new int[k, l];
            Console.WriteLine("Unesite clanove niza: ");
            for (int i = 0; i < k; i++)
            {
                for(int j = 0; j < l; j++)
                {
                    M[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Niz A: ");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.WriteLine(M[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
