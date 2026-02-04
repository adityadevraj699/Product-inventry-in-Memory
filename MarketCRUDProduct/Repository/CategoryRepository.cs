using MarketCRUDProduct.Models;
using System.Diagnostics.Metrics;

namespace MarketCRUDProduct.Repository
{
    public class CategoryRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category{ CategoryId = Category.countId++,CategoryName="Electric", CategoryDescription="Electric"},
            new Category{CategoryId = Category.countId++,CategoryName="Education", CategoryDescription="Education"},
            new Category{CategoryId = Category.countId++,CategoryName="Sport", CategoryDescription="Sport"}
        };

        public static bool AddCategories(Category category)
        {
            if (category == null)
                return false;

            category.CategoryId = Category.countId++;
            _categories.Add(category);

            return true;
        }


        public static List<Category> GetCategories() => _categories; 

        public static Category? GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(x=>x.CategoryId == id);
            if (category == null) return null;
            return category;
        }

        public static bool UpdateCategory(Category category)
        {
            if(category is null) return false;
            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if (categoryToUpdate is not null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.CategoryDescription = category.CategoryDescription;
                return true;
            }
            return false;
        }

        public static bool DeleteCategory(int id)
        {
           var category = _categories.FirstOrDefault(x=> x.CategoryId == id);
            if(category is null) return false;
            var product = ProductRepository.GetProductsByCategoryId(category.CategoryId);
            if(product.Any()) return false;
            _categories.Remove(category);
            return true;
        }

    }
}
