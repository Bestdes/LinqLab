using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PracticeSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            Students.Add(new Student("Jimmy", 20, 3.0, YearLevel.Sophmore));
            Students.Add(new Student("Hana", 21, 3.5, YearLevel.Junior));
            Students.Add(new Student("Alice", 22, 2.9, YearLevel.Senior));
            //Jimmy got a late start
            Students.Add(new Student("Jimmy", 21, 3.0, YearLevel.Freshman));


            foreach (Student student in Students)
            {
                if (student.Age >= 21 && student.GPA >= 3.0)
                {
                    if (student.YearLevel.ToString().Equals("Junior") || student.YearLevel.ToString().Equals("Senior"))
                    {
                        Console.WriteLine(student.Name);
                    }

                }
            }

            Console.WriteLine("-------------------------------------------");

            List<int> nums = new List<int> { 5, 5, 5, 3, 29, 10, 38 };
            List<int> numsList2 = new List<int> { 2, 2, 3, 29, 10, 38 };

            var fives = from n in nums
                        where n == 5
                        select n;

            List<int> numsOutput = fives.ToList();

            foreach (int n in numsOutput)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-------------------------------------------");

            var fiveList = numsList2.Where(x => x == 2).ToList();

            foreach (int five in fiveList)
            {
                Console.WriteLine(five);
            }

            Console.WriteLine("-------------------------------------------");

            int fiveCheck = nums.Count(x => x == 5);

            Console.WriteLine(fiveCheck);

            Console.WriteLine("-------------------------------------------");

            int max = nums.Where(x => x % 2 == 1).Max();

            Console.WriteLine(max);

            Console.WriteLine("-------------------------------------------");

            var targetStudent = from n in Students
                                where (n.Age >= 21)
                                && (n.GPA >= 3.0)
                                && (n.YearLevel.ToString().Equals("Junior")
                                || n.YearLevel.ToString().Equals("Senior"))
                                select n;

            List<Student> targetStudentList = targetStudent.ToList();

            foreach (var n in targetStudentList)
            {
                Console.WriteLine(n.Name);
            }

            Console.WriteLine("-------------------------------------------");

            var targstud = Students.Where(x => x.Age >= 21).Where(x => x.GPA >= 3.0).Where(x => (x.YearLevel.ToString().Equals("Senior")|| x.YearLevel.ToString().Equals("Junior"))).ToList();

            foreach(Student student in targstud)

            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("-------------------------------------------");



            //--------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("This is the beginning of Part 1 of the Lab: Nums");


            int[] nums2 = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students2 = new List<Student>();
            students2.Add(new Student("Jimmy", 13));
            students2.Add(new Student("Hannah Banana", 21));
            students2.Add(new Student("Justin", 30));
            students2.Add(new Student("Sarah", 53));
            students2.Add(new Student("Hannibal", 15));
            students2.Add(new Student("Philip", 16));
            students2.Add(new Student("Maria", 63));
            students2.Add(new Student("Abe", 33));
            students2.Add(new Student("Curtis", 10));



            int maxValue = nums2.Max(); Console.WriteLine(maxValue);
            int minValue = nums2.Min(); Console.WriteLine(minValue);
            int specificMax = nums2.Where(x => x < 10000).Max();
            int[] allValues10To100 = nums2.Where(x => x > 10).Where(x => x < 100).ToArray(); 
            foreach(int target in allValues10To100)
            {
                Console.WriteLine(target);
            }

            int[] allValues100000To999999Inclu = nums2.Where(x => x >= 100000).Where(x => x <= 999999).ToArray();
            foreach (int target in allValues100000To999999Inclu)
            {
                Console.WriteLine(target);
            }

            int count = nums2.Where(x => x % 2 == 0).Count(); Console.WriteLine(count);

            Console.WriteLine("This is the beginning of Part 2 of the Lab: Students");

            var over21 = from n in students2
                         where n.Age >= 21
                         select n;
            foreach(Student student in over21)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("-------------------------------------------");

            var youngestStudent = (from n in students2
                                   where n.Age == minValue
                                   select n.Name).Min(); Console.WriteLine(youngestStudent);

            Console.WriteLine("-------------------------------------------");


            var oldestUnder25 = (from n in students2
                                where n.Age < 25
                                select n.Name).Max(); Console.WriteLine(oldestUnder25);

            var allOver25Even = from n in students2
                                where (n.Age > 21)
                                && (n.Age % 2 == 0)
                                select n;
            foreach (Student student in allOver25Even)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("-------------------------------------------");

            var allTeenage = from n in students2
                             where (n.Age >= 13
                             && n.Age <= 19)
                             select n;

            foreach (Student student in allTeenage)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("-------------------------------------------");

            var startsWithVowel = from n in students2
                                  where Regex.IsMatch(n.Name, @"(^\b[aeiouAEIOU]\w*$)")
                                  select n;

            foreach (Student student in startsWithVowel)
            {
                Console.WriteLine(student.Name);
            }

                                




        }


    }
}