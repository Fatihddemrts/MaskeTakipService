using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();

for(int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}