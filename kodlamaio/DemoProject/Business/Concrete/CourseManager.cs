using DemoProject.Business.Abstract;
using DemoProject.DataAccess.Abstract;
using DemoProject.DataAccess.Concrete;
using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Business.Concrete
{
    public class CourseManager : ICourseManager
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal) 
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Remove(Course course)
        {
           _courseDal.Delete(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
