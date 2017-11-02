using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DRY
{
    class Class3
    {
        private static string address = Constants.Address;
        private static string format = Constants.StandardFormat;

        private static void DoSomething()
        {
            Console.WriteLine(format, "Nils", "a good friend", address, 30);
        }

        private static void DoSomethingAgain()
        {
            Console.WriteLine(format, "Christian", "a neighbour", address, 54);
        }

        private static void DoSomethingMore()
        {
            Console.WriteLine(format, "Eva", "my daughter", address, 4);
        }

        private static void DoSomethingExtraordinary()
        {
            Console.WriteLine(format, "Lilly", "my daughter's best friend", address, 4);
        }
    }
}
