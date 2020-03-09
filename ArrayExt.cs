namespace System.ArrayExt
{ 
    //enum CompireToState: int
    //{
    //    LESS = 1,
    //    ZERO = 0,
    //    GEATER = -1
    //} 

    public static class ArrayExt
    {
        public static void SortIComparable<T>(T[] array, int compireToState = -1 ) where T : IComparable
        {
            T exchange = default;
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].CompareTo(array[j]) == compireToState)
                    {
                        exchange = array[i];
                        array[i] = array[j];
                        array[j] = exchange;
                    }
        }
    }
}
