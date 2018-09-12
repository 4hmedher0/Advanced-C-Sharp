using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static void Main(string[] args)
        {
            dist d = new dist(2000); dist d2 = new dist(3220); dist sum = new dist(0);
            d.print(); dist sub = new dist();
            Console.WriteLine("speed is " + (d.vtime(10)) + " m/s");
            d2.print();

            sum = d + d2;
            Console.WriteLine(sub = d - d2);
            Console.WriteLine(sum);
            sum.print();

            //dist d1 = new dist(2000); dist d2 = new dist(3000); dist res = null;
            //res = d1 - d2; Console.WriteLine(res); Console.WriteLine(res = d1 + d2);
            int te = 9000;
            dist d0=new dist ();

           // te = d0;
         //   d0 = te;

            Console.WriteLine("____________"+d0);
           
        }
    }
}
