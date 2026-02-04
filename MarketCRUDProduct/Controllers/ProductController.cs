using MarketCRUDProduct.Models;
using MarketCRUDProduct.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketCRUDProduct.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductRepository.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id) { 
            var products = ProductRepository.GetProductById(id);
            if(products is not null)
            {
                return View(products);
            }
            TempData["Error"] = "Product Not Found";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddProduct() {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product, int categoryId)
        {
            var category = CategoryRepository.GetCategoryById(categoryId);

            if (category == null)
            {
                TempData["Error"] = "Please select a valid category";
                return RedirectToAction("AddProduct");
            }

            product.category = category;

            var result = ProductRepository.AddProduct(product);

            if (result)
                TempData["Success"] = "Product Added Successfully!";
            else
                TempData["Error"] = "Product could not be Added, Please try Again!!";

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult EditProduct(int id) { 
           var product = ProductRepository.GetProductById(id);
            var categories = CategoryRepository.GetCategories();
            if (product is not null) {
                return View((product,categories));
            }
            TempData["Error"] = "Product Not Found";
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult EditProduct(Product product, int categoryId)
        {
            var category = CategoryRepository.GetCategoryById(categoryId);
            if (category == null)
            {
                TempData["Error"] = "Please select a valid category";
                return RedirectToAction("EditProduct", new { id = product.productId });
            }

            product.category = category;

            var result = ProductRepository.UpdateProduct(product);

            if (result)
                TempData["Success"] = "Product Updated successfully!";
            else
                TempData["Error"] = "Update failed! Please try again.";

            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var result = ProductRepository.DeleteProduct(id);

            if (result)
            {
                TempData["Success"] = "Product deleted successfully!";
            }
            else
            {
                TempData["Error"] = "Product could not be deleted!";
            }

            return RedirectToAction("Index");
        }

    }
}
