using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        // genellikle kendini tekrarlama( donnt repaet yourself ) durumlarında kullanılır

        static void Main(string[] args)
        {
           var result = Add(32, 45); // methodu çağırıyoruz
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Add(int v1 , int v2) // şeklinde methodu tanımlıyoruz.
        {
            return v1 + v2;  // geri dönüş değer tipi static'ten sonra belirtiyoruz.
        }
        
        static int Add2(int v1, int v2=25) // şeklinde methodu tanımlıyoruz.
        {
            // yukarıda değer girilmez ise v2 için 25 ataması yapılacaktır. tek girdi ile çalışabilir.

            return v1 + v2;  // geri dönüş değer tipi static'ten sonra belirtiyoruz.
        }
         // default değerli parametreli method

        static int  Add3(int v1, int v2)
        {
            return v1 + v2;
        }

        static int multiply(int v1, int v2) // çarpoma i,şlemeini  yapan methodu atamasını yapıyoruz.

        { 
            return v1 * v2;

        }

        static int multiply(int v1 , int v2 , int v3)  // şeklinde aynı isim işle farklı girdilerle farklı çalışacak  şekiilde methodu overloading edebiliyoruz. 
        {
            return v1 * v2 *v3; 
        }

        static int Add4(int v1 , int v2 , int v3, int v4)
        {
            return v1 + v2 +v3 + v4;

        }

        static int Add5(params int[] v) // girdi kadar ilerler . dizi mantığıında çalışır. 
        {
            return v.Sum(); // toplama işlermi yapan method. 
        }



    }
}
