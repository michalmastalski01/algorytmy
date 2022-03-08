using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 4, 55 };
            Console.WriteLine(Suma(arr, arr.Length));
        }

        static int Suma(int[] arr, int i)
        {
            if (i == 0) return 0;
            return (Suma(arr, i - 1) + arr[i - 1]);            
        }
    }
}
