namespace CamelCase
{
    class Program
    {
            static int CamelCase(string s)
            {
                int count = 1;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] >= 'A' && s[i] <= 'Z')

                        count += 1;
                }
                return count;
            }
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Please Enter the String: ");
            string s = Console.ReadLine();
            */
            string s = "helloThebigO";
            Console.WriteLine(CamelCase(s));
           
        }
    }
}