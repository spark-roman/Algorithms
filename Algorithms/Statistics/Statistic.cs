namespace Algorithms.Statistics
{
    public class Statistic
    {
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

        public static int Min(int[] array)
        {
            var minValue = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }
    }
}
