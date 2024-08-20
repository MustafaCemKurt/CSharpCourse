using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // yapılmak istenene işlemleri gruplara ayırmak için kullanılır. 

            CustommerManager manager = new CustommerManager(); // class'tan yeni bir nesne oluşturuyuoruz
            manager.Add();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "KENAN",
                Country = "Turkey",
                City = "Adana",
                LastName="Ahmet",
                PhoneNumber="0565478548554"

            };








        }

        class CustommerManager
        {

            // iki fgarklı method oluştursalım
            public void Add()
            {
                Console.WriteLine("added");

            }
            public void Update()
            {
                Console.WriteLine("customer updated");
            }
        }





    }
}
