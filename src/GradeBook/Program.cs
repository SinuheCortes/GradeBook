using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Sinuhé");

            EnterGrades(book);
            var result = book.GetStatistics();

            Console.WriteLine($"La calificación miníma es: {result.Low}");
            Console.WriteLine($"La calificación más alta es: {result.High}");
            Console.WriteLine($"El promedio de calificación es: {result.Average:N1}");
            Console.WriteLine($"La letra es: {result.letter}");

        }

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Ingresa calificación o ingresa q para salir");
                var input = Console.ReadLine();
                if (input == "Q" || input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("****");
                }

            }
        }

        static void OnGradeAdded(Object sender, EventArgs e)
        {
            Console.WriteLine("Calificación fue agregada");
        }
    }
}
