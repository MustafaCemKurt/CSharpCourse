using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class Product
    {
        public int Id { get; set; }     
        public string Name { get; set; }

        public string Price { get; set; }

        public string Amount { get; set; }

        public static implicit operator Product(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
