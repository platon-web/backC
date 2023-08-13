namespace ConsoleApp3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int N = 10, M = 20;
            int[] arr01 = new int[N];
            int[] arr02 = new int[M];
            for (int i = 0; i < N; i++)
            {
                arr01[i] = Random.Shared.Next(10);
                Console.Write(arr01[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                arr02[i] = Random.Shared.Next(10);
                Console.Write(arr02[i] + " ");
            }
            Console.WriteLine();
            int sizeResult = N < M ? N : M;
            int[] arrResult = new int[sizeResult];
            int resIter = 0;
            for (int i = 0; i < sizeResult; i++)
            {
                bool leave = false;
                for (int j = 0; j < sizeResult; j++)
                {
                    if (arr01[i] == arrResult[j])
                        leave = true;
                    if (leave)
                        break;
                }
                if (leave)
                    continue;
                for (int j = 0; N < M ? j < N : j < M; j++)
                    if (arr01[i] == arr02[j])
                    {
                        arrResult[resIter++] = arr01[i];
                        break;
                    }
            }
            foreach (int i in arrResult)
                Console.Write(i + " ");
        }
    }
}