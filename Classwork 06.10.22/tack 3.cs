namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter sequence of numbers\n");
            int[] arrSeq = new int[3];
            for (int i = 0; i < arrSeq.Length; i++)
            {
                Console.Write(i + 1 + " >> ");
                int.TryParse(Console.ReadLine(), out arrSeq[i]);
            }
            int numOfRepet = 0;
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] == arrSeq[j++])
                {
                    if (j == arrSeq.Length)
                    {
                        numOfRepet++;
                        j = 0;
                    }
                }
                else
                    j = 0;
            }
            Console.WriteLine("REPETITIONS: " + numOfRepet);
        }
    }
}