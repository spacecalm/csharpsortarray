namespace System.ConsoleExt
{
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
}
