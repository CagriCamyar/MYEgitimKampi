using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Ders2
    {
        static void Main(string[] args)
        {

            string title = "Fiyat Listesi";
            Console.WriteLine("***** " + title + " *****");
            Console.WriteLine();

            Console.OutputEncoding = Encoding.UTF8;
            double cucumberPrice;
            double carrotPrice;
            double ricePrice;
            double olivePrice;
            double flourPrice;

            cucumberPrice = 17.25;
            carrotPrice = 24.75;
            ricePrice = 14.42;
            olivePrice = 37.90;
            flourPrice = 7.24;

            Console.WriteLine("Salatalık Birim Fiyatı:" + cucumberPrice + "₺");
            Console.WriteLine("Havuç Birim Fiyatı:" + carrotPrice + "₺");
            Console.WriteLine("Pirinç Birim Fiyatı:" + ricePrice + "₺");
            Console.WriteLine("Zeytin Birim Fiyatı:" + olivePrice + "₺");
            Console.WriteLine("Un Birim Fiyatı:" + flourPrice + "₺");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            double cucumberGram;
            double carrotGram;
            double riceGram;
            double oliveGram;
            double flourGram;

            cucumberGram = 1.624;
            carrotGram = 2.381;
            riceGram = 3.692;
            oliveGram = .826;
            flourGram = 4.877;

            double cucumberTotalPrice = cucumberGram * cucumberPrice;
            double carrotTotalPrice = carrotGram * carrotPrice;
            double riceTotalPrice = riceGram * ricePrice;
            double oliveTotalPrice = oliveGram * olivePrice;
            double flourTotalPrice = flourGram * flourPrice;

            Console.WriteLine("Alınan Ürün: Salatalık " + "Birim Fiyat: " + cucumberPrice + " - Gramaj: " + cucumberGram + "  Toplam Tutar: " + cucumberTotalPrice);
            Console.WriteLine("Alınan Ürün: Havuç " + "Birim Fiyat: " + carrotPrice + " - Gramaj: " + carrotGram + " Toplam Tutar: " + carrotTotalPrice);
            Console.WriteLine("Alınan Ürün: Pirinç " + "Birim Fiyat: " + ricePrice + " - Gramaj: " + riceGram + " Toplam Tutar: " + riceTotalPrice);
            Console.WriteLine("Alınan Ürün: Zeytin " + "Birim Fiyat: " + olivePrice + " - Gramaj: " + oliveGram + " Toplam Tutar: " + oliveTotalPrice);
            Console.WriteLine("Alınan Ürün: Un " + "Birim Fiyat: " + flourPrice + " - Gramaj: " + flourGram + " Toplam Tutar: " + flourTotalPrice);

            double totalPrice = cucumberTotalPrice + carrotTotalPrice + riceTotalPrice + flourTotalPrice + oliveTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Toplam Tutar:" + totalPrice + "₺");
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName;
            string passengerSurname;
            string passengerDistrict;
            string passengerCity;
            string passengerAge;
            string passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            Console.WriteLine("---------------------------------------");





            int shoesPrice = 1000;
            int computerPrice = 2000;
            int chairPrice = 5000;
            int tvPrice = 1200;

            int shoesCount;
            int computerCount;
            int chairCount;
            int tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalShoppingPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalShoppingPrice);
            Console.WriteLine("---------------------------------------");


            double exam1;
            double exam2;
            double exam3;
            double result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);

            Console.WriteLine("---------------------------------------");


            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            Console.Read();
        }
    }
}