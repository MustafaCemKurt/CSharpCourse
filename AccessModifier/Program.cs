using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
      private int id { get; set; } // private tanımladık 
        // private: tanımlandığı zaman sadece tanımlandığı blok üzerinde geçerlidir. 
        protected int idd {  get; set; } // protected tanımladık . class seviyesinde protected kullanılır. 
        // private tüm özelliklerini kapsar

        public void save ()
        {
            Customer c1 = new Customer();
            c1.id = id;
        }

    }

    class Student:Customer // kalıtım yapıyoruz
    {
        public void Save2 ()
        {
            //id ; erişimi yoktur. private olanlara kalıtımda dahi erişim sağlanamaz
            // iid ; portected olduğu için kalıtım sınıflarında erişim mümkündür
            
        }

    }

   internal  class Course
    {
        // classların defaultu internaldir. 
        // proje içinde istenen  noktada erişim sağlanabilir. 

        public string name { get; set; }

    }

    public class Courses
    {
        // farklı bir projeden erişim istiyorsak  class public tanımlanmalıdır. 

        public int id { get; set; }

}   
