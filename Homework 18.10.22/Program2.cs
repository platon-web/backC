using Homework.Classes;

namespace Homework1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Shop print = new();
            print.Enter("ATB", "The best shop", "Knyahina Olga, 17", "atb@gmail.com", 2022, 380671234567);
            print.Enter();
        }
    }
}