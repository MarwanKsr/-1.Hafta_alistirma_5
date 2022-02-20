using System;

namespace alistirme_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayiyi giriniz: ");
            int a = int.Parse(Console.ReadLine());
            if (a<100 && a>0)
            {
                Console.WriteLine("Girdiginiz sayi 0-100 arasindadir");
            }
            else 
            {
                Console.WriteLine("Girdiniz sayi 0-100 arasinda degildir");
            }
        }
    }
}
