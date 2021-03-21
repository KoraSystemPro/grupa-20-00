using System;
using System.Reflection.Metadata;

namespace Enum
{
    class Program
    {
        enum NivoAutorizacije
        {
            Niska,      // 0
            Srednja,    // 1
            Visoka      // 2
        }

        enum MeseciUGodini
        {
            Januar,     // 0
            Februar,    // 1
            Mart,       // 2
            April,
            Maj,
            Jun,
            Jul,
            Avgust,
            Septembar,
            Oktobar,
            Novembar,
            Decembar    // 11
        }
        static void Main(string[] args)
        {
            NivoAutorizacije obezbedjenjeAuth = NivoAutorizacije.Visoka;
            NivoAutorizacije portirAuth = NivoAutorizacije.Niska;
            NivoAutorizacije higijenskoOsobljeAuth = NivoAutorizacije.Srednja;
            Console.WriteLine(obezbedjenjeAuth);


            NivoAutorizacije serverskaVrata = NivoAutorizacije.Visoka;
            NivoAutorizacije glavniUlaz = NivoAutorizacije.Niska;

            
            switch (portirAuth)
            {
                case NivoAutorizacije.Niska:
                    Console.WriteLine("Nizak nivo!");
                    break;
                case NivoAutorizacije.Srednja:
                    Console.WriteLine("Srednji nivo!");
                    break;
                case NivoAutorizacije.Visoka:
                    Console.WriteLine("Visok nivo!");
                    break;
            }

            // Pusta sve koji imaju jednak ili visi nivo od nivoa glavnog ulaza
            if (higijenskoOsobljeAuth < glavniUlaz)
            {
                Console.WriteLine("Zabranjen ulaz");
            } else
            {
                Console.WriteLine("Otvorena vrata!");
            }


            int redni_br_meseca = Convert.ToInt32(MeseciUGodini.Jun) + 1;
            Console.WriteLine(redni_br_meseca);
        }
    }
}
