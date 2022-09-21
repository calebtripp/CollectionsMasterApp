using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
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

            Console.WriteLine("-------------------");
            Console.WriteLine("REVERSE CUSTOM");
            Console.WriteLine("-------------------");

            ReverseArray(integerArray);
            foreach (var item in integerArray)
            {
                Console.WriteLine(item);
            }

            //Multiple of 3 = 0 // the method for this doesn't work yet. 
            Console.WriteLine("-------------------");
            Console.WriteLine("Multiple of 3 = 0");
            Console.WriteLine("-------------------");

            ThreeKiller(integerArray);       
            foreach (var item in integerArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Sorted Numbers");
            Console.WriteLine("-------------------");

            Array.Sort(integerArray);
            foreach (var item in integerArray)
            {
                Console.WriteLine(item);
            }
                        
            Console.WriteLine("-------------------");
            Console.WriteLine("\n************End Arrays***************\n");
            Console.WriteLine("-------------------");

            Console.WriteLine();

            Console.WriteLine("\n************Start Lists***************\n");

            var integerList = new List<int>();
            Console.WriteLine($"The starting capacity of this list is: {integerList.Capacity}\n");

            Populater(integerList);

            Console.WriteLine($"The current capacity of this list is: {integerList.Capacity}\n");


            //What number will you search for in the number list?
            //all numbers
            //evens only
            //sorted evens

            #region Arrays                    

            #endregion

            #region Lists

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            //TODO: Print the new capacity


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            
            NumberPrinter(integerList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            
            Console.WriteLine("Evens Only!!");
          
            OddKiller(integerList);                    


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
            for (int i = 0; i < numbers.Length; i++)
            {
                foreach (var item in numbers)
                {
                    if (item % 3 == 0)
                    {
                       // intem * 0;   ////numbers.SetValue(0) ? 
                    }
                }
            }
            //foreach (var item in numbers)
            //{
            //    if (item % 3 == 0)
            //    {
            //        numbers[Array.IndexOf(numbers,(item % 3 == 0))] = 0; // not sure if this works? // must be an easier way??
            //    }
            //}
        }

        private static void OddKiller(List<int> numberList)
        {
            List<int> evens = new List<int>();

            for (int i = 1; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    evens.Add(i);
                }
                Console.WriteLine(evens);
                Console.WriteLine(  );
                Console.WriteLine(SortedList.evens);
                
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

        }

        private static void Populater(List<int> numberList)  //0-50
        {
            Random rng = new Random();

            for (int i = 0; i < 52; i++)
            {
                numberList[i] = rng.Next(1,50);
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


