using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRosterProgram.Model
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get;}
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.FullName = firstName + " " + lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("Student Name: {0} | Student Grade: {1}", this.FullName, this.Grade);
        }
    }
}
