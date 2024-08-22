using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer s1 = new SqlServer();
            MySql m1 = new MySql();
            s1.Add();
            m1.Add();

            Console.ReadLine();
        }


    }

    class Database
    {
        public virtual void Add() // virtualş tanımlıyoruz
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default ");
        }
    }

    class SqlServer:Database
    {
        public override void Add() // aynı isimde farklı işler yapan fonksiyonlar tanımlayabiliriz. virtual olarak ata sınıfta tanımlanmıs olması gereklidir
        {
            Console.WriteLine("Added by Sql Code");
           // base.Add();
        }



    }

    class MySql:Database

    {


    }

}
