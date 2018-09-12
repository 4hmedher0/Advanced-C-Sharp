using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rev
{
    class yourclass:myclass
    {
        ~yourclass()
        {
            Console.WriteLine("from second  destructor "); //  هيطيع  الديستركتور القديم ثم ده 
        }
       private int n;
        public int N { get { return n + 9; } set { n = value + 10; } }
    }
}
