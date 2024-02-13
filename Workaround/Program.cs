using System.Diagnostics;
using System.Reflection.Metadata;
using Business.Concrete;
using Entities.Concrete;
namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        //Variables();
        //UsageExampleForMyList();
        //UsageExampleForMernisKPSPublic();
        Console.ReadLine();
    }

    static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    private static void Variables()
    {
        string message = "Hello!";
        double amount = 1000.5;
        int number = 12;
        bool loggedIn = true; // true || false

        string name = "Sami Can";
        string surname = "KELES";
        int BirthYear = 1996;
        long identificationNumber = 12345678901;
    }
    
    private static void UsageExampleForMyList()
    {
        MyList<string> myList = new MyList<string>();
        List<string> addList = new List<string>{"v1", "v2", "v3", "v4", "v5", "v6"};
        for (int i = 0; i < addList.Count; i++)
        {
            myList.Add(addList[i]);
        }

        ShowArray<string>(myList.values);
        myList.Delete(1);
        ShowArray<string>(myList.values);
        myList.Update(3,"v05");
        ShowArray<string>(myList.values);
    
        void ShowArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

    private static void UsageExampleForMernisKPSPublic()
    {
        Person person1 = new Person { DateOfBirthYear = 9999,
            FirstName = "Sami Can",
            LastName = "KELEŞ",
            NationalIdentity = 12345678901};
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
}
public class Citizen
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int BirthYear { get; set; }
    public long IdentificationNumber { get; set; }
}

