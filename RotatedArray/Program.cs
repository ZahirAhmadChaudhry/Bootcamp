namespace RotatedArray
{
    internal class Program
    {
        //Declaring an Rotated array function
        public static int[] LeftRotation(int[] array, int numRotations)
        {
            // Declaring an temp array with Null index valuse
            int[] rotatedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int newIndex = (i + numRotations) % array.Length;
                rotatedArray[newIndex] = array[i];
            }

            return rotatedArray;
        }
        static void Main(string[] args)
        {
            // Input declaration and initialization
            int[] arr = { 1, 2, 3, 4, 5 };
            // Number of iterations 
            int d = 2;
            //calling the function
            arr = LeftRotation(arr, d);

            //Displaying the rotated array
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}