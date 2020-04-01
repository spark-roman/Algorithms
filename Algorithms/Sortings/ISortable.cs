using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Sortings
{
    public interface ISortable
    {
        int[] Sort([NotNull]int[] array);
    }
}