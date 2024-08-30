using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {

        public DataTable GetAll2()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            if(connection.State==ConnectionState.Closed)

            {
                connection.Open();

            }
            SqlCommand command = new SqlCommand("Select * from Products",connection);
           SqlDataReader reader =  command.ExecuteReader();

           DataTable datatable = new DataTable();   
            datatable.Load(reader); 
            reader.Close();
            connection.Close();
            return datatable;



        }




        public List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)

            {
                connection.Open();

            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                
                Product product= new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Amount = Convert.ToInt32(reader["Amount"]),
                    Price = Convert.ToDecimal(reader["Price"])
                     

                    
                    

                    
                };
                products.Add(product);  


            }


            reader.Close();
            connection.Close();
           return products;



        }





    }
}
