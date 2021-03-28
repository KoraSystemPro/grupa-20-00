using System;
using System.Collections.Specialized;
using System.Globalization;

namespace Vezbanje
{
    class Program
    {
        static void NacrtajPopunjenProvugaonik(int visina, int sirina)
        {
            /*
                4 6
                X X X X X X
                X X X X X X
                X X X X X X
                X X X X X X
            */
            for(int i = 0; i < visina; i++)
            {
                for(int j = 0; j < sirina; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPrazanPravougaonik(int visina, int sirina)
        {
            /*
                4 6
                X X X X X X
                X         X
                X         X
                X X X X X X
            */
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if(i == 0 || j == 0 || i == visina - 1 || j == sirina - 1)
                    {
                        Console.Write("X ");
                    } 
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPrazanKvadratSaDijagonalom(int a)
        {
            /*
                6
                X X X X X X
                X X       X
                X   X     X
                X     X   X
                X       X X
                X X X X X X
            */
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == 0 || j == 0 || i == a - 1 || j == a - 1 || i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPrazanKvadratSaDijagonalama(int a)
        {
            /*
                6
                X X X X X X
                X X     X X
                X   X X   X
                X   X X   X
                X X     X X
                X X X X X X
            */
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == 0 || j == 0 || i == a - 1 || j == a - 1 || i == j || i == a - j - 1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPoluPiramiduIkseva(int n)
        {
            /*
                6
                X
                X X
                X X X
                X X X X
                X X X X X
                X X X X X X
            */
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPoluPiramiduBrojeva(int n)
        {
            /*
                6
                1
                1 2
                1 2 3 
                1 2 3 4
                1 2 3 4 5
                1 2 3 4 5 6
            */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPoluPiramiduBrojevaNaopacke(int n)
        {
            /*
                6
                6 5 4 3 2 1
                6 5 4 3 2
                6 5 4 3
                6 5 4
                6 5
                6
             */
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void NacrtajPiramiduZvezdica(int n)
        {
            /*
                5
                        *
                      * * * 
                    * * * * * 
                  * * * * * * * 
                * * * * * * * * *
                 
                3
                  *
                * * *
              * * * * * 
             
            */
            int br_zvezda = 1;
            for(int i = 0; i < n; i++)
            {
                // Ispisujemo razmake
                for (int razmak = 0; razmak < n - i - 1; razmak++)
                {
                    Console.Write("  ");
                }
                // Ispisujemo zvezdice
                for (int j = 0; j < br_zvezda; j++)
                {
                    Console.Write("* ");
                }
                br_zvezda += 2;

                Console.WriteLine();

            }
        }

        static void PaskalovTrougao(int n)
        {
            int koef = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        koef = 1;
                    }
                    else
                    {
                        koef = koef * (i - j + 1) / j;
                    }
                    Console.Write(koef + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PaskalovTrougao(8);
            

            Console.ReadKey();
        }
    }
}
