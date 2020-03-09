using System;
using System.ConsoleExt;
using System.RandomExt;
using System.ArrayExt;

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
}
