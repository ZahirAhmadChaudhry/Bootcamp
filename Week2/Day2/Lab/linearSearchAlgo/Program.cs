namespace linearSearchAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var search = new LinearSearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            int element = 5;
            int index = search.Search(arr, element);
            Console.WriteLine("Element {0} found at index {1}", element, index);
        }
    }
}