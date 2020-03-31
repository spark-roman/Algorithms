using System;
using Algorithms.Sorts;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listToSort = new int[] { 5, 2, 4, 6, 1, 3 };
            
            var insertSorting = new InsertionSort();
            var sortedList = insertSorting.Sort(listToSort);

            Console.WriteLine(sortedList);

            listToSort = new int[] { 5, 2, 4, 6, 1, 3 };

            var mergeSort = new MergeSort();
            sortedList = mergeSort.Sort(listToSort);

            Console.WriteLine(sortedList);

            listToSort = new int[] { 5, 2, 4, 6, 1, 3 };

            var heapSort = new HeapSort();
            sortedList = heapSort.Sort(listToSort);

            Console.WriteLine(sortedList);
        }
    }
}
