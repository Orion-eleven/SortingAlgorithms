using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace SortComparison
{
    class Program
    {
        class SortAlgorithm
        {
            // Function to sort array using insertion sort
            void insertionSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 1; i < n; ++i)
                {
                    int key = arr[i];
                    int j = i - 1;

                    // Move elements of arr[0..i-1],
                    // that are greater than key,
                    // to one position ahead of
                    // their current position
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }
            }

            //Function to sort array using Bubble sort
            void bubbleSort(int[] arr)
            {
                
                int temp;
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                
            }


            // function to print sorted array
            static void printArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(+arr[i] + " ");

                Console.Write("\n");
            }

            static void Main(string[] args)
            {
                //hardcoded array:
                int[] arr = { 78, 55, 45, 98, 13, 14};

                //randomly generated array of 100 random numbers:
                /*Random r = new Random();
                int[] arr = new int[100];
                int last = 0;
                for (int a = 0; a < arr.Length; a++)
                {
                    last = last + r.Next(10) + 1;
                    arr[a] = last;
                }*/

                //print unsorted array
                Console.WriteLine("--------------------------------------------\n" + "PROGRAM TO CALCULATE SORTING ALGORITHM TIMES"+
                    "\n--------------------------------------------");
                Console.WriteLine("Unsorted array:");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine("\n");


                //Employ sorting methods

                SortAlgorithm sor = new SortAlgorithm();

                var insertionTimer = new Stopwatch();
                insertionTimer.Start();
                sor.insertionSort(arr);
                printArray(arr);
                insertionTimer.Stop();
                TimeSpan timeTaken = insertionTimer.Elapsed;
                string foo = timeTaken.ToString(@"s\.fffffff");
                
                Console.WriteLine("Insertion sort completed in " + foo+" seconds");

                var bubbleTimer = new Stopwatch();
                bubbleTimer.Start();
                sor.bubbleSort(arr);
                bubbleTimer.Stop();
                TimeSpan timeTaken2 = bubbleTimer.Elapsed;
                string foo2 = timeTaken2.ToString(@"s\.fffffff");
                //foreach (int p in arr)
                // Console.Write(p + " ");
                Console.WriteLine("\n");
                printArray(arr);
                Console.WriteLine("Bubble sort completed in " + foo2 + " seconds");
                Console.Read();

               
            }


        }
    }
}
