using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sorts
{
    public interface ISortable
    {
        int[] Sort([NotNull]int[] array);
    }
}