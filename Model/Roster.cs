using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentRosterProgram.Model
{
    public class Roster : ICollection<Student>
    {

        public List<Student> RosterStudents { get; }


        /// <summary>Initializes a new instance of the <see cref="Roster" /> class.</summary>
        public Roster()
        {
            this.RosterStudents = new List<Student>();
        }


        public int Count => this.RosterStudents.Count;

        public bool IsReadOnly => false;

        public void Add(Student item)
        {
            this.RosterStudents.Add(item);
        }

        public void Clear()
        {
            this.RosterStudents.Clear();
        }

        public bool Contains(Student item)
        {
            return this.RosterStudents.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            this.RosterStudents.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return this.RosterStudents.GetEnumerator();
        }

        public bool Remove(Student item)
        {
            return this.RosterStudents.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.RosterStudents.GetEnumerator();
        }
    }
}
