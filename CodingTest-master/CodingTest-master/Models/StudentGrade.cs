using System;
using System.Collections.Generic;

namespace CodingTest.Models
{
    public class StudentGradeVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberGrade { get; set; }
        public string LetterGrade { get; set; }
        public int Count { get; set; }

        public List<StudentGradeVM> LetterGradeCount = new List<StudentGradeVM>();
        public List<StudentGradeVM> NumberGradeNameDesc = new List<StudentGradeVM>();
    }

    public class StudentGrade : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberGrade { get; set; }
        public string LetterGrade { get; set; }

        public int CompareTo(object obj)
        {
            return NumberGrade.CompareTo(obj);
        }
    }
}
