using System;
using System.Collections.Generic;
using System.Linq;

namespace L02_Avarage_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();


            for (int i = 0; i < numOfStudents; i++)
            {
                var readInput = Console.ReadLine().Split(" ").ToList();
                var name = readInput[0];
                var grade = double.Parse(readInput[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }

                students[name].Add(grade);
            }


            foreach (var kvpStudent in students)
            {
                Console.WriteLine($"{kvpStudent.Key} -> {String.Join(" ",kvpStudent.Value.Select(x => string.Format($"{x:F2}")))} (avg: {kvpStudent.Value.Average():F2})");
            }

        }
    }
}
