using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        { 
            var book = new Book("David's grade book");
            book.AddGrade(89.1);
            book.AddGrade(29.1);
            book.AddGrade(87.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"Low: {stats.Low}");
            Console.WriteLine($"High: {stats.High}");
            Console.WriteLine($"Average: {stats.Average:N1}");
        }
    }

}