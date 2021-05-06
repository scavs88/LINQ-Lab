using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            MinMethod(nums);
            MaxMethod(nums);
            MaxLessThan1000(nums);
            Between(nums);
            BetweenBig(nums);

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            DrunkStudents(students);
            YoungStudents(students);
            OldStudents(students);
            StudentBetween(students);
            DrunkEvenStudents(students);
            TeenAgeStudents(students);
        }

        static void MinMethod(int[] nums)
        {
            int minNum = nums.Min();
            Console.WriteLine(minNum);                
        }

        static void MaxMethod(int[] nums)
        {
            int maxNum = nums.Max();
            Console.WriteLine(maxNum);
        }

        static void MaxLessThan1000(int[] nums)
        {
            var maxNumLess = from n in nums
                             where n < 10000
                             select n;
            var maxed = maxNumLess.Max();
            Console.WriteLine(maxed);                        
        }

        static void Between(int [] nums)
        {
            var betweener = from m in nums
                            where m >= 10 && m <= 100
                            select m;
            foreach(int num in betweener)
            {
                Console.WriteLine(num);
            }
        }

        static void BetweenBig(int[] nums)
        {
            var betweener = from m in nums
                            where m >= 100000 && m <= 999999
                            select m;
            foreach (int num in betweener)
            {
                Console.WriteLine(num);
            }
        }

        static void DrunkStudents(List<Student> students)
        {
            var drunk = from s in students
                        where s.Age > 20 && s.Age % 2 == 0
                        select s;
            foreach(Student stud in drunk)
            {
                Console.WriteLine(stud.Name);
            }
            
        }

        static void OldStudents(List<Student> students)
        {
            var ordered = students.OrderByDescending(stud => stud.Age).ToList();
            Console.WriteLine(ordered[0].Name);
        }
        static void YoungStudents(List<Student> students)
        {
            List<Student> orderedStudents = (from stu in students
                                             orderby stu.Age
                                             select stu).ToList();

            Console.WriteLine(orderedStudents[0].Name);
        }

        static void StudentBetween(List<Student> students)
        {
            var student = students.Where(s => s.Age <= 25).ToList();
            var ordered = student.OrderByDescending(stud => stud.Age).ToList();
            Console.WriteLine(ordered[0].Name);
        }

        static void DrunkEvenStudents(List<Student> students)
        {
            var drunk = from s in students
                        where s.Age > 20 && s.Age % 2 == 0
                        select s;
            foreach (Student stud in drunk)
            {
                Console.WriteLine(stud.Name);
            }

        }

        static void TeenAgeStudents(List<Student> students)
        {
            var stud = from s in students
                       where s.Age <= 19 && s.Age >= 13
                       select s;
            foreach(Student stude in stud)
            {
                Console.WriteLine(stude.Name);
            }
        }

    }
}
