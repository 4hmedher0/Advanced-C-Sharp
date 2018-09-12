using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {    
        static void Main(string[] args)
        {
            emp emp = new emp();
            emp.salary += emp_salary;
           emp.getsal(190);
            //emp.sal = 120; 
            //emp.salary+=emp_salary;
           // emp.sal = 9000;
            emp.salary  +=() =>Console.WriteLine("winner");
           // emp.salary + = emp.salary () {Console.WriteLine("looser ");}
            emp.dele dname = delegate { Console.WriteLine("22"); };
            dname();
            emp.dele dd = () => Console.WriteLine("myegy");
            dd();
            emp.salary += () => Console.WriteLine("www");
            emp_salary();

        }


        static void emp_salary()
        {
           // throw new NotImplementedException();
            Console.WriteLine("emp has get a full salary");
            Console.WriteLine("job job  ");
        }
    }
    class emp  {
        public delegate void dele();
        public event dele salary;
        double Sal;
        public double sal { get { return Sal; }
 set { Sal = value; if (Sal > 100) { if (salary != null) { salary(); } } } }
    
              public  void getsal (int bouns)
      {
          Sal += bouns;            
             
     }
           
    
    }
}
