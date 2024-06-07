using Ispit.Model;
using System;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokreniMetode();

            Console.ReadKey();  
        }

        static void PokreniMetode()
        {
            UnesiPodatkeUcenika();           
        }

        static void UnesiPodatkeUcenika()
        {
            Ucenik[] ucenici = new Ucenik[3];

            for (int i = 0; i < 3; i++)
            {
                ucenici[i] = new Ucenik();

                Console.WriteLine($"Upišite ime {i + 1}. učenika: ");
                ucenici[i].Ime = Console.ReadLine();

                Console.WriteLine($"Upišite prezime {i + 1}. učenika: ");
                ucenici[i].Prezime = Console.ReadLine();

                bool isValid = false;
                while (!isValid)
                {
                    Console.Write($"Upišite datum rođenja {i + 1}. učenika(DD.MM.YYYY): ");
                    isValid = DateTime.TryParse(Console.ReadLine(), out DateTime datumRodjenja);
                    if (isValid)
                    {
                        ucenici[i].DatumRodjenja = datumRodjenja;
                    }
                    else
                    {
                        Console.WriteLine("Niste upisali ispravan datum rođenja učenika!");
                    }
                }

                isValid = false;
                while (!isValid)
                {
                    Console.Write($"Upišite prosjek {i + 1}. učenika (1-5): ");
                    isValid = Double.TryParse(Console.ReadLine(), out double prosjek);
                    if (isValid)
                    {
                        ucenici[i].Prosjek = prosjek;
                        break;
                    }
                    else
                        Console.WriteLine("Niste upisali ispravan prosjek");
                }
            }

            IspisiPodatkeUcenika(ucenici);

        }

        static void IspisiPodatkeUcenika(Ucenik[] ucenici)
        {
            foreach (var ucenik in ucenici)
            {
                Console.WriteLine();
                Console.WriteLine($"Ime: {ucenik.Ime}");
                Console.WriteLine($"Prezime: {ucenik.Prezime}");
                Console.WriteLine($"Datum rođenja: {ucenik.DatumRodjenja.ToShortDateString()}");
                Console.WriteLine($"Starost: {ucenik.VratiStarost()} godina");
                Console.WriteLine($"Prosjek: {ucenik.Prosjek} ({ucenik.ProsjekRijecima(ucenik.Prosjek)})");
            }
        }

    }
}
