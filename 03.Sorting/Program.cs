using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and Display original Array
            IList<int> arr = new int[] {25,16,87,88,11,99,1,8,3 };
            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]+" ");
            }
            // Sort and display the sorted one
            Console.WriteLine("\nSorted Array: ");

            Sort<int>.SortBubble(arr);
            //Sort<int>.SortInsertion(arr);
            //Sort<int>.SortInsertion((int[])arr);
            //Sort<int>.SortSelection(arr);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]+" ");
            }
            // Binary Search in the Sorted Array
            int key = 25;
            int rank = BinarySearch.RankArray(key, (int[])arr);
            if (rank != -1) Console.WriteLine($"\nPosition (started from zero) of {key} is {rank}");
            else Console.WriteLine($"{key} not found!");

            Console.Read();
        }
    }
}
