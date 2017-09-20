using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sorting
{
    // Complexity of Binary Search Algorithm = List.Length/2
    // It's equals to Log2N
    public static class BinarySearch
    {
        public static int RankArray(int key,int[]numbers)
        {
            int lowRange = 0;
            int highRange = numbers.Length - 1;
            
            while (lowRange<=highRange)
            {
                int midRange = lowRange + (highRange - lowRange) / 2;
                if (key < numbers[midRange]) highRange = midRange - 1;
                else if (key > numbers[midRange]) lowRange = midRange + 1;
                else return midRange;
            }
            return -1;
        }
    }

    public static class BinarySearch<T> where T : IComparable<T>
    {
        public static int Rank(T key, IList<T> list)
        {
            int lowRange = 0;
            int highRange = list.Count() - 1;
            while (lowRange<=highRange)
            {
                int midRange = lowRange + (highRange - lowRange) / 2;
                if (key.CompareTo(list[midRange]) < 0) highRange = midRange - 1;
                else if (key.CompareTo(list[midRange]) > 0) lowRange = midRange + 1;
                else return midRange;
            }
            return -1;
        }
    }
}
