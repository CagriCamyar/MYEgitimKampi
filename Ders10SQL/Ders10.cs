using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ders10SQL
{
    public class Ders10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Panel *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");

            #region Kategori Ekleme Islemi 
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı : ");

            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb; initial Catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); 
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı :");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı :");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection1 = new SqlConnection("Data Source = (localdb)\\mssqllocaldb; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection1.Open();
            //SqlCommand command1 = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection1);
            //command1.Parameters.AddWithValue("@productName", productName);
            //command1.Parameters.AddWithValue("@productPrice", productPrice);
            //command1.Parameters.AddWithValue("@productStatus",  true);
            //command1.ExecuteNonQuery();
            //connection1.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection2 = new SqlConnection("Data Source = (localdb)\\mssqllocaldb; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection2.Open();
            //SqlCommand command2 = new SqlCommand("Select * from TblProduct ", connection2);
            //SqlDataAdapter adapter = new SqlDataAdapter(command2);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection2.Close();

            #endregion

            #region Ürün Silme İşlemi 
            //Console.WriteLine("Silinecek Ürün Id : ");

            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection3 = new SqlConnection("Data Source = (localdb)\\mssqllocaldb; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection3.Open();
            //SqlCommand command3 = new SqlCommand("Delete from  TblProduct Where ProductId = @productId", connection3);
            //command3.Parameters.AddWithValue("@productId", productId);
            //command3.ExecuteNonQuery();

            //connection3.Close();

            //Console.WriteLine(productId + "'ye Sahip Ürün Veritabanından Başarıyla Silindi");
            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellemek İstediğiniz Ürünün Idsini Giriniz : ");
            int productId  = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek Ürün Adı : ");
            string productName = Console.ReadLine();

            Console.WriteLine("Güncellenecek Ürün Fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection4 = new SqlConnection("Data Source = (localdb)\\mssqllocaldb; initial Catalog = EgitimKampiDb; integrated security = true");
            connection4.Open();
            SqlCommand command4 = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", connection4);
            command4.Parameters.AddWithValue("@productName", productName);
            command4.Parameters.AddWithValue("@productPrice", productPrice);
            command4.Parameters.AddWithValue("@productId", productId);
            command4.ExecuteNonQuery();

            connection4.Close();

            Console.WriteLine("Ürün Başarıyla Güncellendi");
            #endregion


            Console.Read();
        
        }
    }
}
