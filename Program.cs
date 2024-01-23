namespace GA_SelectionSort_MeiliZheng 
{
    internal class Program
    {
        static void Main(string[] args)// Selection sort _ MeiliZheng
        {
            int[] ints = { 1, 12, 3, 24, 15, 6, 27, 18 };
            PrintArray(ints);

        }

        static void PrintArray(int[] intArray)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}