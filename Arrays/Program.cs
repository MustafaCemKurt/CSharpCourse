using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci isimleri
            string[] students = { "Engin", "Mehmet", "Ali" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            // Türkiye'nin bölgeleri ve büyük şehirleri (2 boyutlu dizi)
            string[,] regions =
            {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
            };

            // Tüm şehirleri listele
            for (int i = 0; i < regions.GetLength(0); i++)
            {
                for (int j = 0; j < regions.GetLength(1); j++)
                {
                    Console.WriteLine(regions[i, j].Trim()); // Boşlukları kaldır
                }
            }
        }
    }
}