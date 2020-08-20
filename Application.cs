using System;
using StudentRosterProgram.Model;

namespace StudentRosterProgram
{
    class Application
    {
        static void Main(string[] args)
        {
            DisplayRosterStudentsWithRosterCollection();
            DisplayRosterStudentsWithDataMember();
        }

        private static void DisplayRosterStudentsWithRosterCollection()
        {
            var student = new Student("Cody", "Vollrath", 100);
            var student2 = new Student("David", "Allen", 97);

            var roster = new Roster {student, student2};

            foreach (var currentStudent in roster)
            {
                Console.WriteLine(currentStudent);
            }
        }

        private static void DisplayRosterStudentsWithDataMember()
        {
            var student = new Student("Cody", "Vollrath", 100);
            var student2 = new Student("David", "Allen", 97);

            var roster = new Roster { student, student2 };
            var students = roster.RosterStudents;

            foreach (var currentStudent in students)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
}
