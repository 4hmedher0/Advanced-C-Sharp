using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delegat;
namespace delegat
{
    class Program
    {
        private static dele test;
        public static void ww(int a) { Console.WriteLine(a); }
        Class1 clas = new Class1();
        static void Main(string[] args)
        { 
            dele w=new dele (ww);
        w(23);


    //    dele d = new dele(clas.test);
            
            // dele qq = new dele(clas.test);
        //ww(20);
            //dele d = new dele(test);
           // Console.WriteLine (d(10);
        }
    }
}
