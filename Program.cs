using System;

namespace sharpsortarray
{
    class Program
    {
        static void Main()
        {
            int[] arrayInt = RandomExt.GetRandomArrayInt(10, -30, 30);
            ArrayExt.SortIComparable(arrayInt);
            ConsoleExt.WriteArrayIFormattable(arrayInt);

            Console.WriteLine();

            double[] arrayDouble = RandomExt.GetRandomArrayDouble(5);
            ArrayExt.SortIComparable(arrayDouble);
            ConsoleExt.WriteArrayIFormattable(arrayDouble);

            Console.ReadKey();
        }
    }
    public static class ConsoleExt
    {
        public static void WriteArrayIFormattable<T>(T[] array) where T : IFormattable
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                    Console.Write(", ");
            }
            Console.Write(";");
        }
    }
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
    public static class ArrayExt
    {
        public static void SortIComparable<T>(T[] array) where T : IComparable
        {
            T exchange = default;
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].CompareTo(array[j]) == -1)
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }
        }
    }
    
}
