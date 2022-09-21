using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[50];
            Populater(integerArray);

            Console.WriteLine("\n************Start Arrays***************\n");

            Console.WriteLine($"The first number of the array is: {integerArray[0]}");
            Console.WriteLine();
            Console.WriteLine($"The last number of the array is: {integerArray[^1]}");
            Console.WriteLine();

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Original");
            Console.WriteLine("-------------------\n");
            NumberPrinter(integerArray);

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Reversed");
            Console.WriteLine("-------------------\n");
            Array.Reverse(integerArray);
            NumberPrinter(integerArray);
         
            Console.WriteLine("-------------------");
            Console.WriteLine("REVERSE CUSTOM");
            Console.WriteLine("-------------------\n");
            ReverseArray(integerArray);
            NumberPrinter(integerArray);          

            Console.WriteLine("-------------------");
            Console.WriteLine("Multiple of 3 = 0");
            Console.WriteLine("-------------------\n");
            ThreeKiller(integerArray);
            NumberPrinter(integerArray);
           
            Console.WriteLine("-------------------");
            Console.WriteLine("Sorted Numbers");
            Console.WriteLine("-------------------\n");
            Array.Sort(integerArray);
            NumberPrinter(integerArray);
            
            Console.WriteLine("-------------------");
            Console.WriteLine("\n************End Arrays***************\n");
            Console.WriteLine("-------------------\n");

            Console.WriteLine();

            Console.WriteLine("************Start Lists***************\n");
            var integerList = new List<int>();

            Console.WriteLine("-------------------");
            Console.WriteLine($"The starting capacity of this list is: {integerList.Capacity}");
            Console.WriteLine("-------------------\n");
            Populater(integerList);          
           
            Console.WriteLine("-------------------");
            Console.WriteLine($"The current capacity of this list is: {integerList.Capacity}");
            Console.WriteLine("-------------------\n");

            Console.WriteLine("-------------------");
            Console.WriteLine("What number will you search for in the number list ?");
            Console.WriteLine("-------------------\n");
            bool couldParse = int.TryParse(Console.ReadLine(), out int searchNumber);

            while (!couldParse)
            {
                Console.WriteLine("Your input wasn't a number, please try again.");

                Console.WriteLine("What number will you search for in the number list ?");
                couldParse = int.TryParse(Console.ReadLine(), out searchNumber);
            }
           
            NumberChecker(integerList, searchNumber);

            #region Arrays                    

            #endregion

            #region Lists                  

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers:");
            Console.WriteLine("-------------------\n");
            NumberPrinter(integerList);

            Console.WriteLine("-------------------");
            Console.WriteLine("Evens Only!!");
            Console.WriteLine("-------------------\n");
            OddKiller(integerList);
            NumberPrinter(integerList);

            Console.WriteLine("------------------");
            Console.WriteLine("Sorted Evens!!");
            Console.WriteLine("-------------------\n");
            integerList.Sort();
            NumberPrinter(integerList);

            Console.WriteLine("-------------------");
            Console.WriteLine("The list will now be converted to an array");
            Console.WriteLine("-------------------\n");
            int[] myArray = integerList.ToArray();

            Console.WriteLine("-------------------");
            Console.WriteLine("The list will now be cleared");
            Console.WriteLine("-------------------\n");
            integerList.Clear();
            #endregion
        }

        ////////////////Main Method Break/////////////////  

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }
             

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is in the list. Please press enter to continue");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"{searchNumber} is not in the list. Please press enter to continue");
                Console.ReadLine();
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i <= 50; i++)
            {
                numberList.Add(rng.Next(1, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            int[] arr = new int[50];
            for (int i = arr.Length - 50; i > 0; i--)  //why ido i need -50 to get rid of the zeros?
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}


