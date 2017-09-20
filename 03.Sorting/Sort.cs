using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sorting
{
    public static class Sort<T> where T : IComparable<T>
    {
        // Bubble Sort
        public static void SortBubble(IList<T> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = list.Count-1; j > i; j--)
                {
                    if(list[j-1].CompareTo(list[j])>0)
                    {
                        T temp = list[j-1];
                        list[j-1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        // Insertion Sort
        public static void SortInsertion(IList<T> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                T key = list[i];
                int j = i - 1;
                while ( j >=0 && list[j].CompareTo(key)>0)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }
        public static void SortInsertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        // Selection Sort
        public static void SortSelection(IList<T> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[minIndex]) < 0) minIndex = j;
                }
                T temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }
        }
    }
}
