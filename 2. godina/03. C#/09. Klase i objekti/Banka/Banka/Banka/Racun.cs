using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    class Racun
    {
        // Svojstva
        uint brojRacuna = 0;
        string ime;
        string prezime;
        double iznos = 0;
        // Konstruktor (prima argumente i prvi novi objekat klase racun)
        public Racun(uint id, string name, string surname, double amount)
        {
            brojRacuna = id;
            ime = name;
            prezime = surname;
            iznos = amount;
        }

        // Funkcije / metode
        public void UpitStanja()
        {
            MessageBox.Show("Br racuna: " + brojRacuna + "\n" +
                "Ime: " + ime + "\n" +
                "Prezime: " + prezime + "\n" +
                "Iznos: " + iznos);
        }

        public void Uplati(double amount)
        {
            iznos = iznos + amount;
        }

        public void Isplati(double amount)
        {
            if(iznos - amount >= 0)
            {
                iznos = iznos - amount;
                MessageBox.Show("Sa racun broj: " + brojRacuna + ", isplaceno je: " + amount);
                UpitStanja();
            }
        }
    }
}
