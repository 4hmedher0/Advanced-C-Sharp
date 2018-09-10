using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertiance
{

       delegate father  dele ();// covariane    intreasted in return type 
    delegate void del ( boy a ); // contravaraince  intreated in parametres 
    class Program
    {   
       static boy method() { return null ; }
       static void mmethod(father a) {  } 
        static void Main(string[] args)
       {
           dele d = new dele(method);
           del A = new del(mmethod);

           // boy d = new boy();
           // d.print ();
           // father f = new father(2);
          //  f.print();
            //father b = new boy();
            //b.print();
          //  d.print();
            boy b = new boy();
            b.print();
            father f = new boy();
            f.print();
         //   boy b = new father(); mistake can't 
          //  b.print();
            Console.WriteLine(  b.x);
            Console.WriteLine(f.x);
            father p = new father();
            Console.WriteLine(p.x); //  it's from virtual  from father class 
            Console.WriteLine(b.x); // the same but from boy class after editing from boyy class 
            Console.WriteLine(f.x);// print from father boy class as the refreence is faher but it print form boy




        }
    }
}
