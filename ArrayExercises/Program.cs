using System;
using System.Runtime.InteropServices;

namespace ArrayExercises
{
    class IntArray
    {
        //Loop through the array and print out each value
        public static void LogNumbers(int[] intArr)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }
        }

        //Use foreach loop to iterate items to print out each value

        public static void LogNumbersForeachLoop(int[] intArr)
        {
            foreach (int i in intArr)
            {
                Console.WriteLine(i);
            }
        }

        //Loop through, only print the odd numbers
        public static void LogOddNumbers(int[] intArr)
        {

            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 == 1)
                {
                    Console.WriteLine(intArr[i]);
                }
            }
        }

    }
    class Program
    {
        static int[] integers = { 1, 1, 2, 3, 5, 8 };
        static void Main(string[] args)
        {
            int[] integersVal = { 1, 1, 2, 3, 5, 8 };

            IntArray.LogNumbers(integersVal);
            Console.WriteLine('\n');
            IntArray.LogNumbers(integers);
            IntArray.LogOddNumbers(integers);
            Console.WriteLine('\n');
            IntArray.LogNumbersForeachLoop(integers);

        }
    }
}

/*Case1 Do array exercise within Main method;
  Case2 Put array exercise into a method within program class; 
        class Program (Main method(within Main method, call other methods), other methods)
  Case3 Pass the array value into a method within Program class
  Case4 Initialize the array value as a member field of Program Class.
        (avoid creating static member variables for right now, we'd better creat variable in
        main method) 
  Case5/6 Define a static method in another class; array varible can be defined 
        in either program class or main method;
*/
