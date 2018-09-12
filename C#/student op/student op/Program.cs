using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_op
{
    class Program
    {
        static void Main(string[] args)
        {
            student st1 = new student(20,6);
            student st2 = new student(8,9);
            student newst = st1 + st2;
            Console.WriteLine(newst); // لن يطبع القيمة لازم تستخدم الدالة برنت 
            newst.print();
            student s4 = (st1 + 9);
            Console.WriteLine("_________");
            s4.print();
            Console.WriteLine("_________");
            if (st1 > st2) Console.WriteLine("st1 wins");
            else Console.WriteLine("st2 wins ");
            if (st2.grade < st1.grade) Console.WriteLine("st1 wins");
            else Console.WriteLine("st2 wins ");
            Console.WriteLine("_________");
            student s5 = st1 - st2;
            s5.print();
            Console.WriteLine("_________");

            //int x = (int)st1;
            int x = st1;
            Console.WriteLine(x);







        }
    }
}
