using System;

namespace ArrayGradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int maxStudents = 30;
            string[] students = new string[maxStudents];
            double[] grades = new double[maxStudents];
            string input;
            string newStudent;
            int studentCount = 0;

            Console.WriteLine("Enter your students (or ENTER to finish): ");

            //Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students[studentCount] = newStudent;
                    studentCount++;
                }
            } while (studentCount < maxStudents && !Equals(newStudent, ""));

            int i = 0;
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                input = Console.ReadLine();
                double grade = Double.Parse(input);
                grades[i] = grade;
                i++;
                if (i == studentCount)
                {
                    break;
                }
            }

            Console.WriteLine("\nClass roster");
            double sum = 0;

            for (int j = 0; j < studentCount; j++)
            {
                Console.WriteLine(students[j] + " (" + grades[j] + ")");
                sum += grades[j];
            }

            double average = sum / studentCount;

            Console.WriteLine("Average grade: " + average);

        }
    }
}
