using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            // Value Types
            int no1 = 10;  // İnt(integer) ile tam sayı tipindeki verilerimizi tutabiliriz.
            // no1 adında değeri 10 olan bir integer değişken ataması yaptık . 
            long no2 = 6835094858493759; // Long veri tipi ile daha büyük sayıları atamak için kullanırız. sadece tam sayı tutulur.
            short no3 = -32767; // Short ile daha küçük tam sayı tipindeki verileri tutabiliriz.
            // sınırları -32768 ve +32768 dir. 
            byte no4 = 255; // 0 ile 255 arasındaki sayıları tutan veri tipidir. 
            bool no5 = false; // bool(boolean) veri tipi sadece true(1) veya false (0) tutabileceğimiz veri tipidir.
            char no6 = 'a'; ; // char  ile tek bir harf ataması yapabiliyoruz. 
            double no7 = 10.4; // double ile kesirli sayıların atamasını yapaibliriz. 
            decimal no8 = 18.5m; // daha hassas durumlar için kullanılır. sonuna m eklenir. 
            var no9 = 67;  // şeklinde atama yaparsak var en uygun değişkeni bulur ve atamasını tamamlar. 
            // bundan sonra no9 isimli değişken sadece int değer ataması yapılabilir. 



            Console.WriteLine(no1);
            Console.WriteLine(no2);
            Console.WriteLine(no3);
            Console.WriteLine(no4);
            Console.WriteLine(no5);
            Console.WriteLine(no6);
            Console.WriteLine(no7);
            Console.WriteLine(no8);
            Console.WriteLine(no9);

            Console.ReadLine();
        }
    }
}
