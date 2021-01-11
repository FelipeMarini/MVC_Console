using System.Collections.Generic;
using System.IO;


namespace MVC_Console.Models
{
    public class Product
    {
        
        public int Code { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }


        private const string PATH = "Database/Product.csv";


        public Product() {

            string folder = PATH.Split("/")[0];

            
            if (!Directory.Exists(folder)) {

                Directory.CreateDirectory(folder);
            
            }

            
            if (!File.Exists(PATH)) {

                File.Create(PATH);
            
            }

        }


        public List<Product> Read() 
        {

            List<Product> products = new List<Product>();

            string [] lines = File.ReadAllLines(PATH);

            
            foreach (string item in lines)
            {
                
                string [] attributes = item.Split(";");
            
                Product prod = new Product();
                prod.Code = int.Parse(attributes[0]);
                prod.Name = attributes[1];
                prod.Price = float.Parse(attributes[2]);

                products.Add(prod);
            
            }

                
            return products;

        
        }


        
        public void Insert(Product product){


            string[] lines = { PrepareCSVLines(product) };

            File.AppendAllLines(PATH,lines);

        }



        public string PrepareCSVLines(Product prod){

            return $"{prod.Code};{prod.Name};{prod.Price}";

        }




    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        