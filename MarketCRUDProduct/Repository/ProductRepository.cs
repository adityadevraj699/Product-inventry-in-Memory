using MarketCRUDProduct.Models;

namespace MarketCRUDProduct.Repository
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        public static bool AddProduct(Product product)
        {
            if (product is not null) {
                product.productId = Product.countId++;
                _products.Add(product);
                return true;
            }
            return false;
            
        }

      
        public static List<Product> GetAllProducts() => _products;

        
        public static Product? GetProductById(int id) => _products.FirstOrDefault(p => p.productId == id);
        public static bool UpdateProduct(Product product)
        {
            if (product == null)
                return false;

            var currentproduct = _products.FirstOrDefault(x => x.productId == product.productId);

            if (currentproduct == null)
                return false;

            currentproduct.productName = product.productName;
            currentproduct.prodcutPrice = product.prodcutPrice;
            currentproduct.productDescription = product.productDescription;
            currentproduct.productQuantity = product.productQuantity;
            currentproduct.category = product.category;

            return true;   
        }

        public static List<Product> GetProductsByCategoryId(int categoryId) => _products
                .Where(p => p.category != null && p.category.CategoryId == categoryId)
                .ToList();
       



        public static bool DeleteProduct(int id) {
            var product = _products.FirstOrDefault(x=>x.productId == id);
            if (product is not null) { 
                _products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
