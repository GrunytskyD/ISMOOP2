using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Teacher
    {
        protected string Position;
        protected string Chair;
        protected string Institution;
    }
    public Teacher(string position, string chair, string institution)
        
    {
        Position = position;
        Chair = chair;
        Institution = institution;

    }
    static void Main(string[] args)
    {
        
        Teacher teacher = new Teacher("Dean", "Software engineering", "Zhytomyr Politechnic");
    }
}
