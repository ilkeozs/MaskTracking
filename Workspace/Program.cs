using Business.Concrete;
using Entities.Concrete;

public class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "İLKE";
        person1.LastName = "İLKE";
        person1.DateOfBirthYear = 1111;
        person1.NationalIdentity = 11111111111;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadKey();
    }
}