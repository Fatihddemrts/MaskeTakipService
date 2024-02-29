using DemoProject.DataAccess.Abstract;
using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal() 
        {
            _instructors = new List<Instructor>();
            _instructors.Add(new Instructor { InstructorId = 1, InstructorName = "Engin", InstructorSurname = "Demiroğ", InstructorEmail = "engindemirog@gmail.com"});
            _instructors.Add(new Instructor { InstructorId = 2, InstructorName = "Halit Enes", InstructorSurname = "Kalaycı", InstructorEmail = "haliteneskalaycı@gmail.com" });
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            var existingCourse = _instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);
            if (existingCourse != null)
            {
                existingCourse.InstructorId = instructor.InstructorId;
                existingCourse.InstructorName = instructor.InstructorName;
                existingCourse.InstructorSurname = instructor.InstructorSurname;
                existingCourse.InstructorEmail = instructor.InstructorEmail;
            }
            else
            {
                throw new InvalidOperationException("Güncellenecek kurs bulunamadı.");
            }
        }
    }
}
