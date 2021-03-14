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
            Console.BackgroundColor = ConsoleColor.White;
            // Boja zmije
            Console.ForegroundColor = ConsoleColor.Black;

            // Ako drzite alt i ukucate neki od ova dva koda
            // dobicete odgovarajucu figuru
            Console.WindowHeight = 16;
            Console.WindowWidth = 32;
            int prozorSirina = Console.WindowWidth;
            int prozorVisina = Console.WindowHeight;
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
                    Console.Write('▄');
                }
                // Crta donju ivicu
                for (int i = 0; i < prozorSirina; i++)
                {
                    Console.SetCursorPosition(i, prozorVisina-1);
                    Console.Write('▄');
                }
                // Crta levu ivicu
                for (int i = 0; i < prozorVisina; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('▄');
                }
                // Crta desnu ivicu
                for (int i = 0; i < prozorVisina; i++)
                {
                    Console.SetCursorPosition(prozorSirina-1, i);
                    Console.Write('▄');
                }

                Console.ForegroundColor = ConsoleColor.Red;
                // Ako pokupimo vocku, uvecavamo skor i pravimo novu
                if(vockaX == glavaX && vockaY == glavaY)
                {
                    score++;
                    vockaX = nasumicanBroj.Next(1, prozorSirina-1);
                    vockaY = nasumicanBroj.Next(1, prozorVisina-1);
                }

                // Nacrtaj zmijicu
                Console.SetCursorPosition(glavaX, glavaY);
                Console.Write('▄');

                if (gameover == 1)
                {
                    break;
                }

                timer = DateTime.Now;
                // Menjanje smera
                while (true)
                {
                    poolingInterval = DateTime.Now;
                    if(poolingInterval.Subtract(timer).TotalMilliseconds > 500)
                    {
                        break;
                    }
                    if(Console)
                }

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
            }

            Console.ReadKey();
        }
    }
}
