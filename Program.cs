using FirstProject.Model;

namespace FirstProject.Startup;

internal class Program
{
    static void Main(string[] args)
    {
        Client client = new();



        (_, int price, var name, _) = client.Method();
        Console.WriteLine($"[{price}], [{name}]");



    }
}