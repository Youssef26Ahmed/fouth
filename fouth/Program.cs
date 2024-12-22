using System;
using System.Collections.Generic;

namespace fouth
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            /*
            Console.Write("Enter the size of the identity matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region 2 

            /*
            // Initialize the array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Variable to store the sum
            int sum = 0;

            // Loop through the array and calculate the sum
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Output the result
            Console.WriteLine("The sum of all elements in the array is: " + sum);

            */

            #endregion

            #region 3 
            /*
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 4, 6, 8 };
            int[] mergedArray = MergeSortedArrays(array1, array2);

            Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
            */
            #endregion

            #region 4
            /*
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            foreach (int element in array)
            {
                if (frequencyDict.ContainsKey(element))
                {
                    frequencyDict[element]++;
                }
                else
                {
                    frequencyDict[element] = 1;
                }
            }

            Console.WriteLine("Element Frequencies:");
            foreach (KeyValuePair<int, int> kvp in frequencyDict)
            {
                Console.WriteLine($"Element {kvp.Key}: {kvp.Value} times");
            }
            */
            #endregion


            #region 5

            /*
            // Sample array
            int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };

            // Initialize max and min with the first element of the array
            int max = numbers[0];
            int min = numbers[0];

            // Loop through the array to find max and min
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            // Output the results
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
            */

            #endregion

            #region 6

            /*
            int[] array = { 10, 20, 4, 45, 99, 6 };
            int first, second;

            if (array.Length < 2)
            {
                Console.WriteLine("Array should have at least two elements.");
                return;
            }

            first = second = int.MinValue;

            foreach (int number in array)
            {
                if (number > first)
                {
                    second = first;
                    first = number;
                }
                else if (number > second && number != first)
                {
                    second = number;
                }
            }

            if (second == int.MinValue)
            {
                Console.WriteLine("There is no second largest element.");
            }
            else
            {
                Console.WriteLine("The second largest element is: " + second);
            }
            */
            #endregion

            #region  7,8
            /*
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            int[] array = Array.ConvertAll(elements, int.Parse);
            int maxDistance = FindMaxDistance(array);
            Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);
            */

            #endregion


            #region 9

            /*
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string reversedSentence = ReverseWords(sentence);

            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(reversedSentence);
            */


            #endregion


            #region 10

            /*
            // Define the size of the arrays
            int rows = 3;
            int cols = 3;

            // Initialize the arrays
            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            // Accept values from the user for the first array
            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy elements from the first array to the second array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            // Print the second array
            Console.WriteLine("Elements of the second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region 11

            // Define the array
            int[] array = { 1, 2, 3, 4, 5 };

            // Print the array in reverse order
            Console.WriteLine("Array in reverse order:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }


            #endregion
        }

        /*
        //this function is related to region 3
        static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int[] mergedArray = new int[2 * n];
            int i = 0, j = 0, k = 0;

            while (i < n && j < n)
            {
                if (arr1[i] <= arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }

            while (i < n)
            {
                mergedArray[k++] = arr1[i++];
            }

            while (j < n)
            {
                mergedArray[k++] = arr2[j++];
            }

            return mergedArray;

        }
        */


        // the below fuction is related to region 7,8
        /*
        static int FindMaxDistance(int[] array)
        {
            Dictionary<int, int> firstIndexMap = new Dictionary<int, int>(); int maxDistance = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (firstIndexMap.ContainsKey(array[i]))
                {
                    int distance = i - firstIndexMap[array[i]];
                    if (distance > maxDistance)
                    {
                        maxDistance = distance - 1;
                    }
                }
                else
                {
                    firstIndexMap[array[i]] = i -1;
                }
            }
            return maxDistance;
        }
        */

        /*
        static string ReverseWords(string sentence)
        {
            // Split the sentence into words
            string[] words = sentence.Split(' ');

            // Reverse the array of words
            Array.Reverse(words);

            // Join the words back into a sentence
            return string.Join(" ", words);
        }
        */
    }
}
