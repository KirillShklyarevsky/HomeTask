using System;
using System.Collections.Generic;

namespace Events
{
    public class Student : ITaskPerfomer
    {
        public delegate void StudentTask(Student student, string answer);
        public event StudentTask HomeworkDone;

        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            set
            {
                _firstName = value;
            }

            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            set
            {
                _lastName = value;
            }

            get
            {
                return _lastName;
            }
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static Random random = new Random((int)DateTime.Now.Ticks);

        public void DoTask()
        {
            int answerLength = random.Next(1, 10);
            string answer = String.Empty;
            for (int i = 0; i < answerLength; i++)
            {
                answer += $"{(char)random.Next(65, 90)}";
            }
            HomeworkDone?.Invoke(this,answer);
        }
    }
}
