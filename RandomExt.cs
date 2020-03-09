namespace System.RandomExt
{
    public static class RandomExt
    {
        public static int[] GetRandomArrayInt(int count, int startRange = int.MinValue, int endRange = int.MaxValue)
        {
            Random random = new Random();
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = random.Next(startRange, endRange);
            return result;
        }
        public static double[] GetRandomArrayDouble(int count)
        {
            Random random = new Random();
            double[] result = new double[count];
            for (int i = 0; i < count; i++)
                result[i] = random.NextDouble();
            return result;
        }
    }
}
