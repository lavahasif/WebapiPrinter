using System;
using System.Web.Http;
using printer;


namespace ConsolePrinter
{
    public class ProductController : ApiController
    {
        public Product GetProduct()
        {
            
            new PrintingExample(@"D:\onedrive\Desktop\New Text Document.txt");
            return new Product()
            {
                id = 1,
                name = "Tea", amt = 100
            };
        }
    }
    
    
}

public class Product

{
    public int id { get; set; }
    public String name { get; set; }
    public int amt { get; set; }
}

