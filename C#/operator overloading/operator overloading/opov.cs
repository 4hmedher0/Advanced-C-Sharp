using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class opov
    {
        public int our;public int min; public int scd;
        public opov() { }
        
        public opov(int our, int min, int scd)
        { this.our = our; this.min = min; this.scd = scd; }
        public static opov operator +(opov t1, opov t2)
        {  opov t3 =new opov();
        int totalscd = t1.scd + t2.scd;
        t3.scd = totalscd % 60;

        int totalmin = t1.min + t2.min + (totalscd / 60);
        t3.min = totalmin % 60;

        int totalour = t1.our + t2.our + (totalmin / 60);
        t3.our = totalour % 24; 

        return t3;
        }

        public void print() { Console.WriteLine("{0}:{1}:{2})",our,min,scd); }
 
   
    }
}
