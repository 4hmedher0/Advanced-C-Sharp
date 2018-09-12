using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_op
{
    class student
    {   public  int id ; public int grade;
        public student (int id ,int grade)
        { this.id=id;
            this.grade=grade;

        }
        public  void print (){

       Console.WriteLine("id : "+id+"\ngrade : "+grade); }
        public static  student operator+(student st1, student st2)
        {
           student newstudent=new student (st1.id+st2.id,st2.grade+st1.grade);
            return newstudent;
            
        }
        public static student operator +(student st1,int x)
        {
            student newstudent = new student(st1.id + x, x+ st1.grade);
            return newstudent;
        }
        public static bool operator>(student s1,student s2)
        {
            if (s1.grade > s2.grade ) return true;
            else return false  ;

        }
        public static bool operator <(student s1, student s2)
        {
            if (s1.grade < s2.grade) return true  ;
            else return false ;

        }
        public static student operator -(student st1, student st2)
        {
            student newst = new student(st1.id - st2.id, st1.grade - st2.grade);
            return newst;
        
        }
        //public static explicit operator int(student s1)
        //{

        //    return s1.grade;

        //} //تحويل واضح 
        public static implicit operator int(student s1)
        { return s1.grade;   }
       
    }
}
