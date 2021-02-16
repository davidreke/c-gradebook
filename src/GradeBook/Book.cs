using System.Collections.Generic;
using System;

namespace GradeBook {
        public class Book
        {

            // constructors have to have the same name as the class
            public Book(string name)
            {
                grades = new List<double>();
                // assign parameter to field
                Name = name;
                // this refers to the object that is being operated on.
            }
            public void AddGrade(double grade)
            {
                // 
                grades.Add(grade);
            }
           
           public Statistics GetStatistics()
           {
               var result = new Statistics();
               result.Average = 0.0;
               result.High = double.MinValue;
               result.Low = double.MaxValue;

               foreach(var grade in grades)
               {
                    result.Low = Math.Min(grade, result.Low);
                    result.High = Math.Max(grade, result.High);
                    result.Average += grade;
               }
               result.Average /= grades.Count;

               return result;
           }

    
            private List<double> grades;
            public string Name;
        }

}