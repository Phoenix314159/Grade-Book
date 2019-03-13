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
            Immutable();
            Array();
            string name1 = "James";
            string name2 = "james";

            bool areEqual = name1.Equals(name2);
            Console.WriteLine(areEqual);

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

        private static void Array()
        {
            float[] grades;
            grades = new float[4];
            

            AddGrades(grades);
            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;
        }

        private static void Immutable()
        {
            string name = " James ";
            name = name.Trim();
            Console.WriteLine(name);

        }
    }
}
