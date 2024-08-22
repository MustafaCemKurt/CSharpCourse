using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers) // bütün çalışanlara çalışma talimatı veriyoruz
            {
                worker.Work();
            }



        }


    }


    // bir şirkette çeşitli çalışanlar ( işçiler,yöneticiler ve robotlar ) olduğunu varsayalım . 
    interface IWorker // tüç çalışanları IWorkerda çalçışan olarak tanımlıyoruz
    {
        void Work();  // tüm çalışanlar çalışır

      //void Eat(); ihtiyaçları karşılamadı 

       //  void GetSalary();

    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IGetSalary,IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }



}
