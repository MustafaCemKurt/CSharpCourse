using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ReadLine();
        }


    }


    class CustomerManager
    {

        public CustomerManager()  // constructor ataması yapıyoruz // sınıftan bir nesne üretildiğind eootomatik olarak çağırılmaktadır. 


        {
            Console.WriteLine("Constructor is called");
        }

        public CustomerManager(string name)  // CONSTRUCTORLAR overload edilebilirler.
            { Console.WriteLine(name); }
        public void List()
        {

        }
        public void Delete() 
        { 

        }
    }



interface ILogger
    {
        void Log();
    }
    class DataBaseLogger:ILogger
    {
        public void Log()
        { Console.WriteLine("Logged to Database"); }



    }
    class FileLogger : ILogger
    {
        public void Log() { Console.WriteLine("Logged to File"); } 
    
    }


    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;

        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine(  "Added !!");
        }
    }


    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine( "Message");

        }

    }

    class PersonManager:BaseClass // baseclass içinde constructor tanımlanınca değer gönnderimi lazım 
    {
        public PersonManager(string entity):base(entity) // parametreyi sadece base sınıf için almış olduk
        {

        }


    }


   static class Teacher // statik class ataması yapıyoruz 
        // statik classların new ile yeni nesne üretimi söz konusu değildir 

    {
        // bellekte tanımlanır. 

       

    }


}

