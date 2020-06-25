using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {   
        static int SumOfEvenNums(List<int> numList)
        {
            int sum = 0;
            foreach (int number in numList )
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        static void WordWithFiveLetters(List<string> wordList)
        {
            Console.WriteLine("Please enter the word length for search: ");
            int wordLength = int.Parse(Console.ReadLine());
            foreach (string word in wordList)
            {
                if (word.Length == wordLength)
                {
                    Console.WriteLine(word);
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 5, 10, 3, 7, 9, 20, 55, 101, 30, 23 };

            Console.WriteLine(SumOfEvenNums(numList));

            List<string> wordList = new List<string> { "Modify", "your", "codes", "to", "prompt" };

            WordWithFiveLetters(wordList);
        }
    }
}
