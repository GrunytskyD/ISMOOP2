using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class2
    {
        protected string Number;
        protected string Date;
        protected string Size;
    }
    public Class2(string number, string date, string size)
    {
        Number = number;
        Date = date;
        Size = size;
    }
    static void Main(string[] args)
    {

        Class2 class2 = new Class2("4", "03.05.2019", "25");
            
    }
}
