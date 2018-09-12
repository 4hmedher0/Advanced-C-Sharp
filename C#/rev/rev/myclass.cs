using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rev
{
    class myclass
    {
        public int n1 { set { n1 = value + 3; } get { return n1 - 3; } }
        public int n2 { get { if (n2 > 20) return 99; else return -99; } set { if (value > 20)Console.WriteLine("value greater than 20 "); } }
        ~myclass()
        {
            Console.WriteLine("hello 5asb 3nk ");
        }
      
    private int num;
    private string name;
    public int Num 
    {
        set
        {

            if (value > 20) this.num = 99;
            else this.num = -7;

        
        }
        get
        {
            if (num > 20) return 99;
            else return -7;

        }
    
    }
    public string Name 
    {
        get
        {
            if (this.name.Contains("a")) 
                return "good";
            else return "bad";
        }
        set
        {
            if (value.Contains("a")) this.name = "good";
            else this.name = "bad";
        }
    }
    public void method()
    {
        Console.WriteLine("$$$$ from method of class ");
    }
    }

}
