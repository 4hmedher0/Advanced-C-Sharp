using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_as_class_member
{
    class Program
    {
        static void Main(string[] args)
        {
            matrix M = new matrix(3, 5, 7);
            matrix a = new matrix(9, 13, 19);
            //Console.WriteLine( a.back(M));
           // M.print();
          // Console.WriteLine(M.back(M));
          // Console.WriteLine( M.back(a));
          //M = M.back(a);
          //
            M--;
            M.print();
           



        }
    }
}
