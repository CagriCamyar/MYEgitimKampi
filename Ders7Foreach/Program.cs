namespace Ders7Foreach
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "milano", "roma", "budapeste", "ankara", "istanbul", "varsova" };
            foreach (String city in cities)
            {
                Console.WriteLine(city);
            }

            int[] numbers = { 45, 78, 321, 963, 148, 352, 947, 253, 421 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
            }
            Console.WriteLine(total);

            List<int> sayilar = new List<int>()
            {
                1,2,3,4,5,6,7,8
            };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            string words = "Merhaba";
            foreach (char word in words)
            {
                Console.WriteLine(word);
            }

            //Örnek Sınav Sistemi Uygulaması 
            Console.WriteLine("***** C# Egitim Kampi Sinav Uygulamasi");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Sinifinizda kac ogrenci var ? ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. ogrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli ogrencinin {j + 1}. sinav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExamAverage[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adli ogrencinin not ortalamasi : " + studentExamAverage[i]);
          

            if (studentExamAverage[i] >= 50)
                {
                Console.WriteLine($"{studentNames[i]} adli ogrenci dersi gecti");
                }
            else
                 {
                Console.WriteLine($"{studentNames[i]} adli ogrenci dersten kaldi ");
            }
        
  }

        }
    }
}
