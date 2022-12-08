using static DataStructure_DelegateAndEvent.SingleCastDelegate;

namespace DataStructure_DelegateAndEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate and Events");

            operation obj = new operation(SingleCastDelegate.Addition);
            Console.WriteLine("Single Cast Delegate");
            Console.WriteLine("Addition is = {0}", obj(230, 70));

            Console.WriteLine("\nMulticast Delegate");
            MultiCastDelegate.ImplementDelegate();
        }
    }
}