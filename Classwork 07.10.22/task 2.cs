namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words: ");
            string enter = Console.ReadLine();
            string[] text;
            text = enter.Split(' ');
            Console.Write("num words : ");
            Console.WriteLine(text.Length);
        }
    }
}