using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    public class Student
    {
        public string Name { set; get; }
        public List<double> Grades { set; get; }
        public double AverageGrade
        {
            get
            {
                return Grades.Sum() / Grades.Count;
            }
        }
        public Student(string name,List<double> grades)
    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Student[] students = new Student[studentsCount];
            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(' ').ToArray();
                students[i].Name = studentInfo[0];
                students[i].Grades = new List<double>();
                for (int j = 1; j < studentInfo.Length; j++)
                {
                    double grade = double.Parse(studentInfo[j]);
                    student.Grades.Add(grade);
                }
                students.;
            }
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade}");
            }
        }
    }
}
