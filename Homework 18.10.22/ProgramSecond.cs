using System.IO;
using Homework.home;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop a = new();
            a.Enter("ATB", "market ATB", "Leva Tolstogo 1", "atb@gmail.com",  3800963451786);
            a.Print();
        }
    }
}