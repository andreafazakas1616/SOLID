using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DRY
{
    class Class4
    {
        private static string address = Constants.Address;
        private static string format = Constants.StandardFormat;

        private static void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(format, name, description, address, age);
        }

        private static void DoSomething()
        {
            WriteToConsole("Nils", "a good friend", 30);
        }

        private static void DoSomethingAgain()
        {
            WriteToConsole("Christian", "a neighbour", 54);
        }

        private static void DoSomethingMore()
        {
            WriteToConsole("Eva", "my daughter", 4);
        }

        private static void DoSomethingExtraordinary()
        {
            WriteToConsole("Lilly", "my daughter's best friend", 4);
        }
    }
}
