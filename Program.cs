using System;

namespace sharpsortarray
{
    class Program
    {
        static void Main()
        {
            int[] array = RandomExt.GetRandomArrayInt(10, -30, 30);
            ArrayExt.Sort(array);
            ConsoleExt.WriteArrayInt(array);
            Console.ReadKey();
        }
    }
    public static class ConsoleExt
    {
        public static void WriteArrayInt(int[] array)
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
    }
    public static class ArrayExt
    {
        public static void Sort(int[] array)
        {
            int exchange = default;
            for (int i = 0; i < array.Length; i++)
                for (int j = i+1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    } 
        }
    }
    
}
