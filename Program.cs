using System;

namespace SWE201_235060011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boş constructor ile öğrenci oluşturma
            Student s1 = new Student();
            s1.StudentNumber = "235060011";   // Kendi numaranı yaz
            s1.FullName = "Begüm Aktaş";      // Ad soyad
            s1.Midterm = 70;
            s1.Final = 80;

            Console.WriteLine("Boş kurucu ile oluşturulan öğrenci:");
            Console.WriteLine(s1);
            Console.WriteLine();

            // Parametreli constructor ile öğrenci oluşturma
            Student s2 = new Student("235060001", "Ali Yılmaz", 40, 55);

            Console.WriteLine("Parametreli kurucu ile oluşturulan öğrenci:");
            Console.WriteLine(s2);
            Console.WriteLine();

            // Tek tek bilgi gösterme
            Console.WriteLine("Öğrencilerin detaylı bilgileri:");
            Console.WriteLine("s1 Ortalama: {0}, Durum: {1}", s1.CalculateAverage(), s1.GetStatus());
            Console.WriteLine("s2 Ortalama: {0}, Durum: {1}", s2.CalculateAverage(), s2.GetStatus());

            Console.WriteLine();
            Console.WriteLine("Program bitti. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
