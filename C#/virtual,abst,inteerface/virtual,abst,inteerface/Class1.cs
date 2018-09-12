using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_abst_inteerface
{
    interface ishape 
    {
        void print(); // كل الميثود الموجودة هنا بتبقي بابلك افتراضياً والبروبيرتي بردك
        double x { get; set; }
       double area(); // 
       double sub(int x, int y);
    }
    abstract class shape
    { 
      public  abstract void  print ();
      public abstract double perimeter();
      public virtual double sum() { return -1; }
     // public virtual double print() {return 110.110;}
    }
    class test : shape , ishape 
    {
        double rad;
        public test(double rad) { this.rad = rad; }
        public override void print() { Console.WriteLine("print from abstract class"); }
        //public void print() { Console.WriteLine("derived from interface "); }
        public double x { get { return -2; } set { x = value + 100; } }// we don't put override  if it was dervied from  interface i think that . 
        public double  area() { return (rad * rad * Math.PI); }
        public override double perimeter() { return 2 * rad * Math.PI; }
        public override double sum  (){return 99.999;}
        public double sub(int x,int y) { return Math.Abs(x-y); } // it must takes 2 agruments lookslike his prototype in interfac
      
        //لما تيجي تعمل وراثة من الانترفيس مبتعملش اوفرريد  اكتب بس عادي ويكون نفس الاسم وهو  هيعرف علطول 
       //لما تيجي تورث بقي من ابستراكت يبقي اجباري تعمل اوفر ريد 
        //   لو فيرشوال بقي يبقي تعدل علي الدالة براحتك مش شرط تلتزم بي البروتوتيب سوء متحدد في انترفيس او ابسستراكت بس لازم تعمل اوفرريد بردك 
    }
}

