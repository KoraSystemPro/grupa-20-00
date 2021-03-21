using System;
using System.Security.Cryptography.X509Certificates;

namespace Funkcije
{
    class Program
    {
        // def : f(x) = 6*x + 5
        static float F(float x)    // povratni_tip_fje ime_fje(argumenti_fj)
        {
            return 6 * x + 5;
        }

        // f(x) ->  0 < x < 1  -> True
        //            else     -> False
        static bool is_between_0_and_1(double x)
        {
            if (x > 0 && x < 1){
                return true;
            }
            else
            {
                return false;
            }
        }

        static void pozdravi_me(string puno_ime)
        {
            Console.WriteLine("Pozdrav " + puno_ime + " iz funkcije za pozdrave!");
            return;
        }


        // c^2 = a^2 + b^2 
        // c = sqrt(a^2 + b^2)
        static double pitagora(double a, double b)
        {
            double c;
            c = Math.Round(Math.Sqrt(a * a + b * b), 5);
            return c;
        }


        static void Main(string[] args)
        {
            /* 
             def : f(x) = 6*x + 5

             f(4) = 6*4 + 5 = 29

             y = 10
             f(y) = 6*10 + 5 = 65
             */

            // Poziv funckije
            float rez = F(5);        // F(5) = 35
            Console.WriteLine(rez);

            double broj = 0.351;
            Console.WriteLine(is_between_0_and_1(broj));

            string ime = Console.ReadLine();
            pozdravi_me(ime);

            double a = 5;
            double b = 10;
            double c = pitagora(a, b);
            Console.WriteLine("Duzina hipotenuze trougla sa stranicama a: " + a + " stranice b: " + b + " je: " + c);

            Console.ReadKey();
        }
    }
}
