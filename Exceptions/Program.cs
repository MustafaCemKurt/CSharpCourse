using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hata yönetimi oldukça önemnlki bir  husustur. 
            // hata ortaya çıkararak kaynak kodlarımıza erişim sağlanabilir 
            // bunun önüne geçmek için hata vereblieceğini düşündüğümüz kodları aşağıdaki gibi bir blok ile yazarak bunun önüne geçebiliriiz


            //ExceptionIntro();




            try
            { 
                Find();

            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);   
               
            }

            Ha

          


            Console.ReadLine();


        }

        private static void Find()
        {
            List<string> students = new List<string> { "Mehmet", "Kerem", "Huseyin" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException();
            }
            else
            {
                Console.WriteLine("Record Found");

            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Salih", "Derin" };
                students[3] = "Ahmet";


            }
            catch (IndexOutOfRangeException exception) // hatanın türüne göre catch tannımlabiliyoruz 

            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception) // hata biligsini oluşturulan nesneye aktarıyoruz 

            {
                Console.WriteLine(exception.Message);


            }
        }
    }


}
