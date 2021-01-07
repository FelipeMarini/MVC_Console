using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProductController
    {
        
        Product productModel = new Product();
    
        ProductView productView = new ProductView();
    
    
        public void ListProducts()
        {

            productView.List(productModel.Read());
        
        }
    

        public void Register()
        {

            productModel.Insert(productView.RegisterProduct());

        }

    
    }
}