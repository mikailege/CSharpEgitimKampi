using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", conn);
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();

            //conn.Close();

            //Console.WriteLine("Kategori Eklendi");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.Clear();
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Ekleme İşlemi Başarılı");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated Security=True");

            //conn.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    //Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString()+ " " + dr[3].ToString()); 

            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //conn.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@Id", conn);
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@Id",productId);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı!");

            #endregion


            #region Ürün Güncelleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");


            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName=Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            ////Console.Write("Güncellenecek Ürün Durumu: ");
            ////bool productStatus = bool.Parse(Console.ReadLine());


            //connection.Open();

            //SqlCommand cmd = new SqlCommand("Update TblProduct set ProductName=@Pname, ProductPrice=@PPrice where ProductId=@PId", connection);

            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@Pname", productName);
            //cmd.Parameters.AddWithValue("@PPrice", productPrice);
            //cmd.Parameters.AddWithValue("@PId", productId);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Güncelleme İşlemi Başarılı!");

            //connection.Close();


            #endregion



            Console.ReadLine();

        }
    }
}
