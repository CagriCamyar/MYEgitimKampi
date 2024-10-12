using System;
using System.Threading.Channels;

namespace MakingDecision
{
    public class Ders3
    {
        static void Main(string[] args)
        {
            //IF - ELSE

            Console.WriteLine("Lütfen Şifrenizi Giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Sifre Yanlis");
            }

            string capital;
            string country;
            Console.WriteLine("Ulke Giriniz");
            country = Console.ReadLine();
            Console.WriteLine("Baskent Giriniz");
            capital = Console.ReadLine();
            if (capital == "ankara" & country == "turkiye")
            {
                Console.WriteLine("Dogru Giris Yaptiniz");
            }
            else
            {
                Console.WriteLine("Hatali Bilgi");
            }

            int number;
            Console.WriteLine("Sayiyi Giriniz");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayi dogru");
            }
            else
            {
                Console.WriteLine("Sayi Hatali");
            }

            int exam1;
            int exam2;
            int exam3;
            int average;
            string result = "!Hata Ortalama Negatif Deger Olamaz";

            Console.WriteLine("Birinci Sinav Sonucunuzu Giriniz");
            exam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci Sinav Sonucunuzu Giriniz");
            exam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ucuncu Sinav Sonucunuzu Giriniz");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Ortalamaniz : " + average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuc Kotu";
            }
            else if (average > 50 & average <= 70)
            {
                result = "Sonuc Ortalama";
            }
            else if (average > 70 & average <= 84)
            {
                result = "Sonuc Iyi";
            }
            else if (average > 84)
            {
                result = "Sonuc Cok Iyi";
            }

            Console.WriteLine(result);

            string city;
            Console.WriteLine("Lutfen Bir Sehir Ismi Yaziniz");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Sehir Mevcut");
            }
            else
            {
                Console.WriteLine("Sehir Mevcut Degil");
            }

            string username;
            Console.WriteLine("Lutfen Kullanici Adinizi Giriniz");
            username = Console.ReadLine();

            if (username != "admin")
            {
                Console.WriteLine("Bu Islemi Gerceklestiremezsiniz");
            }
            else
            {
                Console.WriteLine("Hos geldiniz");
            }

            ////MOD 

            int modNumber = 26;
            int modResult = modNumber % 5;
            Console.WriteLine(modResult);

            Console.WriteLine("Birinci Sayiyi Giriniz");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci Sayiyi Giriniz");
            int number2 = int.Parse(Console.ReadLine());
            int total = number1 % number2;
            Console.WriteLine("Birinci Girdiginiz Sayinin Ikinci Girdiginiz Sayiya Bolumunden Kalan: " + total);

            Console.WriteLine("Bir Sayi Giriniz: ");
            int number3 = int.Parse(Console.ReadLine());
            if (number3 % 2 == 0)
            {
                Console.WriteLine("Sayi Cifttir");
            }
            else
            {
                Console.WriteLine("Sayi  Tektir");
            }

            ////CHAR Degiskeni

            char team;
            Console.WriteLine("Lutfen Takim Sembolunu Giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("FENERBAHÇE");
            }
            else if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            else if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Besiktas");
            }

            //PROJE

            Console.WriteLine("***** C# Egitim Restorant *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Corbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- Icecekler");
            Console.WriteLine("5- Tatlilar");
            Console.WriteLine("--------------------------------------");

            string chooseItem;
            Console.WriteLine("Detaylari Gormek Icin Bir Menu Seciniz:");
            chooseItem = Console.ReadLine();

            if (chooseItem == "1" | chooseItem == "Ana Yemekler")
            {
                Console.WriteLine();
                Console.WriteLine("---------Ana Yemekler---------");
                Console.WriteLine();
                Console.WriteLine("1- Kori Soslu Tavuk ");
                Console.WriteLine("2- Kizartma Tabagi");
                Console.WriteLine("3- Fasulye Pilav");
                Console.WriteLine("4- Firinda Somon");
                Console.WriteLine("5- Patlican Musakka");
                Console.WriteLine();
                Console.WriteLine("---------Ana Yemekler---------");
            }

            if (chooseItem == "2" | chooseItem == "Corbalar")
            {
                Console.WriteLine();
                Console.WriteLine("---------Corbalar---------");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Corbasi ");
                Console.WriteLine("2- Ezogelin Corbasi");
                Console.WriteLine("3- Domates Corbasi");
                Console.WriteLine();
                Console.WriteLine("---------Corbalar---------");
            }

            if (chooseItem == "3" | chooseItem == "Pizzalar")
            {
                Console.WriteLine();
                Console.WriteLine("---------Pizzalar---------");
                Console.WriteLine();
                Console.WriteLine("1- Akdeniz Pizza ");
                Console.WriteLine("2- Margaritha");
                Console.WriteLine("3-  Tavuklu Pizza");
                Console.WriteLine();
                Console.WriteLine("---------Pizzalar---------");
            }

            if (chooseItem == "4" | chooseItem == "Icecekler")
            {
                Console.WriteLine();
                Console.WriteLine("---------Icecekler---------");
                Console.WriteLine();
                Console.WriteLine("1- Kola ");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3- Su");
                Console.WriteLine();
                Console.WriteLine("---------Icecekler---------");
            }

            if (chooseItem == "5" | chooseItem == "Tatlilar")
            {
                Console.WriteLine();
                Console.WriteLine("---------Tatlilar---------");
                Console.WriteLine();
                Console.WriteLine("1- Trilice ");
                Console.WriteLine("2- Kazandibi");
                Console.WriteLine("3- Baklava");
                Console.WriteLine();
                Console.WriteLine("---------Tatlilar---------");
            }

            //SWITCH - CASE 

            Console.WriteLine("Lutfen Ay Girisi Yapiniz");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Subat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayis");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Agustos");
                    break;
                case 9:
                    Console.WriteLine("Eylul");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasim");
                    break;
                case 12:
                    Console.WriteLine("Aralik");
                    break;
                default:
                    Console.WriteLine("Hatali Giris Yaptiniz");
                    break;
            }

            //SWITCH - CASE HESAP MAKINESI

            int number4;
            int number5;
            int result1;
            char symbol;

            Console.WriteLine("1. Sayiyi Giriniz");
            number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayiyi Giriniz");
            number5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Islemi Giriniz");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result1 = number4 + number5;
                    Console.WriteLine("Sonuc: " + result);
                    break;
                case '-':
                    result1 = number4 - number5;
                    Console.WriteLine("Sonuc: " + result);
                    break;
                case '*':
                    result1 = number4 * number5;
                    Console.WriteLine("Sonuc: " + result);
                    break;
                case '/':
                    result1 = number4 / number5;
                    Console.WriteLine("Sonuc: " + result);
                    break;



            }

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
