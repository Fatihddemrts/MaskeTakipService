using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "FATİH";
        person1.LastName = "DEMİRTAŞ";
        person1.DateOfBirthYear = 2000;
        person1.NationalIdentity = 12345;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }
}