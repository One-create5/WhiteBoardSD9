using System;

namespace SortIntArray
{
    public class SortIntArray
    {
        static public int[] SortArray(int[] arr)
        {

            int arrayLength = arr.Length - 1;
            int[] newArray = new int[arr.Length];

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }

    }
}
