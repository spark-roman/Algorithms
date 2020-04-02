using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public interface ICompareSortable
    {
        int[] Sort([NotNull]int[] array, int first, int last);
    }
}