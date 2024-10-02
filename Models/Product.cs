namespace MyMvcApiProject.Models
{
   public class Product
   {
       public int ProductId { get; set; }
        public string Name { get; set; }
       public decimal Price { get; set; }

       // Constructor aan lahayn parameters
       public Product() { }

      
        public Product(int productId, string name, decimal price)
        {
           ProductId = productId;
           Name = name;
           Price = price;
       }
  }
}
