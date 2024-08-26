using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[2] { "Ankara", "Istanbul" };
            // bir şehir daha ekleme gereksinimi duydugumuzda array kullanmak mantıksız bir hareket olacaktır 
            cities = new string[3]; // yaptğımız anda yeni bir referans ataması yapılır vew . ankara ve istanbuyl verilerini kaybederiz 
            Console.WriteLine(cities[0]); // için ekran boş dönecektir 


             ArrayList cities1 = new ArrayList();    // bir koleksiyon oluşturuyoruz
            cities1.Add("Ankara"); // ekleme yapıyoruz

            cities1.Add("Adana");

            // tip güvenlikli kolkeksiyonklar
            //en çok kullanılanı 
            List<string> strings = new List<string>(); // Sadece string ile çalışma imkanı sağlar 
            strings.Add("Mersin");
            // strings.Add(2); şeklinde yazarsak kod çalışmaz 




             




            Console.ReadLine();



        }


    }


}
