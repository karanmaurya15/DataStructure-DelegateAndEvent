using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_DelegateAndEvent
{
    internal class SingleCastDelegate
    {
        public delegate int operation(int x, int y);
        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
