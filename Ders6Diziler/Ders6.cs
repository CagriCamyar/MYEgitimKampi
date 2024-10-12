namespace Ders6Diziler
{
    public class Ders6
    {
        static void Main(string[] args)
        {
            //Temel Dizi Ornekleri

            string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Sari";
            colors[2] = "Mavi";
            colors[3] = "Beyaz";
            Console.WriteLine(colors[2]);

            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeste";
            cities[2] = "Lyon";
            cities[3] = "Cairo";
            cities[4] = "Uskup";
            Console.WriteLine(cities[4]);

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[5]);

            string[] sehirler = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            Console.WriteLine(sehirler[2]);

            //Dizideki Tum Elemanlari Listeleme

            string[] renkler = { "Sari", "Mavi", "Kirmizi", "Beyaz", "Yesil", "Turuncu", "Pembe" };
            for (int i = 0; i < renkler.Length; i++)
            {
                Console.WriteLine(renkler[i]);
            }

            int[] sayilar = { 4, 8, 64, 21, 456, 652, 48, 6, 254, 98564, 2154 };
            
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] % 3 == 0)
                    {
                        Console.WriteLine(sayilar[i]);
                    }
                }

                char[] symbols = { 'A', 'b', 'c', '+', '-', '/','*' };
                for (int i = 0; i < symbols.Length; i++)
                {             
                        Console.WriteLine(symbols[i]);
                  
                }

            int[] myArray = { 7, 51, 36, 94, 254, 300, 418, 42, 692, 478, 201, 22, 63 };
            int maxNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);

            string[] persons = { "Ayse", "Ali", "Ahmet", "Buse", "Cagri", "Burak" };
            Console.WriteLine(persons.Length);

            int[] numberArray = { 45, 25, 36, 84, 19, 23, 56, 48 };
            Array.Sort(numberArray);
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            Console.WriteLine("Dizinin En Buyuk Elemani : " + numberArray.Max() + " Dizinin En Kucuk Elemani : " + numberArray.Min());

            int[] numberArray1 = { 45, 25, 36, 84, 19, 23, 56, 48 };
            Array.Reverse(numberArray1);
            for (int i = 0; i < numberArray1.Length; i++)
            {
                Console.WriteLine(numberArray1[i]);
            }

            string[] customers = { "Ali", "Ayse", "buse", "cagri", "murat", "merve" };
            int index = Array.IndexOf(customers, "merve");
            Console.WriteLine(index);

            //Kullanıcıdan Veri Alma 
            string[] citiesArray = new string[5];
       for (int i = 0;i < citiesArray.Length;i++)
            {
                Console.Write($"Lutfen {i + 1 }. Sehri Giriniz : ");
                citiesArray[i] = Console.ReadLine();
            }
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < citiesArray.Length; i++)
            {
                Console.WriteLine(citiesArray[i]);
            }

            int[] totalNumbers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < totalNumbers.Length; i++)
            {
                sum += totalNumbers[i];
            }
            Console.WriteLine(sum);

            int[] differentNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Cift Sayilar");
            Console.WriteLine();
            for (int i = 0; i < differentNumbers.Length; i++)
            {                
                if (differentNumbers[i] % 2 == 0)
                {
                    Console.WriteLine(differentNumbers[i]);
                }            
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Tek Sayilar"); 
            Console.WriteLine();

            for (int i = 0; i < differentNumbers.Length; i++)
            {
                if (differentNumbers[i] % 2 == 1)
                {
                    Console.WriteLine(differentNumbers[i]);
                }
            }


            Console.Read();
            }
        }
    }

