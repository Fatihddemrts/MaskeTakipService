using DemoProject.DataAccess.Abstract;
using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal() 
        {
            _courses = new List<Course>();
            _courses.Add(new Course { CourseId = 1, CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", CategoryId = 1, InstructorId = 1, Price = "Ücretsiz"});
            _courses.Add(new Course { CourseId = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", CategoryId = 1, InstructorId = 1, Price = "Ücretsiz" });
            _courses.Add(new Course { CourseId = 3, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", CategoryId = 1, InstructorId = 1, Price = "Ücretsiz" });
            _courses.Add(new Course { CourseId = 4, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", CategoryId = 1, InstructorId = 1, Price = "Ücretsiz" });
            _courses.Add(new Course { CourseId= 5, CourseName = "Senior Yazılım Geliştirici Yetişrime Kampı (.NET)", CategoryId = 1, InstructorId= 1, Price = "Ücretsiz" });
            _courses.Add(new Course { CourseId = 6, CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA", CategoryId = 1, InstructorId = 1, Price = "Ücretsiz" });
            _courses.Add(new Course { CourseId = 7, CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", CategoryId = 1, InstructorId = 2, Price = "Ücretsiz" });
            _courses.Add(new Course { CourseId = 8, CourseName = "Programlamaya Giriş İçin Temel Kurs", CategoryId = 1, InstructorId = 1, Price = "Ücretsiz" });

        }

        public void Add(Course course)
        {
           _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            var existingCourse = _courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (existingCourse != null)
            {
                existingCourse.CourseName = course.CourseName;
                existingCourse.CourseId = course.CourseId;
                existingCourse.CategoryId = course.CategoryId;
                existingCourse.InstructorId = course.InstructorId;
            }
            else
            {
                throw new InvalidOperationException("Güncellenecek kurs bulunamadı.");
            }
        }
    }
}
