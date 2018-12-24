using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }

        public Student(string user, List<DateTime> date)
        {
            Name = user;
            Dates = date;
            Comments = new List<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputUserAndDates = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (inputUserAndDates != "end of dates")
            {
                string[] userAndDates = inputUserAndDates.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = userAndDates[0];
                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i < userAndDates.Length; i++)
                {
                    dates.Add(DateTime.ParseExact(userAndDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                Student student = new Student(user, dates);
                bool isFound = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == student.Name)
                    {
                        students[i].Dates.AddRange(dates);
                        isFound = true;
                        break;
                    }

                }
                if (!isFound)
                {
                    students.Add(student);
                }
                inputUserAndDates = Console.ReadLine();
            }

            string inputUserAndComments = Console.ReadLine();
            while (inputUserAndComments != "end of comments")
            {
                //string[] userAndComments = inputUserAndComments.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                //string user = userAndComments.FirstOrDefault();
                //string comments = userAndComments.LastOrDefault();
                //List<string> comments = new List<string>();
                //for (int i = userAndComments.Length - 1; i >= 0; i--)
                //{
                foreach (var student in students)
                {
                    string comment = inputUserAndComments.Replace(student.Name, "");
                    string user = inputUserAndComments.Replace(comment, "");

                    string[] userAndComments = comment.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (student.Name==user)
                    {
                        for (int i = 0; i < userAndComments.Length; i++)
                        {
                            
                            student.Comments.Add(userAndComments[i]);
                        }
                    }
                }                
                //}
                inputUserAndComments = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(n => n.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments.Distinct())
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var dates in student.Dates.OrderBy(d => d.Date))
                {
                    Console.WriteLine($"-- {dates.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
