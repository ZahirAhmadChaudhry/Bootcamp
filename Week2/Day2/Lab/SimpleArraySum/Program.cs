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
            int[] arr = new int[5];

            for(int i=0; i<5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //calling function 

            int result = SimpleArraySum(arr);

            //Displying the result

            Console.WriteLine(result);

        }
    }
}