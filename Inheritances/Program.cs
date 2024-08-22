using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
     class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
                {
                  new Customer
                  { Name="ali"},
                  new Student
                  { Name="Kerem" },
                  new Person
                  {Name="salih" }

                };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }


      
        }

    }

    // özellik: bir class 1 tane ebeveyn sınıf tanımlanabilir.
    
    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

    }

    class Customer:Person // person ve customer kalıtımı vardır. persona ait tüm özellikleri taşır. customerin ebeveyni Person olarak tanımlanabilir.
    {
        public string city { get; set; }


    }

    class Student : Person
    {
        public string department { get; set; }
    }







}
