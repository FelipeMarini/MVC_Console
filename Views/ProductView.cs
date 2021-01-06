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
                Console.WriteLine($"Price: $ {item.Price}");
                Console.WriteLine();
            
            }
        
        }

    
    }
}