using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLOYMORIHRISM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> Li = new List<person>();// this list can take any number of person ,students and emps List take a List of classes objects 
           // Li.Add(new student());
            //Li.Add(new person());
            //Li.Add(new emp());


            person p = new student(); // it look to student as a person 
            student s1 = p as student;// as keyword to convert   خد المواطن بي وعاملة كاطالب واديلة اسم اس 1 
            person em = new emp();
            emp a = em as emp; // كدة بتقولة  عامل البريسون اللي اسمة اي ام كموظف واديلة اسم اه 
 
          // now i can use  s1 as a student after converation 
            //student p1 = new  person();  it's denied can't person take from student
            student s = new student();
            s.grade = 9;
            s.id = 44;
            s.name = "medo";
            emp e = new emp();
            e.id = 55;
            e.name = "Gamal";
            e.salary = 3000;
            Li.Add(s);
            Li.Add(e);
            foreach (person per in Li)
            {
               // Console.WriteLine(per); iterator only see as A person we must converation it as a emp and student
                if (per is student) // is keyword   اعمل فحص لو بير بيكون طالب يبقي نعاملة كطالب  
                {
                    student S = per as  student;
                    Console.WriteLine(S.grade);
                }
                else if  (per is emp)
                {
                    emp E = per as emp;
                    Console.WriteLine(E.salary);
                }
                else Console.WriteLine("\awrong");
            
            }
         
        }
    }
}
