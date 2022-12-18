using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace HourGlass
{
    internal class Program
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int max = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int sum;
                    sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                    if (sum > max)
                        max = sum;
                }
            }return max;
        }
        static void Main(string[] args)
        {

             List<List<int>> arr = new List<List<int>>();

                for (int i = 0; i < 6; i++)
                {
                    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                }

                int result = hourglassSum(arr);

            Console.WriteLine(result);
        }
    }
}