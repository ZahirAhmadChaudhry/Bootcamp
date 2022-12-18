using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace functionWithPara
{
    internal class Program
    {
        static void FuncWithPara(string name)
        {
           
            // Printing on the console

            Console.WriteLine("Hello!" + name + ", how are your?\n" + "How are you doing?");
        }
        static void Main(string[] args)
        {
            // Taking input from the user
            Console.WriteLine("Please Enter Your Name: \n");
            string nam = Console.ReadLine();
            FuncWithPara(nam);
        }
    }
}