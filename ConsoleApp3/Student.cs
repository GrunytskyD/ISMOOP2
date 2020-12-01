using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
    public class Student:User
    {
        protected string Course;
        protected string Group;
        protected string Faculty;
        public Student(string firstName, string lastName, string course, string group, string faculty)
            : base(firstName, lastName, course, group, faculty)
        {
            Group = group;
        }
        public string GetGroup()
        {
            return Group;
        }
        public string ChangeGroup()
        {
            return Group;
        }
    }
}
