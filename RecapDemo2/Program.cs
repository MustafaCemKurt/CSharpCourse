using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger=new DatabaseLogger(); // log etme şeklini set ediyoruz
            customerManager.Add();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Logger = new FileLogger(); // log etme şeklini set ediyoruz
            customerManager1.Add();

            Console.ReadLine(); 

        }


    }

    class CustomerManager
    {
        public ILogger Logger {  get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added !!");
        }



    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }

    }

    class FileLogger : ILogger

    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    interface ILogger // LOG interface olusturuyoreuz
    {
        void Log();
    }

}
