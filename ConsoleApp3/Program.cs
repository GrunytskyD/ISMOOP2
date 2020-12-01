using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected string BirthDate;
        public Person(string firstName, string lastName,string birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        static void Main(string[] args)
        {
            Person person = new Person("Petro","Petrov","02.03.2020");
            Entrant entrant = new Entrant("8", "195", "10");
            Student student = new Student("1","Software engineering","10");
            Teacher teacher = new Teacher("Dean", "Software engineering", "Zhytomyr Politechnic");
            Class2 class2 = new Class2("4", "03.05.2019", "25");
            Console.WriteLine(student.ShowInfo());
        }
    }
}
