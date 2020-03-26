using System;
using System.Collections.Generic;

namespace Events
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Kirill", "Young"));
            students.Add(new Student("Agatha", "MacDonald"));
            students.Add(new Student("Albert", "O’Connor"));
            students.Add(new Student("Adam", "Gordon"));
            students.Add(new Student("Amanda", "Brian"));
            students.Add(new Student("Alexander", "Chester"));
            students.Add(new Student("Andrew ", "Grant"));
            students.Add(new Student("Anna", "Ross"));
            students.Add(new Student("Augusta", "Walter"));
            students.Add(new Student("Audrey", "Smith"));

            Teacher teacher = new Teacher();

            foreach (Student student in students)
            {
                teacher.AddStudent(student);
            }

            foreach (Student student in students)
            {
                student.DoTask();
            }
        }
    }
}
