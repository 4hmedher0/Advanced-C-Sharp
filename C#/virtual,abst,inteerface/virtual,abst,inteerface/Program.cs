using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_abst_inteerface
{
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test(2);
            t.area();
                t.print();
                t.sum();
                Console.WriteLine ("property  is : \t "+t.x);
              //  t.x = 99; Console.WriteLine(t.x);
                t.sum();
                t.perimeter();
                Console.WriteLine(t.sub(100, 90)); 
                Console.WriteLine("********************************\n\a");
            //    shape s = new test (3.98);
            //   shape p = new test(7);  can't do object for abstract 
            //   shape k = new shape(); /.
            //    shape m = new ishape();
                shape s = new test(3);
                s.print();
                // callling by using ishape interface as a reference 
                ishape e = new test(5); //ال اوبجكت اي بيشوف بس المشترك بين الانترفيس والكلاس تست انما ميفدرش يشوف كل اللي موجود في التست بيشوف بس اللي هما مورثة لية ويعمل اكسس عليه عادي .
                Console.WriteLine(e.area());
                Console.WriteLine(e.sub(5, 9));           
                Console.WriteLine(e.x);
            
            //Console.WriteLine(s.print()); //the call is ambigous 


               

        }
    }
}
