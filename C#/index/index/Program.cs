using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    class Program
    {
        static void Main(string[] args)
        {
            indx ind = new indx("asi",80);
          Console.WriteLine(ind[2]);
          ind.print();
          var course = new[] {new {id=00,name="it"},
          new {id=11,name="IS"}};
          foreach (var cour in course)
          {
              Console.WriteLine("the id {0}, name {1}",cour.id,cour.name);
          }
        }
    }
}
