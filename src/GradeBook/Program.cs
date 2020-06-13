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
            book.ShowStatistics();


        }
    }
}
