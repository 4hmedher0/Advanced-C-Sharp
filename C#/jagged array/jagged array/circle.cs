using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class circle
    {
         public int rad;
         public circle() { }
        public circle(int rad)
         {
            this.rad = rad; }

        public  int  Rad {
    set {rad=(rad>0)?value:0; }
            get {
 
                return rad; }      
   
    }

        public double area()
        {
            return (rad * rad) * 3.14;
        
        }
        public double per()
        {
            return (rad * 2) * 3.14;
        }
       
    
    
    
    
    
    
    }
}
