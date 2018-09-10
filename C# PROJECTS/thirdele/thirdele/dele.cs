using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdele
{
 public delegate  void  delegat (string name,int id);
    class dele
    {
        public void citizen(string name, int id)
        {
            Console.WriteLine(" $Citizen$ your name is  :{0} \n id :{1} \n", name, id);
        }
        public void person(string name, int id)
        {
            Console.WriteLine(" $Person1$ your name is  :{0} \n id :{1:d3} \n you are honour person  ", name, id);
        }
        public void person(delegat q)
        {
          //  Console.WriteLine(q("Ahemd", 13));
            Console.Write("$Person2$");

            q("Ahemd", 13);
        }
       
       
    }
}
