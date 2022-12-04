namespace SimpleArraySum
{
    internal class Program
    {
        public static int SimpleArraySum(int[] sam)
        {
            int sum = 0;
            for(int i = 0; i < sam.Length; i++)
            {
                sum += sam[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 3, 6, 5 };

            //calling function 

            int result = SimpleArraySum(arr);

            //Displying the result

            Console.WriteLine(result);

        }
    }
}