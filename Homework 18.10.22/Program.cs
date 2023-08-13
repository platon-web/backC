using ConsoleApp25.Class;

namespace Dishes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine print = new();
            print.Enter("The dishes of Ukraine", "How create tasty borsch ", "magazine@gmail.com", 1983, 3800968452340);
            print.Print();
        }
    }
}