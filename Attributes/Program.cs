using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, Name = "Mehmet", Age = 21 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

        }
    }


    [ToTable("Customers")]
    class Customer
    {
        // propları tanımlıyoruz

        [RequiredProperty]
        public int Id { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]

        public string LastName { get; set; }
       





    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id,customer.Name,customer.LastName,customer.Age);
        }
    }


    [AttributeUsage(AttributeTargets.All)] // altta tanımlanan attributenin heryeerde kullanılabileceğini tanımlıyoruz
    class RequiredPropertyAttribute:Attribute
    {

    }

    class ToTableAttribute:Attribute
    {
        string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
