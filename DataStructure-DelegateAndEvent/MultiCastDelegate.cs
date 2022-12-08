using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_DelegateAndEvent
{
    class MultiCastDelegate
    {
        delegate void Delop(int x, int y);
        public static void ImplementDelegate()
        {
            Delop obj = Operation.Add;
            obj += Operation.Square;
            obj(3, 54);
            obj(9, 300);
        }
    }
    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a + b);
        }
        public static void Square(int a, int b)
        {
            Console.WriteLine("Multiple = {0}", a * b);
        }
    }
}
