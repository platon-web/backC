using ConsoleApp17.Model;

namespace ConsoleApp17
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client =new Client();
            client.Method01(out int result);
            Console.WriteLine(result);
        }
    }
}