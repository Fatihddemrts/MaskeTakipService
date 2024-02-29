using DemoProject.Business.Abstract;
using DemoProject.DataAccess.Abstract;
using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Business.Concrete
{
    public class InstructorManager : IInstructorManager
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal) 
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Remove(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
