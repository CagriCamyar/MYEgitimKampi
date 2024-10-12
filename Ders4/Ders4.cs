using System.Diagnostics;

namespace Loops
{
    public class Ders4
    {
        static void Main(string[] args)
        {

            //For Dongusu

            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# Egitim Kampi");
            }

            for (int j = 1; j <= 20; ++j)
            {
                Console.WriteLine(j);
            }

            for (int k = 3; k <= 50; k += 3)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Lutfen Ekrana Yazmak Istediginiz Adedi Giriniz: ");
            int finishValue = int.Parse(Console.ReadLine());
            for (int a = 1; a <= finishValue; ++a)
            {
                Console.WriteLine("Yasasin Cumhuriyet");
            }

            //For Dongusu ile Karar Yapilari

            for (int x = 1; x <= 100; x++)
            {
                if (x % 5 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            int totalValue = 0;
            for (int y = 1; y <= 10; y++)
            {
                totalValue += y;
            }
            Console.WriteLine(totalValue);

            int totalValue1 = 0;
            for (int z = 1; z < 20; z++)
            {
                if (z % 2 == 0)
                {
                    totalValue1 += z;
                    Console.WriteLine(z);
                }
            }
            Console.WriteLine("sonuc: " + totalValue1);

            int count = 0;
            for (int a = 1; a <= 60; a++)
            {
                if (a % 7 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //SORU

            int bacterium = 1;
            for (int t = 1; t <= 24; t++)
            {
                bacterium *= 2;
                Console.WriteLine(t + ". " + "Saat Sonunda " + bacterium + " olusur.");
            }

            //WHILE DONGUSU

            int w = 1;
            while (w <= 10)
            {
                Console.WriteLine("Merhaba Donguler");
                ++w;
            }

            int q = 1;
            while (q <= 10)
            {
                if (q % 3 == 0)
                {
                    Console.WriteLine(q);
                }
                q++;
            }

            int l = 1;
            int sum = 0;
            while (l <= 10)
            {
                sum += l;
                l++;
            }
            Console.WriteLine(sum);

            //Ornek Sinav Sorusu
            //Klavyeden Girilen 3 basamakli sayinin sayi degerleri toplamin hesaplayin -456

            Console.WriteLine("3 Basamakli Sayinizi Giriniz : ");
            int ucBasSayi = int.Parse(Console.ReadLine());
            int ones;
            int tens;
            int hundreds;
            int total;

            ones = ucBasSayi % 10;
            tens = (ucBasSayi % 100) / 10;
            hundreds = ucBasSayi / 100;
            total = ones + tens + hundreds;
            Console.WriteLine(total);

            Console.Read();

        }
    }
}
