namespace Algorithms.Utils
{
    public static class RelatedActionsHelper
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}