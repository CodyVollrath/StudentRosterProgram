using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRosterProgram.Model
{

    /// <summary>This class represents a student in a class room with a name and a grade.</summary>
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get;}
        public int Grade { get; set; }


        /// <summary>Initializes a new instance of the <see cref="Student" /> class.</summary>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="lastName">The last name of the student.</param>
        /// <param name="grade">The grade that the student currently has.</param>
        /// <exception cref="ArgumentNullException">  firstName is not null and lastName is not null</exception>
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.FullName = firstName + " " + lastName;
            this.Grade = grade;
        }


        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Student Name: {this.FullName} | Student Grade: {this.Grade}";
        }
    }
}
