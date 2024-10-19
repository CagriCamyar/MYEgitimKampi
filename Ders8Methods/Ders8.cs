using System.Threading.Channels;

namespace Ders8Methods
{
    public class Ders8
    {
        static void Main(string[] args)
        {

            void CustomerList()
            {
                Console.WriteLine("Ali Yildiz");
                Console.WriteLine("Ayse Yildiz");
                Console.WriteLine("Merve Cinar");
                Console.WriteLine("Hakan Ozturk");
            }
            CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            void Sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }
            Sum();

            void WritingMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }
            WritingMethod("Mehmet Yildirim");

            void CustomerCard(string firstName, string surName)
            {
                Console.WriteLine("Musteri : " + firstName + " " + surName);
            }
            CustomerCard("Mehmet", "Yildiz");
            CustomerCard("Aysegul", "Kaya");

            void Total(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            Total(4, 5, 6);

            string CustomerName()
            {
                return "Buse Yildiz";
            }
            CustomerName();

            string StudentCard()
            {
                string name = "Ali ";
                string lastName = "Kaya";
                return name + lastName;
            }
            Console.WriteLine(StudentCard());

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ulke : " + countryName + " Baskent : " + capital + " Bayrak : " + flagColor;
                return cardInfo;
            }
            string x, y, z;
            Console.Write("Ulke Adini Giriniz : ");
            x = Console.ReadLine();
            Console.Write("Baskenti Giriniz : ");
            y = Console.ReadLine();
            Console.Write("Bayrak Rengini Giriniz : ");
            z = Console.ReadLine();
            Console.WriteLine(CountryCard(x, y, z));
            Console.WriteLine(CountryCard("Turkiye", "Ankara", "Kirmizi - Beyaz"));

            int Summ(int number1, int number2)
            {
                int result = number1 + number2;
                return result; 
            }
            Console.WriteLine(Summ(45,95));
            Console.WriteLine(Summ(85,34));
            Console.WriteLine(Summ(73,62));

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int avg = (exam1 + exam2 + exam3) / 3;
                if (avg >= 50)
                {
                    return student + " Isimli Ogrenci Sinavi Gecti Ortalamasi : " + avg;  
                }
                else
                {
                    return student + " Isimli Ogrenci Basarisiz Oldu Ortalamasi : " + avg; 
                }
            }
            Console.WriteLine(ExamResult("Ali", 25,41,66));
            Console.WriteLine(ExamResult("Ayse", 45, 72, 86));

            Console.Read();
        }

    }
}
