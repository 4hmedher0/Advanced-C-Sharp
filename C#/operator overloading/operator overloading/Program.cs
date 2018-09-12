using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
          opov p = new opov(); 
            opov t1 = new opov(2, 6, 2);
            opov t2 = new opov(2, 2, 9);
            opov t3 = new opov();
            t3 = t1 + t2;
            t3.print();
      //     p.print(); Console.WriteLine(t3);
            //opov.add(t1, t2);
         //   p.print();
           // Console.ReadKey();
          //  opov.print();
        }
    }
}
