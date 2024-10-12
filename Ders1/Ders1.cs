using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSubjects
{
    public class Ders1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Selam");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            string title = "Kategoriler";
            string subTitle1 = "Çorbalar";
            string subTitle2 = "Ana Yemek";
            string subTitle3 = "Başlangıçlar";
            string subTitle4 = "Salatalar";
            string subTitle5 = "İçecekler";
            string subTitle6 = "Tatlılar";

            Console.WriteLine("***** " + title + " *****");
            Console.WriteLine();

            Console.WriteLine("1-" + subTitle1);
            Console.WriteLine("2-" + subTitle2);
            Console.WriteLine("3-" + subTitle3);
            Console.WriteLine("4-" + subTitle4);
            Console.WriteLine("5-" + subTitle5);
            Console.WriteLine("6-" + subTitle6);
            Console.WriteLine();
            Console.WriteLine("***** " + title + " *****");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail;
            string customerDistrict;
            string customerCity;

            customerName = "Çağrı";
            customerSurname = "Çamyar";
            customerPhone = "0123 456 78 90 ";
            customerEmail = "cagri@gmail.com";
            customerDistrict = "Kartal";
            customerCity = "İstanbul";

            Console.WriteLine("**** Müşteri Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("İsim: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon: " + customerPhone);
            Console.WriteLine("E-posta: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);

            customerName = "Furkan";
            customerSurname = "Demir";
            customerPhone = "0987 654 32 10";
            customerEmail = "furkan@gmail.com";
            customerDistrict = "Eryaman";
            customerCity = "Ankara";

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("İsim: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon: " + customerPhone);
            Console.WriteLine("E-posta: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("-------------------------------------------------");

            int chickenPrice = 350;
            int meatPrice = 500;
            int pastaPrice = 150;
            int cakePrice = 100;
            int meatballPrice = 200;
            int burgerPrice = 250;
            int waterPrice = 10;
            int cokePrice = 30;
            int coffeePrice = 80;
            int lemonadePrice = 40;
            int teaPrice = 20;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("");
            string restaurantTitle = "Restorant Menü Fiyatları";
            Console.WriteLine("**** " + restaurantTitle + " ****");
            Console.WriteLine();
            Console.WriteLine("Tavuk: " + chickenPrice + "₺");
            Console.WriteLine("Et: " + meatPrice + "₺");
            Console.WriteLine("Köfte: " + meatballPrice + "₺");
            Console.WriteLine("Makarna: " + pastaPrice + "₺");
            Console.WriteLine("Tatlı: " + cakePrice + "₺");
            Console.WriteLine("Burger: " + burgerPrice + "₺");
            Console.WriteLine("Kola: " + cokePrice + "₺");
            Console.WriteLine("Limonata: " + lemonadePrice + "₺");
            Console.WriteLine("Kahve: " + coffeePrice + "₺");
            Console.WriteLine("Su: " + waterPrice + "₺");
            Console.WriteLine("Limonata: " + lemonadePrice + "₺");
            Console.WriteLine();
            Console.WriteLine("**** " + restaurantTitle + " ****");
            Console.WriteLine();

            int chickenCount = 3;
            int meatCount = 1;
            int pastaCount = 2;
            int cakeCount = 5;
            int meatballCount = 1;
            int burgerCount = 1;
            int cokeCount = 6;
            int teaCount = 15;
            int waterCount = 3;
            int coffeeCount = 5;
            int lemonadeCount = 3;

            int totalChickenPrice = chickenPrice * chickenCount;
            int totalMeatPrice = meatPrice * meatCount;
            int totalPastaPrice = pastaPrice * pastaCount;
            int totalCakePrice = cakePrice * cakeCount;
            int totalMeatballPrice = meatballPrice * meatballCount;
            int totalBurgerPrice = burgerPrice * burgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalTeaPrice = teaPrice * teaCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalCoffeePrice = coffeePrice * coffeeCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Tavuk Tutarı: " + totalChickenPrice + "₺");
            Console.WriteLine("Et Tutarı: " + totalMeatPrice + "₺");
            Console.WriteLine("Makarna Tutarı: " + totalPastaPrice + "₺");
            Console.WriteLine("Tatli Tutarı: " + totalCakePrice + "₺");
            Console.WriteLine("Köfte Tutarı: " + totalMeatballPrice + "₺");
            Console.WriteLine("Burger Tutarı: " + totalBurgerPrice + "₺");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "₺");
            Console.WriteLine("Çay Tutarı: " + totalTeaPrice + "₺");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "₺");
            Console.WriteLine("Kahve Tutarı: " + totalCoffeePrice + "₺");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "₺");

            Console.WriteLine();

            int totalPrice = totalChickenPrice + totalMeatPrice + totalPastaPrice + totalCakePrice + totalMeatballPrice + totalBurgerPrice + totalCokePrice + totalTeaPrice + totalWaterPrice + totalCoffeePrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "₺");

            Console.Read();
        }
    }
}