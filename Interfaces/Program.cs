using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, Firstname = "engin", Lastname = "demirog",Address="ankara" });


            Console.ReadLine();
        }

        interface IPerson  // interface tanımlıyoruz. // soyutn  sınıf olarak tanımlanabilir
        {

            int Id { get; set; }
            string Firstname { get; set; }
            string Lastname { get; set; }

        }
        class Customer :IPerson // ıperson ile kalıtım yapıyoruz. 
        {
           public int Id { get; set; }
           public string Firstname { get; set; }
           public string Lastname { get; set; }

            public string Address { get; set; } // classa özel method

        }
        class Student : IPerson
        {
             public int Id { get; set; }
             public string Firstname { get; set; }
             public string Lastname { get; set; }

            public string department { get; set; } // classa özel method

        }

        class PersonManager
        {
            public void Add(Customer customer) // method tanımlıyoruz
            {
                Console.WriteLine(customer.Firstname);

            }

        }

    }
}
