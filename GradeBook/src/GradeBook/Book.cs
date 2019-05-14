using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(String name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void showStatistics()
        {
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;
            var result = 0.0;
            foreach (var grade in grades)
            {
                if (grade < minValue) minValue = grade;
                if (grade > maxValue) maxValue = grade;

                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"MaxValue is {maxValue}");
            Console.WriteLine($"minValue is {minValue}");
            Console.WriteLine($"Average is {result}");

        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
        String name;
        List<double> grades;
    }
}
