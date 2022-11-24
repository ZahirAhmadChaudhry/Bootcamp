
namespace PasswordCheck
{
    class Result
    {

        public static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            n = password.Length;
            int r = 0;
            if (password.Length != 0)
            {
                if (n < 6)
                {
                    r = 6 - n;
                }
                else
                    Console.WriteLine("Your Password is Correct");
            }
            return r;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            /*int n = Convert.ToInt32(Console.ReadLine().Trim());*/

            string password = Console.ReadLine();
            int n = 0;
            int answer = Result.minimumNumber(n, password);

            Console.WriteLine(answer);
        }
    }

}