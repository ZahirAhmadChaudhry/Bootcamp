using System;
public class LinearSearch
{
    public int Search(int[] arr, int element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                return i;
            }
        }
        return -1;
    }
}
