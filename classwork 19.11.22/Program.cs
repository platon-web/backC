using System.Diagnostics;

namespace Program.PL;

//Program.Model
public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly? Birthday { get; set; }
    public string? PhoneNumber { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName} {Birthday} {PhoneNumber}";
    }
}


//Program.Utility
#region Utility
public static class ObjectLogger<T>
{
    public delegate void LoggerFuntion(T obj);
    public delegate bool FilterFunction(T obj);

    public static void Log(IEnumerable<T> objects, LoggerFuntion funtion)
    {
        foreach (T item in objects)
        {
            funtion(item);
        }
    }
    public static void Log(IEnumerable<T> objects, LoggerFuntion funtion, FilterFunction filter)
    {
        foreach (T item in objects)
        {
            if (filter(item))
                funtion(item);
        }
    }
}
#endregion

internal class Program
{    
    public static void Main()
    {
        List<Person> people = new()
        {
            new(){ FirstName = "Amanda", LastName = "Waller", Birthday = new DateOnly(1984, 12, 2), PhoneNumber = "+48264876453" },
            new(){ FirstName = "John", LastName = "Doe", Birthday = new DateOnly(1987, 7, 12), PhoneNumber = "+483532464434" },
            new(){ FirstName = "Robert", LastName = "Muller", Birthday = new DateOnly(1990, 3, 6), PhoneNumber = "+42346653244" },
            new(){ FirstName = "Sonya", LastName = "Jade", Birthday = new DateOnly(1992, 2, 5), PhoneNumber = "+4321457668542" }
        };
        people.OrderBy(p => p.LastName);

        //ObjectLogger<Person>.LoggerFuntion function = DebugLoggin;      

        //function += ConsoleLogging;

        ObjectLogger<Person>.Log(people, p => Debug.WriteLine(p), p => p.Birthday > new DateOnly(1990, 1, 1));
    }

    public static string FilterByName(Person p)
    {
        return p.LastName!;
    }



    //public static void ConsoleLogging(Person p)
    //{
    //    Console.WriteLine(p);
    //}
    //public static void DebugLoggin(Person p)
    //{
    //    Debug.WriteLine(p);
    //}



    //public static bool FilterByBirthdate(Person p) => p.Birthday > new DateOnly(1990, 1, 1);
    //public static bool FilterByName(Person p) => p.FirstName!.StartsWith("A");
}