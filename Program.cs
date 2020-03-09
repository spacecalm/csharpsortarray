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
            ArrayExt.Sort(arrayInt, (a,b) => ((int)a).CompareTo(b) == -1);
            ConsoleExt.WriteArrayIFormattable(arrayInt);

            Console.WriteLine();

            double[] arrayDouble = RandomExt.GetRandomArrayDouble(5);
            ArrayExt.Sort(arrayDouble, (a, b) => ((double)a).CompareTo(b) == 1);
            ConsoleExt.WriteArrayIFormattable(arrayDouble);

            Console.ReadKey();
        }
    }
}
