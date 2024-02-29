using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Business.Abstract
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Remove(Course course);
        List<Course> GetAll();
        void Update(Course course);
    }
}
