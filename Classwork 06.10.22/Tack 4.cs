using System;
using System.ComponentModel;
using System.Data;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int h = 0, p = 0, r = 0;
            int size = 10;
            int[] arr = new int[size];
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
      
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(size);
                Console.Write(" ");
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Random.Shared.Next(size);
                Console.Write(" ");
                Console.Write(arr1[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            while (h < size)
            {
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] == arr1[h])
                    {
                        for (int l = 0; l < size; l++)
                            if (arr[i] == arr2[l])
                                r++;
                        if (r == 0)
                        {
                            arr2[p] = arr[i];
                            Console.Write( arr2[p]+ " " );
                            p ++;
                        }
                    }
                }
                h++;
            }


        }

    }
}