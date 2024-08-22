using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Database db1 = new Database();  kodu çalışmayacaktır. abstract classlardan nesne üretmek imkansızdır
            Database db1 = new SqlServer();
            Database db2 = new OracleSql();
            db1.Add();
            db2.Add();
            db1.Delete();
            db2.Delete();

            Console.ReadLine();

        }
    }

    // sadece ata sınıf olarak kullanılır
    // delete methodunu abstract tanımlkayalım 

    abstract class Database
    {
        public void Add() // ekleme işlemini heryerde aynı kabul ediyoruz
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); // delete işlemini farklı kabul ediyoruz
         
    }

    class SqlServer : Database

    {
        public override void Delete() // implement ettitiğimizde delete override olarak otomatik geldi 
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class OracleSql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }



}
