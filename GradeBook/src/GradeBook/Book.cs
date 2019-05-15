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
        public Statistics getStatistics()
        {
            var result = new Statistics();
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            

            foreach (var grade in grades)
            {
                if (grade < result.Low) result.Low = grade;
                if (grade > result.High) result.High = grade;

                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
        String name;
        List<double> grades;
    }
}
