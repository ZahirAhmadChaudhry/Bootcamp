namespace binarySearchAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 4, 7, 10, 11, 32, 45, 87 };
            int key = 10;

            BinarySearch binarySearchObject = new BinarySearch();
            int result = binarySearchObject.BinarySearchAlgorithm(inputArray, key);

            if (result == -1)
            {
                Console.WriteLine("Element is not present in the array");
            }
            else
            {
                Console.WriteLine("Element is present at index: " + result);
            }
        }
    }
}