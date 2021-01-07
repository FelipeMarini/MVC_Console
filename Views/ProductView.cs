using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProductView
    {
        
        public void List(List<Product> products)
        {

            foreach (var item in products)
            {
                
                Console.WriteLine($"Code: {item.Code}");
                Console.WriteLine($"Product: {item.Name}");
                Console.WriteLine($"Price: $ {item.Price.ToString("F")}");
                Console.WriteLine();
            
            }
        
        }


        public Product RegisterProduct(){

            Product product = new Product();

            Console.WriteLine();
            Console.WriteLine($"Please type product Code: ");
            product.Code = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Please type product Name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Please type product Price: ");
            product.Price = float.Parse(Console.ReadLine());
            Console.WriteLine();
            
            return product;

        }

    
    }
}