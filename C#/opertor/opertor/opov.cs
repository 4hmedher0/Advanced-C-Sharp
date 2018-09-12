using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opertor
{
    class opov
    {
        int x, y;
         public opov (int x,int y)
         {
         this.x=x;this.y=y;
         }
         public opov() { int nd = y * 24; int nm = x * 60; }
         public static opov operator+    (opov a,opov b)
         { opov sum=new opov();
             sum.x=a.x+b.y;
             sum.y=b.y+a.y;
             return sum;

         }
         public void print() {

             Console.WriteLine(x +""+y);
         }
    }
}
