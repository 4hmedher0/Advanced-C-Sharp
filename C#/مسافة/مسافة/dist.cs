using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class dist //distance  
    {
        int km, m;
     public dist(){}
        public dist(int M)
     {
         int KM, MM;
            if (M > 0) M= M; else M = 0;
            KM= M / 1000;
            MM = M % 1000;
            this.km = KM; this.m = MM;
        }
       // public void nkm() { Console.WriteLine(km+"km "+m+"m"); }
       public void print() { Console.WriteLine("{0}KM {1}m",km,m); }
        public double  vtime(int time){return (double)(km*1000+m)/(double)(time*60);  }

        public static  dist operator+ (dist M1,dist M2)
        {
            dist sum = new dist();
            sum.km= M1.km + M2.km;
            sum.m = M1.m + M2.m; 
            return sum;      
        }

        public static  dist operator- (dist M1,dist M2)
        {
           // dist sub = new dist();
           int  subkm =Math.Abs( M1.km - M2.km);
            int subm =Math.Abs( M1.m - M2.m);
            return new  dist (subkm);
        }
        public static explicit operator dist (int a)
        { dist d=new dist(a);

        return d; 
        
        }
                public static explicit operator int (dist d)
                {
                    return d.km;
                
                }



    }
}
