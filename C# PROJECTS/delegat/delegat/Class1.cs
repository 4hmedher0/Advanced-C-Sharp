using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 public delegate void dele (int a);
namespace delegat {
    class Class1
    {
        public static  void test(int a) { Console.WriteLine(a); }  
        //dele a = new dele(test);
        //a(10);
        //public int 
        //dele c = new dele(test);
        dele x = new dele(test);


    }
}
