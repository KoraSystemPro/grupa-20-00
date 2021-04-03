using System;

public class Racun
{
	// Svojstva
	public long br_racuna = 0;
	public string ime = "---";
	public string prezime = "---";
	public double iznos = 0;

	// Konstruktor
	public Racun(long acc_number)
    {
		br_racuna = acc_number;
	}
	public Racun(long acc_number, string name, string surname)
	{
		br_racuna = acc_number;
		ime = name;
		prezime = surname;
	}
	public Racun(long acc_number, string name, string surname, double amount)
	{
		br_racuna = acc_number;
		ime = name;
		prezime = surname;
		iznos = amount;
	}

	// Metode
	public void uplata(double x)
    {
		iznos += x;
		Console.WriteLine("Na racun osobe " + ime + " , uplaceno je: " + x);
		Console.WriteLine("Trenutno stanje racuna osobe je: ");
		ispis();

	}
	public void isplata(double x)
    {
		if(iznos - x < 0)
        {
			Console.WriteLine("Na racunu osobe " + ime + " nema dovoljno sredstava za isplatu!");
			break;
		}
		iznos -= x;
		Console.WriteLine("Sa racuna osobe " + ime + " , isplaceno je: " + x);
		Console.WriteLine("Trenutno stanje racuna osobe je: ");
		ispis();
	}
	public void ispis()
    {
		Console.Write("Broj Racuna: " + br_racuna + "\n");
		Console.Write("Ime: " + ime + "\n");
		Console.Write("Prezime: " + prezime + "\n");
		Console.Write("Iznos: " + iznos + "\n");
		Console.WriteLine("-------------------------------");
	}
}
