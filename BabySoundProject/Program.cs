using System;

namespace BebekUygulamasi
{
    public class Bebek
    {
        // Property'ler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Default Constructor
        public Bebek()
        {
            Console.WriteLine("Ingaaaaaaa");
            DogumTarihi = DateTime.Now;
        }

        // Parametreli Constructor
        public Bebek(string ad, string soyad)
        {
            Console.WriteLine("Ingaaaaaaa");
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;
        }

        // Bilgileri yazdıran metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bebek 1 (Default Constructor) ===");
            Bebek bebek1 = new Bebek();
            bebek1.Ad = "Emine";
            bebek1.Soyad = "Köşk";
            bebek1.BilgileriYazdir();

            Console.WriteLine("\n=== Bebek 2 (Parametreli Constructor) ===");
            Bebek bebek2 = new Bebek("Nurbanu", "Demir");
            bebek2.BilgileriYazdir();
        }
    }
}
