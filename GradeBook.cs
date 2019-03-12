using System;
using System.Collections.Generic;

namespace Grades2
{
    class GradeBook
    {
      public void AddGrade(float grade)
      {
            _grades.Add(grade);
              
      }

        List<float> _grades = new List<float>();
    }
}
