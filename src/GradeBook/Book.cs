using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;

            foreach (double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"La calificación miníma es: {lowGrade}");
            Console.WriteLine($"La calificación más alta es: {highGrade}");
            Console.WriteLine($"El promedio de calificación es: {result:N1}");
        }
        private List<double> grades;
        private string name;
    }
}