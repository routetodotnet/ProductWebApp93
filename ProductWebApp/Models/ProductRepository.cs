using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebApp.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class ProductRepository
    {
        public static List<Product> GetAllProducts()
        {
            //ado.net 
            //EF 
            //Connectiong db.. get all data.
            var lst=new List<Product>()
            {
                new Product { Id = 1,Name="aaa" ,Description="product1 "} ,
                new Product { Id = 2,Name="bbb" ,Description="product2 "},
               new Product { Id = 3,Name="cccc" ,Description="product3 "}
            };

            return lst;

        }
    }
}