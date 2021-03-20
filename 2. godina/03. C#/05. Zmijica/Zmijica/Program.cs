using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zmijica
{
    class Program
    {
        enum Smer
        {
            Gore, 
            Dole, 
            Levo,
            Desno
        }

        static Smer promeni_smer(Smer smer_kretanja)
        {
            if (Console.KeyAvailable)
            {
                var dugme = Console.ReadKey(true).Key;
                if (dugme == ConsoleKey.UpArrow && smer_kretanja != Smer.Dole)
                {
                    smer_kretanja = Smer.Gore;
                }
                else if (dugme == ConsoleKey.DownArrow && smer_kretanja != Smer.Gore)
                {
                    smer_kretanja = Smer.Dole;
                }
                else if (dugme == ConsoleKey.LeftArrow && smer_kretanja != Smer.Desno)
                {
                    smer_kretanja = Smer.Levo;
                }
                else if (dugme == ConsoleKey.RightArrow && smer_kretanja != Smer.Levo)
                {
                    smer_kretanja = Smer.Desno;
                }
            }
        }
        static void nacrtaj_piksel(int x, int y, ConsoleColor boja)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = boja;
            Console.Write('█');
        }

        static void nacrtaj_ivice(int prozorSirina, int prozorVisina)
        {
            // Crta gornju ivicu
            for (int i = 0; i < prozorSirina; i++)
            {
                nacrtaj_piksel(i, 0, ConsoleColor.White);
            }
            // Crta donju ivicu
            for (int i = 0; i < prozorSirina; i++)
            {
                nacrtaj_piksel(i, prozorVisina - 1, ConsoleColor.White);
            }
            // Crta levu ivicu
            for (int i = 0; i < prozorVisina; i++)
            {
                nacrtaj_piksel(0, i, ConsoleColor.White);
            }
            // Crta desnu ivicu
            for (int i = 0; i < prozorVisina; i++)
            {
                nacrtaj_piksel(prozorSirina - 1, i, ConsoleColor.White);
            }
        }

        static void Main(string[] args)
        {
            // █ - 219
            // ▄ - 220

            // Boja konzole
            Console.BackgroundColor = ConsoleColor.Black;
            // Boja zmije
            Console.ForegroundColor = ConsoleColor.White;

            // Ako drzite alt i ukucate neki od ova dva koda
            // dobicete odgovarajucu figuru
            Console.WindowHeight = 16;
            Console.WindowWidth = 32;
            int prozorSirina = Console.WindowWidth;
            int prozorVisina = Console.WindowHeight;
            Console.WindowHeight = 17;
            Random nasumicanBroj = new Random();
            int score = 3;
            string smer_kretanja = "LEVO";

            int glavaX = prozorSirina / 2;
            int glavaY = prozorVisina / 2;
            List<int> teloX = new List<int>();
            List<int> teloY = new List<int>();
            int vockaX = nasumicanBroj.Next(1, prozorSirina-1);
            int vockaY = nasumicanBroj.Next(1, prozorVisina-1);

            DateTime timer = DateTime.Now;
            DateTime poolingInterval = DateTime.Now;

            
            int gameover = 0;
            while (true)
            {
                // "Resetuje frejm"
                Console.Clear();


                nacrtaj_ivice(prozorSirina, prozorVisina);

                // Proverava da li je zmija udarila u ivicu
                if (glavaX == prozorSirina-1 || glavaX == 0 || glavaY == prozorVisina-1 || glavaY == 0)
                {
                    gameover = 1;
                }

               

                // Ako pokupimo vocku, uvecavamo skor i pravimo novu
                if(vockaX == glavaX && vockaY == glavaY)
                {
                    score++;
                    vockaX = nasumicanBroj.Next(1, prozorSirina-1);
                    vockaY = nasumicanBroj.Next(1, prozorVisina-1);
                }
                // Nacrtaj telo
                for(int i = 0; i < teloX.Count(); i++)
                {
                    nacrtaj_piksel(teloX[i], teloY[i], ConsoleColor.White);
                    if(teloX[i] == glavaX && teloY[i] == glavaY)
                    {
                        gameover = 1;
                    }
                }

                // Nacrtaj glavu
                nacrtaj_piksel(glavaX, glavaY, ConsoleColor.White);
                // Nacrtaj vocku
                nacrtaj_piksel(vockaX, vockaY, ConsoleColor.Red);
                // Napisi score
                Console.SetCursorPosition(0, prozorVisina);
                Console.Write("Score: " + score);

                if (gameover == 1)
                {
                    break;
                }

                double brzina = 500 - Math.Floor(1.5625 * Convert.ToDouble(score));

                timer = DateTime.Now;
                // Menjanje smera
                while (true)
                {
                    poolingInterval = DateTime.Now;
                    if(poolingInterval.Subtract(timer).TotalMilliseconds > brzina)
                    {
                        smer_kretanja = 
                        break;
                    }
                    
                }

                // Update za telo
                teloX.Add(glavaX);
                teloY.Add(glavaY);
                // Pomeramo glavu u zavisnosti od smera kretanja
                switch (smer_kretanja)
                {
                    case "GORE":
                        glavaY--;
                        break;
                    case "DESNO":
                        glavaX++;
                        break;
                    case "LEVO":
                        glavaX--;
                        break;
                    case "DOLE":
                        glavaY++;
                        break;
                }
                // Skidam sa kraja tela
                if(teloX.Count() > score)
                {
                    teloX.RemoveAt(0);
                    teloY.RemoveAt(0);

                }

            }

            Console.SetCursorPosition(prozorSirina / 5, prozorVisina / 2);
            Console.WriteLine("Game over! Score: " + score);
            Console.SetCursorPosition(prozorSirina / 5, prozorVisina / 2 + 1);
            Console.ReadKey();
        }
    }
}
