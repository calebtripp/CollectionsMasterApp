using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace CollectionsMasterConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            //Call Methods Here, in this supposed order. added tasks not included in original 
            //Supposed Order

            int[] integerArray = new int[50];
            Populater(integerArray);
            //foreach (var item in integerArray)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine($"The first number of the array is {integerArray[0]}");
            Console.WriteLine();
            Console.WriteLine($"The last number of the array is {integerArray[^1]}");

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Original");
            Console.WriteLine("-------------------");

            NumberPrinter(integerArray);            

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Reversed");
            Console.WriteLine("-------------------");

            Array.Reverse(integerArray);
            foreach (var item in integerArray)
            {
                Console.WriteLine(item);
            }

            //Reverse Custom
            Console.WriteLine("-------------------");
            Console.WriteLine("REVERSE CUSTOM");
            Console.WriteLine("-------------------");
           
            ReverseArray(integerArray);
            foreach (var item in integerArray)
            {
                Console.WriteLine(item);
            }


            //Multiple of 3 = 0
            Console.WriteLine("-------------------");
            Console.WriteLine("Multiple of 3 = 0");
            Console.WriteLine("-------------------");


            //Sorted Numbers
            Console.WriteLine("-------------------");
            Console.WriteLine("Sorted Numbers");
            Console.WriteLine("-------------------");
            // line below only one or other code needed to properly function?
            Array.Sort(integerArray);

            // First number of an array?
                //there was no heading for this but it was a task? add at end if time?

            // Last number of an array?
               //there was no heading for this but it was a task? add at end if time?   

            // end arrays
            Console.WriteLine("-------------------");
            Console.WriteLine("\"\\n************End Arrays*************** \\n\"");
            Console.WriteLine("-------------------");

            Console.WriteLine();


            //Start Lists

            //What number will you search for in the number list?
            //all numbers
            //evens only
            //sorted evens


            #region Arrays                      



            //   NumberPrinter(integerArray);  //handy but not sure where it should go?


            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List


            //TODO: Print the capacity of the list to the console


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            //TODO: Print the new capacity


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable


            //TODO: Clear the list


            #endregion
        }

        ////////////////Main Method Break/////////////////  
        
        private static void ThreeKiller(int[] numbers)
        {
            foreach (var item in numbers)
            {
                if (item % 3 == 0)
                {
                    numbers[Array.IndexOf(numbers,(item % 3 == 0))] = 0; // not sure if this works? // must be an easier way??
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

        }

        private static void ListPopulater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 51);
            }
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[^1]);
        }

        private static void ReverseArray(int[] array)
        {
            int[] arr = new int[50];
            for (int i = arr.Length - 1; i > 0; i--)
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


