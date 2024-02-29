using DemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Business.Abstract
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor); 
        void Remove(Instructor instructor); 
        List<Instructor> GetAll();
        void Update(Instructor instructor);
    }
}
