using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
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
            return smer_kretanja;
        }
        static void nacrtaj_piksel(int x, int y, ConsoleColor boja)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = boja;
            Console.Write('█');
        }
        static void izbrisi_piksel(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        static void nacrtaj_ivice(int windowWidth, int windowHeight)
        {
            // Crta gornju ivicu
            for (int i = 0; i < windowWidth; i++)
            {
                nacrtaj_piksel(i, 0, ConsoleColor.White);
            }
            // Crta donju ivicu
            for (int i = 0; i < windowWidth; i++)
            {
                nacrtaj_piksel(i, windowHeight - 1, ConsoleColor.White);
            }
            // Crta levu ivicu
            for (int i = 0; i < windowHeight; i++)
            {
                nacrtaj_piksel(0, i, ConsoleColor.White);
            }
            // Crta desnu ivicu
            for (int i = 0; i < windowHeight; i++)
            {
                nacrtaj_piksel(windowWidth - 1, i, ConsoleColor.White);
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

            Smer smer_kretanja = Smer.Desno;

            int glavaX = prozorSirina / 2;
            int glavaY = prozorVisina / 2;
            List<int> teloX = new List<int>();
            List<int> teloY = new List<int>();
            int vockaX = nasumicanBroj.Next(1, prozorSirina-1);
            int vockaY = nasumicanBroj.Next(1, prozorVisina-1);


            DateTime timer = DateTime.Now;
            DateTime poolingInterval = DateTime.Now;
            
            bool gameover = false;
            while (true)
            {
                // "Resetuje frejm"
                // Console.Clear();

                nacrtaj_ivice(prozorSirina, prozorVisina);

                // Proverava da li je zmija udarila u ivicu
                if (glavaX == prozorSirina-1 || glavaX == 0 || glavaY == prozorVisina-1 || glavaY == 0)
                {
                    gameover = true;
                }

               
                // Ako pokupimo vocku, uvecavamo skor i pravimo novu
                if(vockaX == glavaX && vockaY == glavaY)
                {
                    score++;
                    
                    // Generise nasumicno x, y za vocku sve dok ne nadje slobodno polje
                    bool slobodno_polje = true;
                    do
                    {
                        vockaX = nasumicanBroj.Next(1, prozorSirina - 1);
                        vockaY = nasumicanBroj.Next(1, prozorVisina - 1);
                        if (vockaX == glavaX && vockaY == glavaY)
                        {
                            slobodno_polje = false;
                        }
                        for (int i = 0; i < teloX.Count(); i++)
                        {
                            if (vockaX == teloX[i] && vockaY == teloY[i])
                            {
                                slobodno_polje = false;
                            }
                        }
                    } while (slobodno_polje == false);

                }
                // Nacrtaj telo
                for(int i = 0; i < teloX.Count(); i++)
                {
                    nacrtaj_piksel(teloX[i], teloY[i], ConsoleColor.White);
                    if(teloX[i] == glavaX && teloY[i] == glavaY)
                    {
                        gameover = true;
                    }
                }

                // Nacrtaj glavu
                nacrtaj_piksel(glavaX, glavaY, ConsoleColor.White);
                // Nacrtaj vocku
                nacrtaj_piksel(vockaX, vockaY, ConsoleColor.Red);
                // Napisi score
                Console.SetCursorPosition(0, prozorVisina);
                Console.Write("Score: " + score);

                if (gameover == true)
                {
                    break;
                }

                double brzina = 500 - Math.Floor(1.5625 * Convert.ToDouble(score));
                // Menjanje smera
                Stopwatch stoperica = Stopwatch.StartNew();
                while(stoperica.ElapsedMilliseconds <= brzina)
                {
                    smer_kretanja = promeni_smer(smer_kretanja);
                }

                // Update za telo
                teloX.Add(glavaX);
                teloY.Add(glavaY);
                // Pomeramo glavu u zavisnosti od smera kretanja
                switch (smer_kretanja)
                {
                    case Smer.Gore:
                        glavaY--;
                        break;
                    case Smer.Desno:
                        glavaX++;
                        break;
                    case Smer.Levo:
                        glavaX--;
                        break;
                    case Smer.Dole:
                        glavaY++;
                        break;
                }
                // Skidam sa kraja tela
                if(teloX.Count() > score)
                {
                    izbrisi_piksel(teloX[0], teloY[0]);
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
