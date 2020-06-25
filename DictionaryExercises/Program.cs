using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;

namespace DictionaryExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string input;
            string newStudent;
            int inputNum;
            int newID;

            //Get students names
            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student: ");
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(input, ""))
                {
                    Console.WriteLine("ID: ");
                    inputNum = int.Parse(Console.ReadLine());
                    newID = inputNum;

                    students.Add(newID, newStudent);

                    // Read in the newline before looping back
                    // Console.ReadLine();
                }
            } while (!Equals(newStudent, ""));

            Console.WriteLine("\nClass roster: ");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("Student's ID " + student.Key + ": " + student.Value);
            }
           
        }
    }
}
