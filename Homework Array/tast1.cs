using System.Net.NetworkInformation;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chet = 0;
            int neChet = 0;
            int uniq = 0;
            int  uniqi=20;
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(11);
                Console.Write(" ");
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            foreach(int item in arr)
            {
                if (item % 2 ==0 )
                    chet++;
                if(item % 2 !=0)
                    neChet++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        uniq++;
                        break;
                    }
                }

            } 
            uniqi -= uniq;
            Console.WriteLine();
            Console.Write("Chet ");
            Console.Write(chet);
            Console.WriteLine();
            Console.Write("Ne Chet ");
            Console.WriteLine(neChet);
            Console.Write("uniq ");
            Console.Write(uniqi);
        }
    }
}