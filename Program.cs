using System;
using System.Diagnostics.Metrics;

namespace GA_SelectionSort_MeiliZheng 
{
    public class Program
    {        
        static void Main(string[] args)// Selection sort _ MeiliZheng
        {
            //Declare array
            int[] ints;
            //Call SelectionSort Methos, will return both sorted and unsorted random array
            SelectionSort(RandomArray());
        }

        //Random Array method
        static int[] RandomArray()
        {
            // Create an instance of the Random class for generating random numbers
            Random random = new Random();

            // Create two int variables for the number range
            int minNum = 1;
            int maxNum = 101;

            // Initialize an array with size 10
            int[] RandomArray = new int[10];

            // Populate the array with random numbers within the specified range
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(minNum, maxNum);
            }

            // Print the unsorted array
            Console.WriteLine("Unsorted Array:");

            //use foreach to display each number
            foreach (int i in RandomArray)
            {
                Console.WriteLine(i);
            }

            // Return the generated array
            return RandomArray;
        }

        //SelectionSort Method
        static int[] SelectionSort(int[] intArray)
        {
            // Outer loop to traverse the array
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                // Assume the current index is the minimum
                int minIndex = i;

                // Inner loop to find the minimum element in the unsorted part of the array
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    // Compare the current element with the element at the assumed minimum index
                    if (intArray[j] < intArray[minIndex])
                    {
                        // If a smaller element is found, update the minimum index
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the element at the current outer loop index
                int temp = intArray[i];
                intArray[i] = intArray[minIndex];
                intArray[minIndex] = temp;
            }

            // Print the sorted array to the console
            Console.WriteLine("Sorted Array:");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            // Return the sorted array
            return intArray;
        }

    }
}