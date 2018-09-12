using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    class indx
    {
        public string Name { get; set; }
        public int grade { get; set; }
         int[] arr = {2,6,9};
         public indx(string name, int grade)
         {
             this.Name = name;
             this.grade = grade; 
         }
         public int this[int index]
         {
             get
             {
                 if (index > 0 && index < arr.Length)
                     return arr[index];
                 else return -1 ;
             }
             set
             {
                 if (index > 0 && index < arr.Length)

                     value = this.arr[index];
                
             }
         
         }
         public void print()
         {
             Console.WriteLine("Name  is {0} , grade is {1}",Name,grade);
         }
        
    } 
}