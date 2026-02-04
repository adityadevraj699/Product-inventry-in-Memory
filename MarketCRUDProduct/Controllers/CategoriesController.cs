using MarketCRUDProduct.Models;
using MarketCRUDProduct.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketCRUDProduct.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Detail(int id)
        {
            var category = CategoryRepository.GetCategoryById(id);
            if (category == null)
                return RedirectToAction("Index");

            var products = ProductRepository.GetProductsByCategoryId(id);

            return View((category, products));
        }


        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            var result = CategoryRepository.AddCategories(category);
            if (result)
            {
                TempData["Success"] = "Category Added Successfully!";
            }
            else
            {
                TempData["Error"] = "Category could not be Added, Please try Again!!";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = CategoryRepository.GetCategoryById(id);

            if (category != null)
            {
                return View(category);
            }

            
            TempData["Error"] = "Category not found!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (!ModelState.IsValid) return View(category);

            var result = CategoryRepository.UpdateCategory(category);
            if (result)
            {
                TempData["Success"] = "Category Updated successfully!";
            }
            else
            {
                TempData["Error"] = "Update failed! Please try again.";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = CategoryRepository.DeleteCategory(id);

            if (result)
            {
                TempData["Success"] = "Category deleted successfully!";
            }
            else
            {
                TempData["Error"] = "Category could not be deleted!";
            }

            return RedirectToAction("Index");
        }

    }
}
