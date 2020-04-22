using System;
using Algorithms.Sortings;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listToSort = new int[] { 5, 2, 4, 6, 1, 3, 9, 7, 8 };

            var countingSort = new CountingSorting();
            var sortedList = countingSort.Sort(listToSort, 0, listToSort.Length - 1, maxValue: 9);

            Console.WriteLine(sortedList);

            listToSort = new int[] { 100, 97, 3, 28, 15, 17, 6, 127 };

            var radixSort = new RadixSorting();
            sortedList = radixSort.Sort(listToSort, 0, listToSort.Length - 1, radix: 10);

            Console.WriteLine(sortedList);
        }
    }
}
