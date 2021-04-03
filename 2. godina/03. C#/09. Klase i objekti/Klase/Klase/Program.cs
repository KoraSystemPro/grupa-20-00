using System;


namespace Klase
{
    class Program
    {
        class Automobil
        {
            // Svojstva
            public string proizvodjac;
            public string model;
            public string boja;
            public int godiste;
            public int zapremina_motora;

            // Konstruktor
            public Automobil(string manunfacturer, string car_model, string color, int year_of_production, int engine_displacement)
            {
                proizvodjac = manunfacturer;
                model = car_model;
                boja = color;
                godiste = year_of_production;
                zapremina_motora = engine_displacement;
            }
            public Automobil(string manunfacturer, string car_model)
            {
                proizvodjac = manunfacturer;
                model = car_model;
                boja = "---";
            }
            public Automobil(string manunfacturer, string car_model, string color)
            {
                proizvodjac = manunfacturer;
                model = car_model;
                boja = color;
            }

            // Funkcije / metoda
            public void ubrzaj()
            {
                Console.Write("Automobil je ubrzao!\n");
            }
            
            public void ispisi()
            {
                Console.Write("Proizvodjac: " + proizvodjac + "\n");
                Console.Write("Model: " + model + "\n");
                Console.Write("Boja: " + boja + "\n");
                Console.Write("Godiste: " + godiste + "\n");
                Console.Write("Kubikaza: " + zapremina_motora + "\n");
            }
        } 

        static void Main(string[] args)
        {
            // int, float, double, string,...
            // int a = 5;
            // int b = 3;
            // int c = a + b;

            // automobil1 je objekat
            Automobil obj1 = new Automobil("BMW", "520D", "Plava", 2008, 2000);
            //obj1.ispisi();
            //Console.WriteLine("Godiste za obj1: " + obj1.godiste);
            Automobil automobil2 = new Automobil("Toyota", "Auris", "Bela", 2009, 1600);
            //automobil2.ispisi();
            Automobil auto2 = new Automobil("Ford", "GT");
            //auto2.ispisi();


            Racun o1 = new Racun(3123155151, "Marko", "Petrovic", 10000);
            o1.ispis();
            o1.isplata(3500);
            o1.isplata(150);
            o1.uplata(5000);
        }

    }
}
