using System;
using Algorithms.Sortings;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listToSort = new int[] { 100, 97, 3, 28, 15, 17, 6, 127 };

            var radixSort = new RadixSorting();
            var sortedList = radixSort.Sort(listToSort, 0, listToSort.Length - 1, radix: 10);

            Console.WriteLine(sortedList);
        }
    }
}
