using System;
using System.Collections.Generic;
using Exam.Properties.Entity;

namespace Exam.Properties.Controller
{
    public class ProductController
    {
        List<Product> list = new List<Product>();
        public bool Add()
        {
            
            
            Console.WriteLine("Please enter product ID");
            string _productId = Console.ReadLine();
            Console.WriteLine("Please enter product name");
            string _productName = Console.ReadLine();
            Console.WriteLine("Please enter price");
            decimal _price = Decimal.Parse(Console.ReadLine());
            Product product = new Product(_productId,_productName,_price);
            list.Add(product);
            return true;
        }

        public void Display()
        {
            Console.WriteLine("ok");
            Console.WriteLine("{0, -20} {1,-20} {2, -20} ","Product Id", "Product Name", "Price");   
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (var product in list)
            {
             
             Console.WriteLine("{0, -20} {1, -20} {2, -20}",product.ProductId,product.ProductName,product.Price);
            }
            
        }

        public void Delete()
        {
            Console.WriteLine("ID need to delete.");
            
            string id = Console.ReadLine();
            Product idDelete = list.Find(a => a.ProductId == id);
            list.Remove(idDelete);


        }
    }
}