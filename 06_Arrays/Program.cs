using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            ////2.4.6.8
            ////sarı,kırmızı,mavi,turuncu,beyaz
            ////adana,ankara,istanbul,bursa
            ////DeğişkenTürü [] DiziAdi = new Değişkentürü[ElemanSayısı]

            //string[] colors = new string[4];

            ////diziler bellekte belli indislerde bulunur ve sıfırdan başlar.
            ////aşağıdaki dizi 4 elemanlı bir dizi ve indisi sıfırdan başlıyor.
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]); //eğer dizin ataması yapılmazsa tam sayı değerinde default olarak sıfır döner.

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // Dizideki en büyük sayıyı bulan program

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0]; // Başlangıçtaki ilk değerin en büyük değer olduğunu kabul ediyoruz.

            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i]> maxNumber)
            //    {
            //        maxNumber = myArray[i]; //Burada dizinin i'ninci değeri büyük ise maxNumber'a eşitleyecek ve en büyük sayıyı elde edeceğiz.
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length); // bu method dizinin uzunluğunu veriyor.

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); //Bu method küçükten büyüğe doğru diziyi sıralıyor.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); //Bu method diziyi tersten sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve"); // Belirtilen değerin kaçıncı indekste olduğunu buluyoruz.
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dzinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
