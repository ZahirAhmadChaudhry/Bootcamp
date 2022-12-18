namespace aVeryBigSum
{
    internal class Program
    {
        static long aVeryBigSum(long[] arr)
        {
            long sum =0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            long[] arr = new long[long.Parse(Console.ReadLine())];
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] =long.Parse(Console.ReadLine());
            }
            long result = aVeryBigSum(arr);
            Console.WriteLine(result);
        }
    }
}