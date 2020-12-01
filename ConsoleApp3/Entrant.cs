using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Entrant
    {
        protected string Education;
        protected string Certificate;
        protected string School;
    }
    public Entrant(string education, string certificate, string school)
    {
        Education = education;
        Certificate = certificate;
        School = school;

    }
    static void Main(string[] args)
    {
        Entrant entrant = new Entrant("8", "195", "10");
    }

}
