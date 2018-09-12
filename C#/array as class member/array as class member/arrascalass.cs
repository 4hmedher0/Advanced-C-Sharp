using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_as_class_member
{
    class matrix
    {
        int[] arr = new int[3];
        public matrix(int a, int b, int c)
        {

            this.arr[0] = a; this.arr[1] = b; this.arr[2] = c;
        }
        public matrix() { }
       
      // public matrix() { arr[0] = 1; }
        public void print()
        { 
         foreach(int i in arr) {Console.WriteLine(i);}
        }
        public static  matrix operator --(matrix m) {

            int A = m.arr[0] - 1;
            int B = m.arr[1] - 1;
            int C = m.arr[2] - 1;
            
            //matrix M=new matrix (m.arr[0]--,arr[1]--,arr[2]--);
            //matrix M=new matrix (A,B,C);
            return new matrix(A,B,C);
             
        
        }

    }
}
