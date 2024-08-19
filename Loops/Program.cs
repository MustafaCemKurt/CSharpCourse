using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {  

            for (int i = 0; i < 100; i++) // 1'den 100''e kadar olan sayıları ekrana yazdıran döngü 
                // for ( başlangıç şartı ; devam etme şartı ; tur bittiğinde yapılması gerekenler ) şeklinde bir syntax kullanıyoruz

            {
                Console.WriteLine(i);
            }

            int number = 100;
            while (number>=95) // 95'ten küçük olduğu sürece çalışmasını bildiriyoruz. 
            {
                Console.WriteLine(number);  // sayıyı ekrana yazdırıyoruz
                number -= 1; // sayıyı azaltıyoruz

            }


            string[] students = new string[3] { "engin", "ali", "kerem" };
            foreach(var student in students)  // dizi tabanlı for klullanımı olarak tanımlanabilir . 

            {
                Console.WriteLine(student);
            }


             Console.ReadLine();

        }
    }
}
