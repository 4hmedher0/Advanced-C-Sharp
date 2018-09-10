using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_inhertiance_with_jesse
{
    class Program
    {
        static void Main(string[] args)
        {
            emp m = new emp();
            m.name = "Ahmed Mostafa ";
            m.id = "2299gh22";
            m.salary =5000;
            Console.WriteLine(m.salary);
            m.info();
        
        }
    }
}
