using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IProduct 
    {
       
    }

    interface IRepository<T> where T: class // generic bir interface tanımlıyoruz
    {
        List<T> GetAll();
        T Get (int id);

        void Add (T item); // genel bir tanımlama yapıyoruz. girdiye göre işlemleri gerçekleştirir 


        void Update (T item);   

        void Delete (T item);   

         

    }

    // interface IStudentDal:IRepository<string> // yazamamasını istiyoruz diyelim 
    // interface IRepository<T> where T: class şeklinde yukarıda kısıtlama tanımlayabiliriz 
    // sadece değer tipi istiyorsak interface IRepository<T> where T:struct şeklşinde tanımnlanır . 
    // struct değer tiplerine karşılık gelir 



    // generic kısıtları 
    // generic olan bir sınıfı kısıtlama imkanı sağlar 

}
