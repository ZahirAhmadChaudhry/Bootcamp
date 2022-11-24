using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace superReducedString
{
    class Solution
    {
        static string SuperReducedString(string result)
        {
            var str = new StringBuilder();
            str.Append(result[0]);

            for (var i = 1; i < result.Length; i++)
            {
                if (str.Length > 0 && result[i] == str[str.Length - 1])
                    str = str.Remove(str.Length - 1, 1);
                else
                    str.Append(result[i]);

            }
            return str.ToString();
        }

        static void Main(String[] args)
        {
            var getInput = Console.ReadLine();
            var getOut = SuperReducedString(getInput);
            Console.WriteLine(getOut == "" ? "Empty String" : getOut);
        }
    }
}