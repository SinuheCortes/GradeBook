using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sinuhé");
            book.AddGrade(89.1);
            book.AddGrade(56.1);
            book.AddGrade(10.1);
            var result = book.GetStatistics();

            Console.WriteLine($"La calificación miníma es: {result.Low}");
            Console.WriteLine($"La calificación más alta es: {result.High}");
            Console.WriteLine($"El promedio de calificación es: {result.Average:N1}");


        }
    }
}
