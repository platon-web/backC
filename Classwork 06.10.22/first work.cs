namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] arr1 = new int[5] { 5, 3, 2, 1, 6 };
            int[] arr2 = new int[] { 4, 23, 8, 6, 2 };
            int[] arr3 = { 3, 6, 1, 10, 2, 1 };
            int value = arr3[0];
            arr3[0] += 5;
            Console.WriteLine(value);   
            for(int i = 0; i<arr3.Length; i++ )
                Console.WriteLine(arr3[i]); 

            Console.WriteLine();   
            
            foreach (int current in arr3)
                Console.WriteLine(current);
            Random.Shared.Next(23, 155);
        }
    }
}