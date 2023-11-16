namespace Sorting_Objects;

public delegate bool CompareTo(object? obj);

public class ArrayTools
{
    public static void Sort(object[] array, CompareTo compareTo)
    {
        object temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].compareTo(array[j + 1]))
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

    }
}