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

        public static int Max(int[] array)
        {
            var maxValue = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
    }
}