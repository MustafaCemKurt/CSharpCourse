using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara"; // metinsel ifade tanımlarkenb kullanılır. 
            // string aslında char array(dizi) olarak tanımlanabilir. 
            Console.WriteLine(city[0]);  // 0. indexteki yazıyı yazmasını istiyoruz. 
            string city2 = "istanbul";

            var result = city + city2;  // iki string toplanmasında yanyana yazar. 
            Console.WriteLine(result); // birleşmiş durumu yazdırıyoıruz

            Console.WriteLine("{0} {1}", city, city2); // şeklindede yanyana yazabiliriz daha az ram kullanır 


            string sentence = "my name is engin demirog";
            var res1 =sentence.Length;  //  char dizisi(stirng) uzunluğunu veren method olarak tannımlanır. 
            Console.WriteLine(res1);  

            var res2=sentence.Clone(); // sentence isimli değişkenin bir kopyasınıu oluşturmakl için kullanılır 
            Console.WriteLine(res2);   // birincide yapılan değişiklikler klona aktarılmaz

            bool res3 = sentence.EndsWith("g");  // cümle g ile bitiyorsa true döndürür
            Console.WriteLine(res3);

            bool res4 = sentence.StartsWith("my name"); // başlangıç bu şekilde ise true döndürür
            Console.WriteLine(res4);

            var res5 = sentence.IndexOf("name"); // name kelimesinin indexini bulmaaya yarar // başlangıcı  verir
            Console.WriteLine(res5);

            var res6 = sentence.LastIndexOf("a"); // aramaya sondan başlar 
            Console.WriteLine(res6);


            var res7 = sentence.Insert(0, "hello"); // 0. indexten sonr ayaqndakini ekleme yapar. 
            Console.WriteLine(res7);

            var res8 = sentence.Substring(7); //  metini parçalamaya yarar. 
             Console.WriteLine(res8); 

            var res9 = sentence.ToLower(); // bütütn karakterleri küçük harfe çevirmeye yarar
            Console.WriteLine(res9);

            var res10 = sentence.ToUpper();  // bütütn karakterleri büyük harf yapmayaa yarar
            Console.WriteLine(res10);

            var res11 = sentence.Replace(" ", " - "); // bütün boşlukalrı kısa çizgi ifadesi ile değiştirir
            Console.WriteLine(res11);

            var res12=sentence.Remove(0, 2); // iki index arasındakileri siler 
            Console.WriteLine(res12);




            Console.ReadLine();
        }

       
    }
}
