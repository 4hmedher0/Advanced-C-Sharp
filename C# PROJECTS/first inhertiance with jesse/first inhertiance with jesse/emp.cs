using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_inhertiance_with_jesse
{
    class emp : person
    {
        private double Salary;
        public double salary { get { if (this.Salary > 10000) return -1; else return this.Salary; } set {  if (value > 10000) this.Salary=-1; else this.Salary=value;  } }

        public void info() {


            //Console.WriteLine("my name is "+name +""+"my id is"+id+"my slaaly is:"+salary);
            //Console.WriteLine($"my name is {name} , my id is {person.id} and my salary is {salary}");
           // Console.WriteLine(@"my name is {name} my id is{id} my slaaly is:{salary} ");
            Console.WriteLine("my name is: {0}\nmy id is : {1}\nmy slaaly is:{2:c} ",name,id,salary);
            

        
        }
    }
}
