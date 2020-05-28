using System;
using System.Collections.Generic;
using System.Text;
namespace PracticeSearching
{
    public enum YearLevel
    {
        Freshman,
        Sophmore,
        Junior,
        Senior,
        Other
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public YearLevel YearLevel { get; set; }
        public Student(string Name, int Age, double GPA, YearLevel YearLevel)
        {
            this.Name = Name;
            this.Age = Age;
            this.GPA = GPA;
            this.YearLevel = YearLevel;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}