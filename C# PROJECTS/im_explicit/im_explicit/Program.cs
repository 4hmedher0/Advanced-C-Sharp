using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace im_explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            st a = new st("ali", 90);
            st b = new st("medo", 77);
            st c = a + b;
            c.print();
            if (a > b) Console.WriteLine("a is greater than b");
            else Console.WriteLine("a is less than b");
            float q;
            q = (float)a; // explicit 
            Console.WriteLine(q);
            string w;
            w = a; // w=(string)a no problem as it impliit  
            Console.WriteLine(w);
         //   q = 900; 
            Console.WriteLine("_______________________\n");
          // Console.WriteLine(a);
            //a.print();
       //     a = 22.44f;
            a.print();
        
        }
    }
}
