using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class User : Person
    {
        protected string Course;
        protected string Group;
        protected string Faculty;
        public User(string firstName, string lastName, string course, string group,string faculty)
            :base(firstName,lastName,group)
        {
            Course=course;
            Group=group;
            Faculty = faculty;
        }
        public string ShowInfo()
        {
            return $"{LastName}{FirstName}{Course}{Group}{Faculty}"
        }

    }
}
