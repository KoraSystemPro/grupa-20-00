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
            string smer = "LEVO";

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

                // Proverava da li je zmija udarila u ivicu
                if(glavaX == prozorSirina-1 || glavaX == 0 || glavaY == prozorVisina-1 || glavaY == 0)
                {
                    gameover = 1;
                }

                // Crta gornju ivicu
                for (int i = 0; i < prozorSirina; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write('█');
                }
                // Crta donju ivicu
                for (int i = 0; i < prozorSirina; i++)
                {
                    Console.SetCursorPosition(i, prozorVisina-1);
                    Console.Write('█');
                }
                // Crta levu ivicu
                for (int i = 0; i < prozorVisina; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('█');
                }
                // Crta desnu ivicu
                for (int i = 0; i < prozorVisina; i++)
                {
                    Console.SetCursorPosition(prozorSirina-1, i);
                    Console.Write('█');
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
                    Console.SetCursorPosition(teloX[i], teloY[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('█');
                    if(teloX[i] == glavaX && teloY[i] == glavaY)
                    {
                        gameover = 1;
                    }
                }

                // Nacrtaj zmijicu
                Console.SetCursorPosition(glavaX, glavaY);
                Console.Write('█');
                // Nacrtaj vocku
                Console.SetCursorPosition(vockaX, vockaY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('█');
                Console.ForegroundColor = ConsoleColor.White;
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
                        break;
                    }
                    if (Console.KeyAvailable)
                    {
                        var dugme = Console.ReadKey(true).Key;
                        if(dugme == ConsoleKey.UpArrow && smer != "DOLE")
                        {
                            smer = "GORE";
                        } else if (dugme == ConsoleKey.DownArrow && smer != "GORE")
                        {
                            smer = "DOLE";
                        } else if (dugme == ConsoleKey.LeftArrow && smer != "DESNO")
                        {
                            smer = "LEVO";
                        } else if (dugme == ConsoleKey.RightArrow && smer != "LEVO")
                        {
                            smer = "DESNO";
                        }
                    }
                }

                // Update za telo
                teloX.Add(glavaX);
                teloY.Add(glavaY);
                // Pomeramo glavu u zavisnosti od smera kretanja
                switch (smer)
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
                Console.SetCursorPosition(0, 0);
            }

            Console.SetCursorPosition(prozorSirina / 5, prozorVisina / 2);
            Console.WriteLine("Game over! Score: " + score);
            Console.SetCursorPosition(prozorSirina / 5, prozorVisina / 2 + 1);
            Console.ReadKey();
        }
    }
}
