using System.Globalization;

namespace HourGlass
{
    internal class Program
    {
        public class Hourglass
        {
            public static int hourglassSum(int[,] arr)
            {
                int maxSum = int.MinValue;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int sum = arr[i,j] + arr[i,j + 1] + arr[i,j + 2] +
                                arr[i + 1,j + 1] +
                                arr[i + 2,j] + arr[i + 2,j + 1] + arr[i + 2,j + 2];

                        maxSum = Math.Max(maxSum, sum);
                    }
                }
                return maxSum;
            }

            public static void Main(string[] args)
            {
                int[,] array = new int[6, 6];
                int result = 0;
                Console.WriteLine("Enter the elements of the 6x6 array:");
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine());
                        
                    }
                }
                result = hourglassSum(array);
                Console.WriteLine("\n" + result);
            }
        }
    }
}