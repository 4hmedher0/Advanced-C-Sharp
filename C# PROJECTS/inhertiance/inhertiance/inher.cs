using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertiance
{
 class father {


        public void print()
        {
            Console.WriteLine("we are printing from father class  ");
           
        }
        public virtual double x { get {return 2 ;}}
    }
    class boy : father {// public boy(){ Console.WriteLine("boy");  }
    public void  print() // we puts new to avoid warming from compiler 
    {
    Console.WriteLine(" boy  "); 
    //base.print();// we must use that to mange this method to inhertiance frrom father // من الاخر كدة انت بستدعي الدالة برنت اللي فوق 
//Console.WriteLine(base.x);
    }
    public override double x { get { return -3; } }
      
    }

   


}

