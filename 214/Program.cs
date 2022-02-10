using System;

namespace _214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2,1,4 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
