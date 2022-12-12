namespace HackerRankIsAString
{
    using System.IO;
    
    class Result
    {

        /*
         * Complete the 'hackerrankInString' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string hackerrankInString(string s)
        {

            string hackerrank = "hackerrank";

            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (j < hackerrank.Length && s[i] == hackerrank[j])
                {
                    j++;
                }
            }

            if (j == hackerrank.Length)
            {
                return "YES";
            }

            return "NO";
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = Result.hackerrankInString(s);

                Console.WriteLine(result);
            }

        }
    }

}