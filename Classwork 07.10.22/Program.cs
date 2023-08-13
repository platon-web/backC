using System.ComponentModel;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 101, max = 0;

            int[,] arr = new int[3, 6];
          
            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for (int h = 0; h < arr.GetLength(1); h++)
                {
                   arr[i,h] =  Random.Shared.Next(10, 100)  ;
                    Console.Write(arr[i,h]+" ");
                    if (arr[i, h] > max)  
                            max = arr[i,h]; 
                   if(arr[i,h] < min)
                        min = arr[i,h];
                }
                Console.WriteLine();
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}