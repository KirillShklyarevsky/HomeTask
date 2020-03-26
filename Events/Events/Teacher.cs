using System;
using System.Collections.Generic;

namespace Events
{
    public class Teacher
    {
        public List<string> TaskResults { get; private set; }
        public List<Student> Students { get; private set; }

        public Teacher()
        {
            TaskResults = new List<string>();
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            student.HomeworkDone += HomeworkAccepte;
        }

        public void HomeworkAccepte(Student student, string answer)
        {
            TaskResults.Add(student.FirstName + " " + student.LastName + " " + answer);

            if (TaskResults.Count == Students.Count)
            {
                PrintAllResults();
            }
        }
        
        public void PrintAllResults()
        {
            foreach (var result in TaskResults)
            {
                Console.WriteLine(result);
            }
        }
    }
}
