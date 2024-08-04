using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var number = 10;
            if (number == 10) // sayının 10 oldugu durumları kontrol ediyoruz
            {
                Console.WriteLine("number is 10");
            }
            else // sayının 10 olmadıgı durumlarda çalışacak kodları yazıyoruz
            {
                Console.WriteLine("number is not 10");
            }

            Console.WriteLine(number==10 ? "number is 10" : "number is not 10");
            // yukarıdaki kod bloğunu kullanarak single line if bloğu çalıştırabiliriz. 
            // önce şart kontrol ediliyor. daha sonra true : false durumunda çalışacak kodları yazıyoruz.

            if (number == 10) { Console.WriteLine("number is 10"); }
            else if (number == 10) { Console.WriteLine("testing else if"); }
            else { Console.WriteLine("number is not 10"); }

            // else if 2'den fazla durum veya birden fazla şart sorgulanacağı zaman kullanılır. 

            switch(number)
            {
                case 1:
                    Console.WriteLine("number is 1");
                    break;
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;

            }

            // çok fazla durum oldugunda case-switch yapısını kullanmak en mantıklı çözümdür. 
            // case yanına parantez içindeki durum yazılır. altına çalışacak kod yazıldıktan sonra break ile durum sonlandırılır. 

            if (number >= 0 && number <= 10) { Console.WriteLine("number is between 1 and 10"); }

            // yukarıda birden fazla şartı tek blok içinde sorgulama yapabiliyoruz. 

            if(number<100) 
            {
                if(number==10)
                {
                    Console.WriteLine("hello world");
                }

            }

            // şeklinde iç içe if blokarını kullanabiliriz. 

            // şart blokları kullanılırken işlem hızı dikkate alınarak uygun seçenek kullanılmalıdır. 
            //  program olabildiğince optimize çalışmalıdır. 




            Console.ReadLine();
        }
    }
}
