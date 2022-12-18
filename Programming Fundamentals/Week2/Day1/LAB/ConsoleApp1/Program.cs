namespace ReverseArray
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }

            Console.WriteLine("Reversed Array:");
            foreach (int j in reversedArray)
            {
                Console.Write(j + " ");
            }
        }
    }
}