using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {

        // property 
        public int Id { get; set; } // genelde database üzerinde bilgi tutmak içi n kullanılır.

        private string name;
        public string FirstName { get; set; }
   

        public string LastName  { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; } 

        public string HomePhone { get; set; }

        public string Extension { get; set; }

        public string PhoneNumber { get; set; }

        // property 


    }
}
