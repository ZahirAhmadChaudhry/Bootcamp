namespace _2DArray
{
    internal class Program
    {
            public static void Main()
            {
                // 2-D array
                string[,] str = new string[4, 2] {{"one", "two"},
                                                  {"three", "Four"},
                                                  {"Five", "Six"},
                                                  {"Seven", "Eight"}
                                                                    };
                // accessing elements of the array

                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 2; j++)
                    Console.WriteLine(str[i,j] + " ");
            }
    }

}