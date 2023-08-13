namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for(int i =0 ; i < 3; i++)    
            int.TryParse(Console.ReadLine(), out a);
            int[] arr = new int[20];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(a);
                Console.Write(arr[i]+" ");
            }
        }
    }
}