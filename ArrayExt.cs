namespace System.ArrayExt
{
    public static class ArrayExt
    {
        public static void SortIComparable<T>(T[] array, SortDirection  sortDirection = SortDirection.GEATER) where T : IComparable
        {
            T exchange = default;
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].CompareTo(array[j]) == (int)sortDirection)
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }
        }
    }

    public enum SortDirection : int
    {
        LESS = 1,
        GEATER = -1
    }

}
