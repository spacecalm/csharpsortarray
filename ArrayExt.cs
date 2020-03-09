namespace System.ArrayExt
{

    public delegate bool SortOperation(object a, object b);
    public static class ArrayExt
    {
        /// <summary>
        ///  Sort array
        ///  <example>For example:
        /// <code>
        ///    (a,b) => ((int)a.)CompareTo(b) == -1
        /// </code>
        /// sorts array from larger to smaller.
        /// </example>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">operated array type IComparable</param>
        /// <param name="sortOperation">1 argument - first position array for sort, 2 argument - second position array for sort</param>
        public static void Sort<T>(T[] array, SortOperation sortOperation)
        {
            T exchange = default;
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (sortOperation(array[i],array[j]))
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }
        }
    }
}
