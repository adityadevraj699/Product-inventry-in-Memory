namespace MarketCRUDProduct.Models
{
    public class Product
    {
        public static int countId = 1;
        public int productId { get; set; }
        public Category category { get; set; }
        public string productName { get; set; } = string.Empty;
        public int prodcutPrice { get; set; } 
        public int productQuantity { get; set; }
        public string productDescription { get; set; } = string.Empty ;
    }
}
