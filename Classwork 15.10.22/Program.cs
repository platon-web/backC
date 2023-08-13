using ConsoleApp22.FirstProject.Model;

namespace FirstProject.Startup;
internal class Program
{
    public static void Main(string[] args)
    {
        Client client1 = new();
        Client client2 = new();
        Client client3 = new();

        Console.WriteLine(client1);
        Console.WriteLine(client2);
        Console.WriteLine(client3);
    }
}