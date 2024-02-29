using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Remove(Category category);
        List<Category> GetAll();
        void Update(Category category);
    }
}
