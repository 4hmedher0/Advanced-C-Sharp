using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class square
    {
       public  int L;
        public square() { }
        public square(int l)
        { L = l; }

        public int len { set {L=(L>0)?value:0;
        }
            get { return L; }
        }
        public int area() { return L * L; }
    }
}
