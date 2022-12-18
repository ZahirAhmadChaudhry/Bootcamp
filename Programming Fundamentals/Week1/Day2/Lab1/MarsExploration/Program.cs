namespace MarsExploration
{
    using System.IO;
    
    class Result
    {

        /*
         * Complete the 'marsExploration' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int marsExploration(string s)
        {
            int numAltered = 0;

            for (int i = 0; i < s.Length; i += 3)
            {
                if (s[i] != 'S')
                    numAltered++;
                if (s[i + 1] != 'O')
                    numAltered++;
                if (s[i + 2] != 'S')
                    numAltered++;
            }
            return numAltered;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int result = Result.marsExploration(s);

            Console.WriteLine(result);
        }
    }

}