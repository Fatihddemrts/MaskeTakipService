using DemoProject.DataAccess.Abstract;
using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal() 
        { 
            _categories = new List<Category>();
            _categories.Add(new Category { CategoryId = 1, CategoryName = "Programlama" });

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            var existingCourse = _categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (existingCourse != null)
            {
                existingCourse.CategoryId = category.CategoryId;
                existingCourse.CategoryName = category.CategoryName;
            }
            else
            {
                throw new InvalidOperationException("Güncellenecek kurs bulunamadı.");
            }
        }
    }
}
