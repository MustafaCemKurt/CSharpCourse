using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2); // 10 değerini yazar 

            string[] cities = new string[] { "Adana", "Ankara", "Afyon" }; // arrraylar birer referans değişkendir 
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; 
            cities2= cities; // yaptıgımıızda sadece referanslar değişir
             
            Console.ReadLine();


        }



    }


}
