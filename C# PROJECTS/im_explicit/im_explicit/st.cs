using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace im_explicit
{
    class st
    {
        string name; float degree;
        public st( string name,float degree)
        {
            this.name = name;
            this.degree = degree;
        }
        public void print()
        {
            Console.WriteLine("NAME : {0}   DEGREE : {1}",name,degree);
        }
          public static st operator + (st a,st b)
          {
             st s = new st(a.name + b.name, a.degree + b.degree);
             return s;        
          }
          //relational operator overlloading you return boolean varialble  || must make  all operation <>
          public static bool operator <(st a, st b)
          {

              if (a.degree > b.degree)
                  return true ;
              else return false ;
          
          }
          public static bool operator >(st a, st b)
          {

              if (!(a.degree > b.degree))
                  return true;
              else return false;
          }
         // converation operator 
         // type of converation oprator what we convert to  (object )
          public static explicit  operator float(st a)
          {
              return a.degree;
          
          }
          public static implicit operator string(st a)
          {

              return a.name;
          }
         public static  implicit operator st  (float p )
    {
        st o = new st("pop", p);
    return  p ;
    
    }



    }
}
