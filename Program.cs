using System.Diagnostics.Metrics;

namespace GA_SelectionSort_MeiliZheng 
{
    public class Program
    {        
        static void Main(string[] args)// Selection sort _ MeiliZheng
        {            
            int[] ints;
            SelectionSort(RandomArray());
        }

        static int[] RandomArray()
        {
            Random random = new Random();
            int minNum = 1;
            int maxNum = 101;
            int[] RandomArray = new int[10];
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(minNum, maxNum);
            }
            Console.WriteLine("Unsorted Array:");
            foreach (int i in RandomArray)
            {
                Console.WriteLine(i);
            }

            return RandomArray;
        }

        static int[] SelectionSort(int[] intArray)
        {

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < intArray.Length; j++)
                {

                    if (intArray[j] < intArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = intArray[i];
                intArray[i] = intArray[minIndex];
                intArray[minIndex] = temp;

            }
            Console.WriteLine("Sorted Array:");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }
            return intArray;
        }

    }
}