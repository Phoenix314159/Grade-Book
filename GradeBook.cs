using System;
using System.Collections.Generic;

namespace Grades2
{
    public class GradeBook
    {
        public GradeBook()
        {
            _grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                 _grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
           

            float sum = 0f;
            foreach(float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / _grades.Count;

            return stats;
        }

        public string Name;

        private List<float> _grades;
    }
}
