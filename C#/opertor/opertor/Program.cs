using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opertor
{
    class Program
    {
        static void Main(string[] args)
        {
            opov a= new opov(2,4);
            opov b = new opov(2, 4);
           
            opov s = new opov(0,0);
            
            s = a + b;
           
            Console.WriteLine(s);
            //Console.WriteLine(opov.(a, b));
            s.print();
        }
    }
}
