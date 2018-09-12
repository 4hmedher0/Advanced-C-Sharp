using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class myarray
    {
        int[] arr = new int[6];
        ~myarray()
        {
       //     Console.WriteLine("counter is : "+count.counter++);
        }
        public myarray()
        {
        }
        public myarray (int a,int b,int c,int d,int e,int f )
    {
    
      arr[0]=a;arr[1]=b;arr[2]=c;arr[3]=d;arr[4]=e;arr[5]=f; }
    
        public  int[] addarray(int[] a, int[] b) //operator +
        {  int [] sum={a[0]+b[0],a[1]+b[1],a[2]+b[2],a[3]+b[3],a[4]+b[4],a[5]+b[5]};
        return sum;     
        }
    //    public static implicit operator int(string[] a)
      //  {
        //    return 10;
        
        //}
        public void print(int[] a, int size)
        {
            for (int i = 0; i <size; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
   
    }
}
