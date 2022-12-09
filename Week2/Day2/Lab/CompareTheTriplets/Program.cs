using System.Security.Cryptography.X509Certificates;

namespace CompareTheTriplets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] res = new int[2];
            int[] a = { 1, 2, 3 };
            int[] b = { 2, 3, 5 };
            for(int i=0; i<a.Length; i++)
            {
                
                    if (a[i] > b[i])
                    {
                        res[0] += 1;
                    }
                    else if (a[i] < b[i])
                    {
                        res[1] += 1;
                    }
            }
            foreach (int x in res)
                Console.Write(x + " ");
        }
    }
}