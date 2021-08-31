using System;

namespace ArrayPropertiesDemo
{
    class ArrProperties
    {
        internal int ArrLength(int[] arr)
        {
            return arr.Length;
        }
        internal bool ArrIsFixed(int[] arr)
        {
            return arr.IsFixedSize;
        }
        internal bool ArrReadOnly(int[] arr)
        {
            return arr.IsReadOnly;
        }
        internal int ArrRank(int[] arr)
        {
            return arr.Rank;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int n;
            Console.Write("Enter Number of Elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrProperties ap = new ArrProperties();
            Console.WriteLine("Length of Array is: " + ap.ArrLength(arr));
            Console.WriteLine("Does array has fixed size: " + ap.ArrIsFixed(arr));
            Console.WriteLine("Is array Read Only: " + ap.ArrReadOnly(arr));
            Console.WriteLine("Rank of Array is: " + ap.ArrRank(arr));
            Console.ReadKey();
        }
    }
}