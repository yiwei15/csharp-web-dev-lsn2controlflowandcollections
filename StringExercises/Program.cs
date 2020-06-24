using System;

namespace StringExercises
{
    class StringSample
    {
        public static void CreatArrayWithDelimiter(string str, string delimiter)
        {
            string[] arr;
            arr = str.Split(delimiter);
            string newStr = string.Join(",", arr);
            Console.WriteLine(newStr);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Strings!");
            string str = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house.I will not eat them with a mouse.";
            string delimiter = "";
            StringSample.CreatArrayWithDelimiter(str, delimiter); 
        }
    }
}
