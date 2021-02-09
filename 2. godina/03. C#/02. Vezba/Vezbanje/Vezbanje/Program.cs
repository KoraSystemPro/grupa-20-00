using System;

namespace Vezbanje
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * Povrsina i obim kruga           
            Console.WriteLine("Unesite poluprecnik kruga: ");
            double poluprecnik = Convert.ToDouble(Console.ReadLine());
            double obim = 2 * poluprecnik * Math.PI;
            double povrsina = Math.Pow(poluprecnik, 2) * Math.PI;
            Console.WriteLine("Obim: " + Math.Round(obim, 2));
            Console.WriteLine("Povrsina: " + Math.Round(povrsina, 2));
            */

            /*
             * Povrsina trougla (Heronov obrazac)           
            double a, b, c;
            Console.WriteLine("Unesite prvu stranicu trougla: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite drugu stranicu trougla: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite trecu stranicu trougla: ");
            c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;
            double povrsina = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Povrsina: " + Math.Round(povrsina, 2));
            */

            /* 
             * Ispis svih trocifrenih brojeva ciji je zbir cifara jednak n           
            int n;
            Console.WriteLine("Unesite broj: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 100; i < 1000; i++)
            {
                int j, d, s;
                j = i % 10;
                d = (i / 10) % 10;
                s = i / 100;
                int zbir = j + d + s;
                if (zbir == n)
                {
                    Console.WriteLine(i);
                }
            }
            */
            /*
             *  Za unetih n brojeva proveriti i ispisati koliko ima brojeva koji su 
             *  veci od a;
            int n, a, br = 0;
            Console.WriteLine("Unesite koliko se unosi brojeva: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite broj za proveru: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite sledecih " + n + " brojeva.");
            for(int i = 0; i < n; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if(k > a)
                {
                    br++;
                }
            }
            Console.WriteLine("Broj unetih brojeva koji su veci od " + a + " je: " + br + ".");
            */

            // Sabira sve trocifrene brojeve koji dele broj 11 bez ostatka

            Console.ReadKey();
        }
    }
}
