namespace LoopsWithStars
{
    public class Ders5
    {
        static void Main(string[] args)
        {
            ////Alt alta 10 adet yildiz olusturma

            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine("*");
            //}

            ////Yan yana 10 adet yildiz olusturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            ////Alt alta 10 adet olustur her satirda da 10 adet yildiz olsun

            //for (int i = 0; i < 10; i++)
            //{
            //    for(int j  = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Dik Ucgen Olusturma
            //for (int i = 1; i <= 5; i++) 
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Ters Dik Ucgen Olusturma
            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Dik ve Ters Dik Ucgen Beraber
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4;  k >= 1; k--)
            //{
            //    for(int m = 1; m<=k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Baklava Dilimi
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j > 0; j--)
            //    {
            //        Console.Write("  ");
            //    }
            //    for(int k = 1; k <= 2 *i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int k = 0;  k <=2 * i -1;  k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Ters Piramit
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                {

                }
            }

            Console.Read();

        }
    }
}
