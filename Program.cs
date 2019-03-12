using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades2
{
    class Program
    { 
        static void GIveBookAName(GradeBook book)
        {
            book.Name = "The GradeBook";
        }
        static void Main(string[] args)
        {
            
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);

        }
    }
}
