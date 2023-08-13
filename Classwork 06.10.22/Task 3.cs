namespace tack_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(11);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter progression of numbers");
            Console.WriteLine();
            int[] arrNum3 = new int[3];
            for (int i = 0; i < arrNum3.Length; i++)
            {
                Console.Write(i + 1 + ": ");
                int.TryParse(Console.ReadLine(), out arrNum3[i]);
            }
            int progression = 0;
            for (int i = 0, h = 0; i < arr.Length; i++)
            {
                if (arr[i] == arrNum3[h++])
                {
                    if (h == arrNum3.Length)
                    {
                        progression++;
                        h = 0;
                    }
                }
                else
                    h = 0;
            }
            Console.WriteLine("PROGRESSION: " + progression);
        }
    }
}