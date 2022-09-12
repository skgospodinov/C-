using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name)) 
                {
                    grades.Add(name, new List<double>());
                }
                grades[name].Add(grade);

            }
            foreach (var (nameKey, gradeValue) in grades)
            {
                var gradeValuesAv = gradeValue.Average();
                var formatedGrade = string.Join(' ', gradeValue.Select(x=> x.ToString("F2")));

                Console.WriteLine($"{nameKey} -> {formatedGrade} (avg: {gradeValuesAv:F2})");
            }
        }
    }
}
